Random rnd = new Random();
int cpuRandom = rnd.Next(1, 4);

bool loopActive = true;

int numerOfTries = 0;

while (numerOfTries < 3)
{
    Console.WriteLine("Try to quess the cpu number:");
    int userGuess = Convert.ToInt32(Console.ReadLine());
    numerOfTries++;

    if(userGuess == cpuRandom)
    {
        Console.WriteLine("You won!");
        break;
    }

}
Console.WriteLine($"The number of tries: {numerOfTries}");
Console.WriteLine("Have a nice day!");