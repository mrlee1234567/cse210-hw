using System;
using System.Collections.Generic;

class Order
{
    /* !req Product, Customer
    _customer (Customer)
    _products (List<Product>)

    --constructor(customerObject Customer)
    --OrderCost() - float, The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost. This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
    --PackingLabel() - string, A packing label should list the name and product id of each product in the order.
    --ShippingLabel() - string, A shipping label should list the name and address of the customer
    --AddProduct(product Product) - void, inserts into _products
    --Print() - void, prints the whole order */

    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public string PackingLabel()
    {
        string res = "";
        foreach (Product i in _products)
        {
            res += $"{i.GetProduct()} x{i.GetCount()}\n";
        }
        return res;
    }

    public string ShippingLabel()
    {
        string res = _customer.GetName();
        res += $"\n{_customer.GetAddress()}";
        return res;
    }

    public double OrderCost()
    {
        double prc = 0;
        double oc;
        if (_customer.IsUSBased())
        {
            oc = 5;
        }
        else
        {
            oc = 35;
        }
        foreach (Product i in _products)
        {
            prc += i.GetPrice();
        }
        return oc + prc;
    }

    public void AddProduct(Product product)
    {
        bool found = false;
        int lenpro = _products.Count;
        int ct = 0;
        do
        {
            if (lenpro != 0)
            {
                
                if (_products[ct].GetProduct() == product.GetProduct())
                {
                    found = true;
                    int pct = product.GetCount();
                    _products[ct].Increment(pct);
                }
            }
            ct++;
        } while (!found && ct < lenpro);
        if (!found)
        {
            _products.Add(product);
        }
        
    }

    public void Print()
    {
        int ct = 0;
        foreach (Product i in _products)
        {
            ct += i.GetCount();
        }
        Console.WriteLine(ShippingLabel());
        Console.Write(PackingLabel());
        Console.WriteLine($"{ct} products for ${OrderCost()}");
    }
}