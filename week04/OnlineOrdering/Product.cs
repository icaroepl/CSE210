using System;

class Product
{
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    public Product(string name, int productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;  
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _productId;
    }

    public float TotalPrice()
    {
        float totalPrice = _quantity * _price;
        return totalPrice;
    }
}


