using System;
using System.ComponentModel.Design;

Random rand = new Random();
int pNumber = 0;
string input = "";
bool isPlaying = true;


while (isPlaying)
{

    //slumpa
    int number = rand.Next(0, 36);
 





    //get number and check if ok
    Console.WriteLine("Choose number");
    bool validInput = false;

    while (!validInput)
    {
        input = Console.ReadLine();


        pNumber = Convert.ToInt32(input);



        if (pNumber <= 36)
        {
            Console.WriteLine("Your number is " + pNumber);
            validInput = true;
        }



        if (pNumber > 36)
        {
            pNumber = Convert.ToInt32(input);
            validInput = false;
            Console.WriteLine("Your number is too big");

        
        }
    }

    //Win or lose anunsment
    Console.WriteLine("The number is " + number);


        if (pNumber == number)
        {
            Console.WriteLine("You win!");
        }
        else if (number < pNumber || pNumber < number)
        {
            Console.WriteLine("You lose!");
        }

        //play again?

        Console.WriteLine("Would you like to play again?");
        input = Console.ReadLine();
        if (input == "No")
        {
            isPlaying = false;
        }

    }







