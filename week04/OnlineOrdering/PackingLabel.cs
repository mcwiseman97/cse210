class PackingLabel
{
    private string _customerName;
    private string _shippingAddress;

    public PackingLabel(string customerName, string shippingAddress)
    {
        _customerName = customerName;
        _shippingAddress = shippingAddress;
    }

    public string GetCustomerName() => _customerName;
    public string GetShippingAddress() => _shippingAddress;

    public override string ToString()
    {
        return $"Packing Label for {_customerName}\n{_shippingAddress}";
    }
}
