using System;

class Order
{
    private List<Product> _productsList = new List<Product>(); 

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _productsList.Add(product);
    }

    public string CreatePackingLabel()
    {
        string label = "";
        foreach (Product product in _productsList)
        {      
            string item = product.GetName() + " - ID: " + product.GetId() + ")";
            label += item + "\n";
        }     
        return label;
    }

    public string CreateShippingLabel()
    {
        string label = _customer.GetName() + "\n" + _customer.GetJoinedAddress();
        return label;  
    }

    public float CalculateTotalCost()
    {
        float totalCost = 0;
        foreach (Product product in _productsList)
        {
            float cost = product.TotalPrice();
            totalCost += cost;
        }

        bool inUSA = _customer.InUSA();
        if (inUSA)
        {
            totalCost += 5;
        }
        else totalCost += 35;

        return totalCost;
    }
}