class Product
{
    private string _name;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, double pricePerUnit, int quantity)
    {
        _name = name;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double getTotalPrice()
    {
        return _pricePerUnit * _quantity;
    }

    public string getName()
    {
        return _name;
    }
}