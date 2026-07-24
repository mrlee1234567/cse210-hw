using System;
using System.Collections.Generic;

class Address
{
    /* _city (string)
    _state (string, state or province)
    _country (string)
    _isUSBased (bool, constructor checks if _country is equal to US, USA, United States, or United States of America)

    --constructor(city st, state st, country st)
    --GetAddress() - string, The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
    --IsUSBased() - bool, returns _isUSBased */

    private string _city;
    private string _state;
    private string _country;
    private bool _isUSBased;

    public Address(string city, string state, string country)
    {
        _city = city;
        _state = state;
        _country = country;
        string lowCountry = country.ToLower();
        if (lowCountry == "usa" || lowCountry == "us" || lowCountry == "united states" || lowCountry == "united states of america")
        {
            _isUSBased = true;
        }
        else
        {
            _isUSBased = false;
        }
    }

    public string GetAddress()
    {
        string ret = $"{_city}\n{_state}\n{_country}";
        return ret;
    }

    public bool IsUSBased()
    {
        return _isUSBased;
    }
}