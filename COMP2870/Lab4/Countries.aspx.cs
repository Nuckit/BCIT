using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Xml;
using System.Xml.Serialization;
using ASP;

public partial class Countries : Page
{
    private const string BooksXmlPath = "Books.xml";

    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void ButtonAddCountry_Click(object sender, EventArgs e)
    {
        Country country = new Country
        {
            Name = TextBoxCountryName.Text,
            Population = Convert.ToUInt32(TextBoxPopulation.Text),
            Capital = TextBoxCapitalCity.Text
        };

        List<Country> countries = GetAllCountries();
        countries.Add(country);

        TextBoxCountryName.Text = string.Empty;
        TextBoxPopulation.Text = string.Empty;
        TextBoxCapitalCity.Text = string.Empty;
    }
    protected void ButtonCreateXmlWithSerialization_Click(object sender, EventArgs e)
    {        
        WriteXmlWithSerialization();
    }

    protected void ButtonCreateXmlWithoutSerialization_Click(object sender, EventArgs e)
    {
        WriteXmlWithoutSerialization();        
    }

    private void WriteXmlWithoutSerialization()
    {
        using (XmlTextWriter xmlWriter = new XmlTextWriter(Server.MapPath(BooksXmlPath), Encoding.UTF8))
        {
            xmlWriter.Formatting = Formatting.Indented;

            List<Country> countries = GetAllCountries();

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("Written: " + DateTime.UtcNow);
            xmlWriter.WriteStartElement("Countries");

            foreach (Country country in countries)
            {
                xmlWriter.WriteStartElement(typeof(Country).ToString());
                xmlWriter.WriteAttributeString("Name", country.Name);
                xmlWriter.WriteElementString("Population", country.Population.ToString());
                xmlWriter.WriteElementString("Capital", country.Capital);
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();
        }

        StringBuilder sb = new StringBuilder();

        using (XmlTextReader xmlTextReader = new XmlTextReader(Server.MapPath(BooksXmlPath)))
        {
            while (xmlTextReader.Read())
            {
                switch (xmlTextReader.NodeType)
                {
                    case XmlNodeType.XmlDeclaration:
                    case XmlNodeType.Comment:
                    case XmlNodeType.Element:
                    {
                        string s = String.Format("{0}: {1} <br/>", xmlTextReader.NodeType,
                            xmlTextReader.Name);
                        sb.Append(s);
                        break;
                    }
                    case XmlNodeType.Text:
                    {
                        string s = String.Format("&nbsp;&nbsp;&nbsp;<b>Value: {0} </b></br>",
                            xmlTextReader.Value);
                        sb.Append(s);
                    }
                        break;
                }
                if (xmlTextReader.HasAttributes)
                {
                    while (xmlTextReader.MoveToNextAttribute())
                    {

                        string s = String.Format("&nbsp;&nbsp;&nbsp;<i>Attribute: {0} = {1}</i></br>",
                            xmlTextReader.Name,
                            xmlTextReader.Value);
                        sb.Append(s);

                    }
                }
            }
        }

        LabelXml.Text = sb.ToString();
    }

    private void WriteXmlWithSerialization()
    {
        MemoryStream memoryStream = new MemoryStream();
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Country>));
        Response.ContentType = "text/xml";
        XmlTextWriter xmlWriter = new XmlTextWriter(memoryStream, Encoding.UTF8)
        {
            Formatting = Formatting.Indented
        };


        xmlSerializer.Serialize(xmlWriter, GetAllCountries());
        memoryStream = (MemoryStream)xmlWriter.BaseStream;
        UTF8Encoding encoding = new UTF8Encoding();

        string data = encoding.GetString(memoryStream.ToArray());

        Response.Clear();
        Response.ContentType = "text/xml";

        //Response.Cache.SetCacheability(HttpCacheability.NoCache);

        //Response.Cache.SetAllowResponseInBrowserHistory(true);
        Response.Write(data);
        Response.End();
    }

    private List<Country> GetAllCountries()
    {
        return Session[global_asax.CountriesListKey] as List<Country>;
    }
}