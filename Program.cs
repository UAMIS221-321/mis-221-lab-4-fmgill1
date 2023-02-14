
//start main
int userChoice = GetUserChoice(); //priming read
//while(userChoice != 3) //condition check
do{
    RouteEm(userChoice);
    userChoice = GetUserChoice(); //update read
} while (userChoice != 3);
//end main

static int GetUserChoice()
{
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice))
    {
        return int.Parse(userChoice);
    }
    else return 0;

}

static void DisplayMenu()
{
    Console.Clear();
    System.Console.WriteLine("Enter 1 for a full triangle\nEnter 2 for a partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userInput)
{
    if(userInput == "1" || userInput == "2" || userInput == "3")
    {
        return true;
    }
    return false;
}

static void GetFull()
{
    Console.Clear();
    Random rnd = new Random();
    int random = rnd.Next(3,10);
    for (int row = 1; row <= random; row++)
    {
        for(int numDots = 1; numDots <= row; numDots++)
        {
            System.Console.Write("O ");
        }
        System.Console.WriteLine("");
    }

    PauseAction();
}

static void GetPartial()
{
    Console.Clear();
    Random rndRows = new Random();
    int random2 = rndRows.Next(3,10);
    for (int row = 1; row <= random2; row++)
    {
        for (int numDots = 1; numDots <= row; numDots ++)
        {
            Random spotsMissing = new Random();
            int missing = spotsMissing.Next(0,10);
            if((missing) < 8) System.Console.Write("O ");
            else System.Console.Write(" ");
        }
        System.Console.WriteLine("");
    }
    PauseAction();
}

static void SayInvalid()
{
    System.Console.WriteLine("Invalid!");
    PauseAction();
}

static void RouteEm(int menuChoice)
{
    if(menuChoice == 1)
    {
        GetFull();
    }
    else if(menuChoice == 2)
    {
        GetPartial();
    }
    else if(menuChoice != 3)
    {
        SayInvalid();
    }

}

static void PauseAction()
{
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
