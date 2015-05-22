using System;

/// <summary>
/// Summary description for ClientBrowser
/// </summary>
public class ClientBrowser
{
    public string Name { get; set; }
    public string Platform { get; set; }
    public string ClientIpAddress { get; set; }
    public bool IsMobile { get; set; }
    public string UrlReferrer { get; set; }
    public DateTime SessionCreatedAt { get; set; }

	public ClientBrowser()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public override string ToString()
    {
        return string.Format("Name: {0}, Platform: {1}, Client IP: {2}, Mobile: {3}, URL Referrer: {4}, Session Creation Date: {5}",
                Name, Platform, ClientIpAddress, IsMobile, UrlReferrer, SessionCreatedAt);
    }
}