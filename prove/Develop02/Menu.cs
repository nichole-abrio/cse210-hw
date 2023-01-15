using System;

public class Menu
{
    public void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choice:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

    public int _userSelect()
    {
        Console.Write("What do you want to do? ");
        string x = Console.ReadLine();
        int userChoice = int.Parse(x);
        return userChoice;

    }

    public void DisplayFarewell()
    {
        Console.WriteLine("Goodbye!");
    }

    public void DisplayErrorIncorrectNumber()
    {
        Console.WriteLine("The number you have selected is not in the menu.");
        Console.WriteLine("");
    }
    

}