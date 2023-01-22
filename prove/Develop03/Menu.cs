using System;

public class Menu

{   
    private int _userChoice;
    public void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("============================================");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write your passage");
        Console.WriteLine("2. Load File");
    }

        public int UserChoice()
    {
        Console.Write("What do you want to do? ");
        string x = Console.ReadLine();
        int userChoice = int.Parse(x);
        _userChoice = userChoice;
        return userChoice; 
    }


    public void DisplayErrorIncorrectNumber()
    {
        Console.WriteLine("The number you have selected is not in the menu.");
        Console.WriteLine("");
    }
}