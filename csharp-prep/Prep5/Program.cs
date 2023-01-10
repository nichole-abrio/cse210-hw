using System;

class Program
{
    static void Main(string[] args)
    {
        ///FUNCTIONS///
        //TitleCaseWhenNaming
        //structure: 
            // returnType FunctionName (dataType parameter1, dataType parameter 2)
            // {
            //     function_body
            // }
        
        // void DisplayMessage() //def display_message(): //void means there is nothing to return
        //     {
        //         Console.WriteLine("Hello world!"); //print("Hello world.")
        //     }

        // void DisplayPersonalMessage(string userName) //def display_personal_message(user_name):
        // {
        //     Console.WriteLine($"Hello {userName}"); //print(f"Hello {user_name}")
        // }

        // //func that accepts 2 ints as paras.
        // //func specifies a return value of INT AT THE BEGINNING OF THE DEF
        // int Addnumbers(int first, int second) //def add_numbers(first, second)
        // {
        //     int sum = first + second; //sum = first + second
        //     return sum; //return sum
        // }

        //FUNCTIONS VS METHODS (set of instructions that perform a task vs set of instructions that are assctd with an object)
        // STATIC FUNC: regular standalone functions

        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

        void DisplayWelcomeMessage() //display welcome message 
        {
            Console.WriteLine("Welcome to the Program!");
        }

        string PromptUserName() //asks for and returns user;s name
        {
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            return userName;
        }

        int PromptUserNumber() //asks for and returns user's number
        {
            Console.Write("Please enter your favorite number: ");
            string x = Console.ReadLine();
            userNumber = int.Parse(x);
            return userNumber;
        }

        int SquareNumber(int userNumber) //multiply no. by itself and returns the squared value
        {
            int numberSquared = userNumber * userNumber;
            return numberSquared;

        }

        void DisplayResult(string name, int number) //don;t add ; after this line （；´д｀）ゞ //display result
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

        



    }
}