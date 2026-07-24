using System;
using System.Collections.Generic;

class Product {
    /* _name (string)
    _price (float)
    _id (string, safer to assume string)
    _count (int)

    --constructor(name st, price float, id st)
    --constructor(name st, price float, id st, count int)
    --Increment(amount int) - void, increases _count by amount
    --Increment() - void, increases _count by 1
    --GetCount() - int, gets _count, hopefully not necessary
    --GetPrice() - float, returns _price * _count
        stuff i forgor
    --something to get id and name */

    private string _name;
    private double _price;
    private string _id;
    private int _count;

    public Product(string name, double price, string id)
    {
        _name = name;
        _price = price;
        _id = id;
        _count = 1;
    }

    public Product(string name, double price, string id, int count)
    {
        _name = name;
        _price = price;
        _id = id;
        _count = count;
    }

    public void Increment(int amount)
    {
        _count += amount;
    }

    public void Increment()
    {
        Increment(1);
    }

    public int GetCount()
    {
        return _count;
    }

    public double GetPrice()
    {
        double fCou = _count;
        return fCou * _price;
    }

    public string GetProduct()
    {
        return $"{_id} {_name}";
    }
}