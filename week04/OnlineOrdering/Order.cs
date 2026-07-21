class Order {

    // Variable declaration
    private double _totalPrice;
    private string _countryOrigin;
    private List<PackingLabel> _packingLabel;
    private List<ShippingLabel> _shippingLabel;


    Public Order(double totalPrice, string countryOrigin, List<PackingLabel> packingLabel, List<ShippingLabel> shippingLabel) 
    {
        _totalPrice = totalPrice;
        _countryOrigin = countryOrigin;
        _packingLabel = new List<PackingLabel>();
        _shippingLabel = new List<ShippingLabel>();

    }

    
}