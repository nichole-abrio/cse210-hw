using System;
using System.Collections.Generic;

public class Words{

    RetrieveFile r = new RetrieveFile();
    Scriptures s = new Scriptures();

    private static List<string> passageList = new List<string>();
    Random n = new Random();
    private string user;




    
    private HashSet<int> hash = new HashSet<int>();


    private void Display(string verse, string passage)
    {
        string[] x = passage.Split(" ");
        Console.Write($"{verse} - ");
        int n = 0;
        foreach (var i in x)
        {
            n++;
            passageList.Add(i);
            hash.Add(n);
        }
    }
    private void Display(string verse)
    {
        Console.Write($"{verse} - ");
        foreach (var i in passageList)
        {
            Console.Write($"{i} ");
        }
    }

    private void ClearDisplay()
    {
        Console.Clear();
    }

    private int GetRandomNumberList()
    {
        Random n = new Random();
        int k = n.Next(1, passageList.Count); //get random number (0-words in the list) and store in k
        return k;
    }
    private int GetRandomNumber2()
    {
        int k = n.Next(1, 3); //get random number (1-3) and store in k
        return k;
    }

    private string GetWordFromList(int randomNumber)
    {
        string a = passageList[randomNumber]; //get the word from the list, store in a
        return a;
    }

    private int GetWordLength(string word)
    {
        int b = word.Count(); //get length of the word, store in b
        return b;
    }

    private string ReplaceWithUnderscore(int wordLength)
    {
        string c = new string('_', wordLength); //replace letters to _
        return c;
    }


    public void DisplayVerseAndPassage(string verse, string passage)
    {   
        Display(verse, passage);
        do
        {
            ClearDisplay();
            Display(verse);
            int d = GetRandomNumber2();
            Console.WriteLine("");
            Console.WriteLine("type 'quit' to end");
            user = Console.ReadLine();



            for (int i = 0; i <= d; i++)
            {
                int k = GetRandomNumberList();
                string a = GetWordFromList(k);
                int b = GetWordLength(a);
                string c = ReplaceWithUnderscore(b);
                
                passageList.RemoveAt(k); //remove the replaced word
                passageList.Insert(k, c); //insert with the _
                hash.Remove(k); //remove number from hash
            }
            
        }while (user != "quit" && hash.Count != 0);
    }


    

}