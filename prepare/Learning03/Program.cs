using System;

class Program
{
    static void Main(string[] args)
    {
        /*ENCAPSULATION: enclosing something; hiding details so other code can't see or manipulate them
            other code should communicate with the class in question, class will access the data necessary
            ADVANTAGES:
                -something is broken: codes that has access might be to blame; something needs to change: the code that has access might need to change
        
            (class members)PRIVATE = hidden PUBLIC = available for use by other programs
            WHICH ONE TO PUBLIC/PRIVATE? just restrict access as much as possible
        
            Account account = new Account();
            account.balance = 50;
            account.Deposit(100);

        GETTER AND SETTER (also accessors and mutators)
            ex: 
            public void GetFirstName()
            {
             return _firstname
            };
            public void SetFirstName(string firstName)
            {
                _firstName = firstName;
            }

            called:
            Person p = new Person();
            p.SetFirstName("Peter");

            Console.WriteLine(p.GetFirstName());
        
        CONSTRUCTOR: special methods that are called automatically when an object is created. help set up the initial state of the object
            example:*/
                
        /*Person p1 = new Person();
        Person p2 = new Person("Jane", "Doe"); //pass first and last name
        Person p3 = new Person("Mrs.", "Jane", "Doe"); //pass all 3 vars */

        // Fraction f1 = new Fraction();
        // Fraction f2 = new Fraction(5);
        // Fraction f3 = new Fraction(6, 3);

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


        
            

        }
    
}