using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ///LISTSSSS///
        // //make sure to declare data type <in these>
        // List<int> numbers;//var hold the list
        // numbers = new List<int>(); //new is a keyword!! to make a new thing
        // //^make a new list
        // //v combine two lines of code above to this:
        // List<int> numbers = new List<int>(); //'()' means we're creating a new object

        // //ADD ITEMS TO LIST//
        // List<string> words = new List<string>();
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // //GET LIST SIZE//
        // Console.WriteLine(words.Count); //python: print(len(words))

        // //ITERATING THROUGH A LIST//
        // //foreach is the easiest and safest way
        // foreach (string word in words) //for words in words:
        // {
        //     Console.WriteLine(word); //print(word)
        // }

        // //ACCESS ITEMS BY INDEX
        // for (int i = 0; i < words.Count; i++) //for i in range(len(words)):
        // {
        //     Console.WriteLine(words[i]); //print(words[i])
        // }

        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            string y = Console.ReadLine();
            userNumber = int.Parse(y);
            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }
        }

        int totalNumbers = numbers.Sum();
        Console.WriteLine($"The sum is {totalNumbers}.");
        
        double aveNumber = Queryable.Average(numbers.AsQueryable());
        Console.WriteLine($"The average is: {aveNumber}.");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is {max}.");

        List<int> positive = new List<int>();
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                positive.Add(number);
            }
        }
        int min = positive.Min();
        Console.WriteLine($"The smallest positive number is: {min}");

        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }








    }
}