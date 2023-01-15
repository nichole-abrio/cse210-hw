using System;
using System.Collections.Generic;

//pages of the journal
public class Journal
{
    public string _journalEntry;
    public string _journalDate;
    public string _journalPrompt;
    public List<string> JournalEntries = new List<string>();
    public List<string> JournalDate = new List<string>();
    public List<string> JournalPrompt = new List<string>();
   

    public string MakeDate(){
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }


    }
