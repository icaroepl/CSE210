using System;

class Customer
{
    private string _name;
    private Address _mainAddress;

    public Customer(string name, Address address)
    {
        _name = name;
        _mainAddress = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetJoinedAddress()
    {
        return _mainAddress.JoinAddress();
    }

    public bool InUSA()
    {
        return _mainAddress.InUSA();
    }
    

}
