using System.Dynamic;

class Order{
    Customer _customer;
    List<Product> _products;

    public Order(Customer customer){
        _customer = customer;
        _products = new List<Product>();
    }

    public void addProduct(Product product){
        _products.Add(product);
    }
    
    public double getTotalPrice(){
        double totalPrice = 0;
        if (_customer.isFromUSA()){
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        foreach(Product product in _products){
            totalPrice += product.getTotalPrice();
        }
        return totalPrice;
    }

    public string getShippingLabel(){
        string shippingLabel = "";
        shippingLabel += _customer.getName() + "\n";
        shippingLabel += _customer.getAddress() + "\n";
        return shippingLabel;
    }

    public string getPackingLabel(){
        string packingLabel = "";
        packingLabel += _customer.getName() + "\n";
        packingLabel += "Products: \n";
        foreach(Product product in _products){
            packingLabel += product.getName() + "\n";
        }
        return packingLabel;
    }
}