using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write(s1._reference);

        
        Menu menu1 = new Menu();
        RetrieveFile r1 = new RetrieveFile();
        Scriptures s1 = new Scriptures();
        Words w1 = new Words();

        int userChoice = 0;


        menu1.DisplayWelcome();

        do{    
            menu1.DisplayMenu();
            userChoice = menu1.UserChoice();

            Console.WriteLine("");

            if (userChoice == 1) //write your own passage
            {
                Console.Write("Verse(s): ");
                s1.Verse = Console.ReadLine();

                Console.Write("Passage: ");
                s1.Passage = Console.ReadLine();

                w1.DisplayVerseAndPassage(s1.Verse, s1.Passage);
            }

            else if (userChoice == 2) //load file
            {
                string fileName = r1.GetFileName(); //ask for filename
                r1.FileName = fileName;
                Dictionary<string, string> d = r1.LoadFile(fileName, "|"); //call load file method
                r1.File = d;
                int choice = r1.ChooseVersesFromFile(); //choose which verse
                r1.Choice = choice;
                string verse = r1.PickVerse();
                string passage = r1.PickPassage();
                s1.Verse = verse;
                s1.Passage = passage;

                
                w1.DisplayVerseAndPassage(s1.Verse, s1.Passage);  
            }   
            
            else if (userChoice != 1 || userChoice != 2 )
            {
                //write error msg
                menu1.DisplayErrorIncorrectNumber();
            }
        }while (userChoice != 1 && userChoice != 2);
        
    }

}