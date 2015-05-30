/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
    public string FlowerType { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Title { get; set; }
    public string RecipientName { get; set; }
    public bool AreFlowersWrapped { get; set; }

	public Order()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public override string ToString()
    {
        return string.Format("Flower Type: {0}\nAddress: {1}\nEmail: {2}\nTitle: {3}\nRecipient Name: {4}\n Flowers wrapped? {5}",
            FlowerType, Address, Email, Title, RecipientName, AreFlowersWrapped);
    }
}