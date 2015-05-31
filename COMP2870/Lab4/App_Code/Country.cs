using System;
using System.Xml.Serialization;

/// <summary>
/// Summary description for Country
/// </summary>

[Serializable]
public class Country
{
    [XmlAttribute("root")]
    public string Name { get; set; }
    public uint Population { get; set; }
    public string Capital { get; set; }

	public Country()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}