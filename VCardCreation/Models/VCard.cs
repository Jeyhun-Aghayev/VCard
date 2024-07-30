namespace CSharp.VCardCreation.Models;

public class VCard
{
    public Name Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Location Location { get; set; }
    public Login Login { get; set; }
}

public class Name
{
    public string First { get; set; }
    public string Last { get; set; }
}

public class Location
{
    public string Country { get; set; }
    public string City { get; set; }
}

public class Login
{
    public string Uuid { get; set; }
}

public class ResponseApi
{
    public List<VCard> Results { get; set; }
}