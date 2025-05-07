var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string Rock = "Rock".ToUpper();
string Paper = "Paper".ToUpper();
string Scissor = "Scissor".ToUpper();
int computerScore = 0, userScore = 0, winningScore = 3;

Console.WriteLine("Game Started enter your choice".ToUpper());

while (userScore < winningScore && computerScore < winningScore)
{
    Console.WriteLine("enter your Choice".ToUpper());
    Console.WriteLine("1: ROCK");
    Console.WriteLine("2: Paper");
    Console.WriteLine("3: scissor");
    string userChoice = Console.ReadLine();
    string computerChoise = "";
    
    int randomNumber = new Random().Next(1, 3);
    switch (randomNumber)
    {
        case 1:
            {
                computerChoise = Rock;
                break;
            }
        case 2:
            {
                computerChoise = Paper;
                break;
            }
        case 3:
            {
                computerChoise = Scissor;
                break;
            }
    }

    switch(userChoice)
    {
        case "1":
            {
                userChoice = Rock;
                break;
            }
        case "2":
            {
                userChoice = Paper;
                break;
            }
        case "3":
            {
                userChoice = Scissor;
                break;
            }
    }

    Console.WriteLine("User choise is " + userChoice);
    Console.WriteLine("Computer choise is " + computerChoise);


    if (userChoice != Rock && userChoice != Paper && userChoice != Scissor)
    {
        Console.WriteLine("You made a wrong choice");
    }

    if (userChoice == computerChoise)
    {
        Console.WriteLine("Draw!");
    } else if(userChoice == Rock && computerChoise == Paper) {
        computerScore += 1;

    }
    else if (userChoice == Rock && computerChoise == Scissor)
    {
        userScore += 1;

    } else if (userChoice == Paper && computerChoise == Rock)
    {
        userScore += 1;

    } else if (userChoice == Paper && computerChoise == Scissor)
    {
        computerScore += 1;

    } else if (userChoice == Scissor && computerChoise == Paper)
    {
        userScore += 1;

    }else if (userChoice == Scissor && computerChoise == Rock)
    {
        computerScore += 1;

    }
    Console.WriteLine("computerScore" + computerScore);
    Console.WriteLine("userScore" + userScore);
}
if (computerScore > userScore)
{
    Console.WriteLine("Computer Win");
} else
{
    Console.WriteLine("You Win");

}
app.Run();