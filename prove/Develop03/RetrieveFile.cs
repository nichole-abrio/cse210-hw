using System;
using System.IO;

public class RetrieveFile

{
    private string fileName;
    private int choice;
    private Dictionary<string, string> file = new Dictionary<string, string>();

    public string FileName
    {
        get{return fileName;}
        set{fileName = value;}
    }
    public Dictionary<string, string> File
    {
        get{return file;}
        set{file = value;}
    }
    public int Choice
    {
        get{return choice;}
        set{choice = value;}
    }
    public string GetFileName()
    {
        //ask for file name to save as
        Console.Write("Name your file: ");
        string fileName = Console.ReadLine();
        return fileName;
    }

    public Dictionary<string, string> LoadFile(string fileName, string separator) //custom delimiter
    {
        StreamReader sr = new StreamReader(fileName);
        string data = sr.ReadLine();
        Dictionary<string, string> d = new Dictionary<string, string>();
        //make read line (so long as the data is not null)
        while (data != null)
        {
            //Console.WriteLine(data);
            //split data with commas
            string[] values = data.Split(separator);
            //int x = int32.parse(); etc etc
            d.Add(values[0], values[1]);
            data = sr.ReadLine(); //so it won't loop forever //fetch next line
        }
        sr.Close();
        return d;
    }
    public Dictionary<string, string> LoadFile(string fileName) //"," delimiter
    {
        StreamReader sr = new StreamReader(fileName);
        string data = sr.ReadLine();
        Dictionary<string, string> d = new Dictionary<string, string>();
        //make read line (so long as the data is not null)
        while (data != null)
        {
            //Console.WriteLine(data);
            //split data with commas
            string[] values = data.Split(",");
            //int x = int32.parse(); etc etc
            d.Add(values[0], values[1]);
            data = sr.ReadLine(); //so it won't loop forever //fetch next line
        }
        sr.Close();
        return d;
    }

    public int ChooseVersesFromFile()
    {
        int number = 1;
        foreach (KeyValuePair<string, string> kvp in file)
        {
            string output = $"{number}. {kvp.Key}";
            number++;
            Console.WriteLine(output);
        }

        Console.Write("\nChoose the number of the passage you want to memorize. ");
        string y = Console.ReadLine();
        int choice = int.Parse(y);
        choice = choice - 1;
        return choice;
    }

    public string PickVerse()
    {
        
        string verse = file.ElementAt(choice).Key;
        return verse;
    }

    public string PickPassage()
    {
        string passage = file.ElementAt(choice).Value;
        return passage;
    }

}