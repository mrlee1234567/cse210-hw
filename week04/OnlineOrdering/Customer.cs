using System;
using System.Collections.Generic;

class Customer
{
    /* !req Address
    _name (string)
    _address (Address)

    --constructor(name st, addressOject Address)
    --GetName() - string
    --IsUSBased() - bool, calls a corresponding method in _address */

    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsUSBased()
    {
        return _address.IsUSBased();
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}