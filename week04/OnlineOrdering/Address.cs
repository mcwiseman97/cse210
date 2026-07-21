class Address
{
    private string _address;
    private bool _usOrNah;
    private string _fullAddress;

    public Address(string address, bool usOrNah, string fullAddress)
    {
        _address = address;
        _usOrNah = usOrNah;
        _fullAddress = fullAddress;
    }
}