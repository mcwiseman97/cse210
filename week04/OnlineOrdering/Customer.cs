class Customer
{
    private string _name;
    private Address _address;
    private string _returnOption;

    public Customer(string name, Address address, string returnOption)
    {
        _name = name;
        _address = address;
        _returnOption = returnOption;
    }

    public string GetName() => _name;
    public Address GetAddress() => _address;
    public string GetReturnOption() => _returnOption;

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}