int RandomNumber;
int CompRandomNumber;
int playerpoints = 0;
int comppoints = 0;
Random random = new Random();


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press any Key to roll the Dice");
    Console.ReadKey();
    RandomNumber = random.Next(1,7);
    Console.WriteLine("You rolled a " + RandomNumber);
    Console.WriteLine("....");

    System.Threading.Thread.Sleep(1000);
    CompRandomNumber = random.Next(1,7);
    Console.WriteLine("The computer rolled a "+ CompRandomNumber );
    
    if(RandomNumber> CompRandomNumber)
    {
        playerpoints++;
        Console.WriteLine("Player wins this Round");
    }else if(RandomNumber < CompRandomNumber)
    {
        playerpoints++;
        Console.WriteLine("Computer wins tjhis Round");

    }
    else
    {
        Console.WriteLine("!! It's a Draw");
    }
}