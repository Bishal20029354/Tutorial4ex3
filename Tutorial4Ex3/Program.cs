using System;
using System.Diagnostics;
using System.Xml.Linq;
using System.Collections.Generic;


class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public Customer(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
}

class Program
{
    static void Main()
    {

        Customer Cust1 = new Customer(1, "John Doe", "john.doefexample.com");
        Customer Cust2 = new Customer(2, "Jane Smith", "jane.smithlexample.com");

        Console.WriteLine("Customer 1 Information:");
        Console.WriteLine("ID:" + Cust1.Id);
        Console.WriteLine("Name:" + Cust1.Name);
        Console.WriteLine("Email:" + Cust1.Email);
        Console.WriteLine();


        Console.WriteLine("Customer 2 Information:");
        Console.WriteLine("ID:" + Cust2.Id);
        Console.WriteLine("Name:" + Cust2.Name);
        Console.WriteLine("Email: " + Cust2.Email);

    }
}


 







