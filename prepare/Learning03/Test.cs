using System;

/*public class Account
        {
            public List<int> transactions = new List<int>(); 
            public void Deposit(int amount)
            {
                transactions.Add(amount);
            }
        } */
public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public Person()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
        Console.WriteLine(_firstName + _lastName);
    }

    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
        Console.WriteLine($"{_firstName} {_lastName}");
    }

    public Person(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
        Console.WriteLine($"{_title} {_firstName} {_lastName}");
    }

}
