using System;

public class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int cus_id, string cus_name, int cus_age) //constructor
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine("Customer: " + cus_id + ", name: " + cus_name + ", age: " + cus_age);
    }

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine(this.cus_name + " is older");
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine(objCustomer.cus_name + " is older");
        }
        else
        {
            Console.WriteLine("Both customers have the same age");
        }
    }
}

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        customer1.ChangeID(220);
        customer2.ChangeID(221);

        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        customer1.CompareAge(customer2);
    }
}