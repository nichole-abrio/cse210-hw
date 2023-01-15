using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        Menu menu1 = new Menu();
        Journal journal1 = new Journal();
        Prompt prompt1 = new Prompt();
        FileSaving file1 = new FileSaving();
        int load = 0;
        string fileName = "";

        menu1.DisplayWelcome();

        do{
            
            menu1.DisplayMenu();
            userChoice = menu1.UserChoice();

            Console.WriteLine("");

            if (userChoice == 1) //write
            {
                journal1._journalPrompt = prompt1.DisplayPrompt(); //store prompt
                Console.Write("> ");
                journal1._journalDate = journal1.MakeDate(); //save date to make date var
                journal1._journalEntry = Console.ReadLine(); //store journal entry

                journal1.JournalDate.Add(journal1._journalDate);
                journal1.JournalEntries.Add(journal1._journalEntry);
                journal1.JournalPrompt.Add(journal1._journalPrompt);
            }
            else if (userChoice == 2) //display
            {
                if (load >= 1)
                {
                    file1.LoadFile(fileName);
                    file1.DisplayJournal(journal1.JournalDate, journal1.JournalPrompt, journal1.JournalEntries);
                }
                else
                {
                    file1.DisplayJournal(journal1.JournalDate, journal1.JournalPrompt, journal1.JournalEntries);
                }
                
            }
            else if (userChoice == 3) //load file
            {
                //ask for filename to save as
                fileName = file1.NamingFiles();
                file1.LoadFile(fileName); //call load file method
                load++;
            }   
            else if (userChoice == 4) //save //write file
            {
                //ask for filename to save as
                fileName =  file1.NamingFiles();
                if (file1.DoesFileAlreadyExist(fileName))//check if file already exist
                {  
                    //if exist, append
                    Console.WriteLine("Your file already exists. Adding your entry to the file.");
                    file1.WriteFile(fileName, journal1.JournalDate, journal1.JournalPrompt, journal1.JournalEntries);
                }
                else{
                    //if not, make new one
                    file1.WriteFile(fileName, journal1.JournalDate, journal1.JournalPrompt, journal1.JournalEntries);
                }
            }

            
            else if (userChoice == 5) //quit
            {
                menu1.DisplayFarewell();
            }
            else if (userChoice >= 1 && userChoice <= 5 )
            {
                //write error msg
                menu1.DisplayErrorIncorrectNumber();
            }      


        } while (userChoice != 5);
        
    }
}