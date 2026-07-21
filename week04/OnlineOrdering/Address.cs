using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _postalCode;

    public Address(string street, string city, string state, string country, string postalCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _postalCode = postalCode;
    }

    public string GetStreet() => _street;
    public string GetCity() => _city;
    public string GetState() => _state;
    public string GetCountry() => _country;
    public string GetPostalCode() => _postalCode;

    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state} {_postalCode}\n{_country}";
    }

    public override string ToString()
    {
        return GetFullAddress();
    }
}