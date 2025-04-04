using System;
using System.Transactions;

class Address
{
    private string street { get; set;}
    private string city { get; set;}
    private string state {get; set;}
    private string country {get; set;}
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }
     public bool IsInUSA()
    {
        return country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}
