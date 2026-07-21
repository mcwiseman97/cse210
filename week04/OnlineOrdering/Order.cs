class Order {

    // Variable declaration
    private double _totalPrice;
    private string _countryOrigin;
    private List<string> _packingLabel;
    private List<string> _shippingLabel;


    Public Order()
    {
        _totalPrice = 0.0;
        _countryOrigin = "";
        _packingLabel = new List<string>();
        _shippingLabel = new List<string>();
        
    }
    
}