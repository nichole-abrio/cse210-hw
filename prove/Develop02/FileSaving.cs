using System;
using System.IO;
using System.Collections.Generic;

public class FileSaving
{
    //does the file exist?
    public bool DoesFileAlreadyExist(string fileName)
    {
        var file = fileName;
        return File.Exists(file);
    }

    //method to call when naming files
    public string NamingFiles()
    {
        //ask for file name to save as
        Console.Write("Name your file: ");
        string file = Console.ReadLine();
        return file;
    }

    public void WriteFile(string fileName, List<string> dates, List<string> prompts, List<string> entries)
    {
        StreamWriter sw = new StreamWriter(fileName);

        int n = dates.Count();
        for (int i = 0; i < n; i++)
        {
            sw.WriteLine($"Date: {dates[i]} - Prompt: {prompts[i]}");
            sw.WriteLine(entries[i]);
            sw.WriteLine("");
            //make sure to flush the data}
        }
        sw.Flush();
        sw.Close();
    }
    //call to display journal
    public void DisplayJournal(List<string> dates, List<string> prompts, List<string> entries)
    {
        int n = dates.Count();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Date: {dates[i]} - Prompt: {prompts[i]}");
            Console.WriteLine(entries[i]);
            Console.WriteLine("");
        }
    }

    public void LoadFile(string fileName)
    {
        StreamReader sr = new StreamReader(fileName);
        string data = sr.ReadLine();
        //make read line (so long as the data is not null)
        while (data != null)
        {
            Console.WriteLine(data);
            //split data with commas
            //string[] values = data.Split(",");
            //int x = int32.parse(); etc etc
            data = sr.ReadLine(); //so it won't loop forever //fetch next line
        }
        sr.Close();
    }
}