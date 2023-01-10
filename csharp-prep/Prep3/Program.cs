using System;

class Program
{
    static void Main(string[] args)
    {
        // ///WHILE LOOPS, MY BELOATHED ᕦ(ò_óˇ)ᕤ///
        // string input = "yes";
        // while (input == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     input = Console.ReadLine();
        // }

        // ///DO-WHILE LOOPS! NEW!!!///
        // //loops once first before check is made for the first time
        // //body is guaranteed to run at least once
        // //do(1) + body(2) + while(3) + semicolon
        // string input;
        //
        // do //1
        // { //2
        //     Console.Write("Do you want to continue? ");
        //     input = Console.ReadLine();
        // } while (input == "yes"); //3

        // ///FOR LOOPS///
        // //more like a "for x in range" py loops
        // //3 PARTS separated by ";"s : (1)value, (2)condition to check, (3)increment step run
        //     //at the end of each loop
        // for (int i = 0; i <= 30; i = i + 3) //i++ incrememnt 1
        // {
        //     Console.WriteLine(i);
        // }

        ///FOREACH LOOPS///
        //equivalent to standard py loops
        //iterator must have its type defined, like declaring a var
        // foreach (string color in colors)
        // {
        //     Console.WriteLine(color);
        // }

        ///RANDOM NUMBERS///
        //create random class, and then use it to get the next int in a specific range
        // Random variablePlaceholder = new Random();
        // int number = variablePlaceholder.Next(1,11);
        // Console.Write(number);




        //MAKE GUESS NUMBER GAEM

        int guessNumber = 0;
        int guesses = 0;
        string playAgain ="";

        //ask user for the magic number
        // Console.Write("What is the magic number? ");
        // string x = Console.ReadLine();
        // int magicNumber = int.Parse(x);

        //loop as long as they keep saying "yes"
        while (playAgain != "no")
        {
            //randomly generate magic number
            Random makeMagicNumber = new Random();
            int magicNumber = makeMagicNumber.Next(1, 100);

        do
        {


            Console.Write("What is your guess? ");
            string y = Console.ReadLine();
            guessNumber = int.Parse(y);
            guesses++;

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Ding ding ding! You guessed it!");
                Console.WriteLine($"You've made {guesses} guesses");
            }


        } while (magicNumber != guessNumber);
            
            Console.Write("Do you want to play again?(yes/no) ");
            playAgain = Console.ReadLine();
            guesses = 0;
        }
    }
}