using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

public class Scriptures
{ 
    private static string verse;
    private static string passage;

    private Random n = new Random();

    public string Verse{
        get{ return verse;}
        set{ verse = value;}
    }
    public string Passage{
        get{ return passage;}
        set{ passage = value;}
    }


}

    