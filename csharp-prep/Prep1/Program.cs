using System;

class Program
{
    static void Main(string[] args)
    {
        // ///VARIABLE + DECLARING VAR DATA TYPE///
        // //int x; //data type + variable name
        // //x = 5; //variable is defined to be 5
        // //Can combine above to:
        // int x = 5;

        // ///PRINT WITH \n///
        // Console.WriteLine(x); //Console.Writeline("") = print("")

        // ///PRINT WITH NO \n///
        // Console.Write("There will be no newline after this. ");
        // Console.Write("Is there a line after? ");
        // //.WriteLine --> has newline after .Write -->continues lines after

        // ///INPUT///
        // Console.WriteLine("What is your favorite color? "); //display question first
        // string color = Console.ReadLine(); //.ReadLine = input

        // ///INDENT, IF STATEMENTS (CONDITIONS)///
        // int x = 5;
        // int y = 4;

        // if (x > y) //no need to add ":" //condition should be in ()
        // { //curly braces for end and beginning of code blocks instead of indent
        //     //(indent is just to make things prettier)
        //     Console.WriteLine("greater");
        // }

        // ///STRING INTERPOLATION (f-strings!!!!)///
        // string school = "BYU-Idaho";
        // Console.WriteLine($"I am studying at {school}."); //also uses curly braces like f-strings! ٩(｡•́‿•̀｡)۶

        //Ask user for their name and repeats it like Bond, James Bond himself.
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}. ");

    }   

}