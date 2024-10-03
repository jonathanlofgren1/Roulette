using System;
using System.ComponentModel.Design;

Random rand = new Random();
int pNumber = 0;
string input = "";
bool isPlaying = true;
bool hasWon = false;


while (isPlaying)
{
    hasWon = false;
    //slumpa
    int number = rand.Next(0, 36);






    //get number and check if ok
    Console.WriteLine("Choose number or color.");
    bool validInput = false;

    while (!validInput)
    {
        input = Console.ReadLine();

        if (input == "Red")
        {
            validInput = true;
            if (number % 2 == 0)
            {
                hasWon = true;
            }
        }
        else if (input == "Black")
        {
            validInput = true;
            if (number % 2 == 1)
            {
                hasWon = true;
            }
        }
        else if (input == "Green")
        {
            validInput = true;
            if (number == 0)
            {
                hasWon = true;
            }
        }
        else
        {
            pNumber = Convert.ToInt32(input);
            if (pNumber <= 36)
            {
                Console.WriteLine("Your number is " + pNumber);
                validInput = true;
            }



            if (pNumber > 36)
            {


                validInput = false;
                Console.WriteLine("Your number is too big");
            }

            Console.WriteLine("The number is " + number);


        }
    }

    if (hasWon == true)
    {
        Console.WriteLine("You win!");
        
    }
    else 
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


//Win or lose anunsment












