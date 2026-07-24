using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address adr = new Address("Mesa","Arizona","US");
        Customer cus = new Customer("Dohn Joe",adr);
        Order odr = new Order(cus);
        Product prd = new Product("Munkfruit",2.2,"mkft",20);
        odr.AddProduct(prd);
        prd = new Product("Cat",50.0,"cat");
        odr.AddProduct(prd);
        prd = new Product("Flathead Screw",0.1,"scr-1",230);
        odr.AddProduct(prd);
        odr.Print();
        adr = new Address("Miami","Flodira","United States");
        Address adr2 = new Address("Batman","Batman","Turkey");
        cus = new Customer("Gabriel Harrold",adr);
        Customer cus2 = new Customer("Hashma bin Turkyie",adr2);
        odr = new Order(cus);
        Order odr2 = new Order(cus2);
        odr.AddProduct(prd);
        odr2.AddProduct(prd);
        prd = new Product("Yogurt",0.5,"yg-0",30);
        odr.AddProduct(prd);
        odr2.AddProduct(prd);
        prd = new Product("Hairgel (64floz)",1.57,"hg640",3100);
        odr.AddProduct(prd);
        odr2.AddProduct(prd);
        prd = new Product("Yogurt", 0.5, "yg-0");
        odr2.AddProduct(prd);
        odr.AddProduct(prd);
        // i was confused as to why it was adding 2 to the count, i realized that it was because they use the same memory address
        odr.Print();
        odr2.Print();
    }
    /* 
    
    classes:
    Product
    _name (string)
    _price (float)
    _id (string, safer to assume string)
    _count (int)

    --constructor(name st, price float, id st)
    --constructor(name st, price float, id st, count int)
    --Increment(amount int) - void, increases _count by amount
    --Increment() - void, increases _count by 1
    --GetCount() - int, gets _count, hopefully not necessary
    --GetPrice() - float, returns _price * _count

    Customer
    !req Address
    _name (string)
    _address (Address)

    --constructor(name st, addressOject Address)
    --GetName() - string
    --IsUSBased() - bool, calls a corresponding method in _address

    Address
    _city (string)
    _state (string, state or province)
    _country (string)
    _isUSBased (bool, constructor checks if _country is equal to US, USA, United States, or United States of America)

    --constructor(city st, state st, country st)
    --GetAddress() - string, The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
    --IsUSBased() - bool, returns _isUSBased

    Order
    !req Product, Customer
    _customer (Customer)
    _products (List<Product>)

    --constructor(customerObject Customer)
    --OrderCost() - float, The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost. This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
    --PackingLabel() - string, A packing label should list the name and product id of each product in the order.
    --ShippingLabel() - string, A shipping label should list the name and address of the customer
    --AddProduct(product Product) - void, inserts into _products
    --Print() - void, prints the whole order

    Program runs without errors. At least 2 Order objects are created.
    Each Order object contains at least 2 products objects. Each Order object contains a
    Customer object. Each Customer object contains an Address object. Values are set for each
    member variable of these objects.

    Program runs without errors. For each order, the program calculates and displays the total
    cost. The program also calls methods to get packing and shipping labels and displays the
    results of these labels containing all required information.
     */
}