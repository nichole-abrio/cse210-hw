using System;

class Program
{
    static void Main(string[] args)
    {
        // ///IF STATEMENTS (again)///
        // Console.Write("Give number (1-10): ");
        // string firstNumber = Console.ReadLine(); //use camel case instead of underscores ;-;
        // int x = int.Parse(firstNumber); //

        // Console.Write("Give another number (1-10): ");
        // string secondNumber = Console.ReadLine();
        // int y = int.Parse(secondNumber); //

        // Console.Write("Give another number (1-10): ");
        // string thirdNumber = Console.ReadLine();
        // int z = int.Parse(thirdNumber); //


        // if (x > y)
        // {
        //     Console.WriteLine($"{x} is greater than {y}");
        // }
        // else if (x > z) //insrad of elif
        // {
        //     Console.WriteLine($"{x} is greater than {z}");
        // }
        // else
        // {
        //     Console.WriteLine($"{x} is less than both {y} and {z}");
        // }

        // ///OPERATORS///
        // string name = "John";
        // // if (name == "John") //c# also uses ==, !=, >=, <= etc
        // // {
        // //     Console.WriteLine("The name is John");
        // // }

        // ///AND, OR, NOT/// = &&, ||, !
        // if (name == "Peter" || name = "James" || name = "John") 
            //apparently and.or.not operators only work with numbers?
            //i keep getting errors ○|￣|_ 
        // {
        //     Console.WriteLine("This is a biblical name.");

        //Determining letter grade for a course

        Console.Write("What is your grade? ");
        string x = Console.ReadLine();
        int grade = int.Parse(x);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";            
        }
        else if (grade >= 60)
        {
            letter = "D";            
        }
        else if (grade < 60)
        {
            letter = "F";            
        }

        //get remainder of grade to get if + or - or none
        int i = grade % 10;
        string sign = "";

        if (grade < 90 && grade > 60)
        {        
        if (i >= 7)
        {
            sign = "+";
        }
        else if (i < 3)
        {
            sign = "-";
        }
        }
        else
        {
            sign = "";
        }

        //print letter grade
        Console.WriteLine($"Your letter grade is {letter}{sign}");
        
        //determine if student has passing grade
        if (grade >= 70)
        {
            Console.WriteLine("Good job! You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time (｀д′)σ");
        }
    }
}