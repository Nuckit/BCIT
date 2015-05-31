using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.Xml;
using System.Xml.Serialization;
using ASP;

public partial class Countries : Page
{
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
    protected void ButtonCreateXml_Click(object sender, EventArgs e)
    {             
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Country>));
        Response.ContentType = "text/xml";
        XmlTextWriter xmlWriter = new XmlTextWriter(Response.OutputStream, Encoding.Default);
        

        xmlSerializer.Serialize(xmlWriter, GetAllCountries());        
        
        
    }

    private List<Country> GetAllCountries()
    {
        return Session[global_asax.CountriesListKey] as List<Country>;
    }
}