using TheDuel;

Player playerOne = new(200, 0);

Player playerTwo = new(200, 0);

Random whichPlayerStarts = new();

bool playerOneStarts = whichPlayerStarts.Next(2) == 0;

while (playerOne.Health > 0 && playerTwo.Health > 0)
{
    if (playerOneStarts)
    {
        Console.Clear();
        Console.WriteLine("Player One starts:");
        Console.WriteLine("Press any key to attack...");
        Console.ReadKey();

        int damageDone = Attack(playerOne, playerTwo);

        Console.WriteLine($"Player One hit Player Two for {damageDone}");
        Console.WriteLine($"Player Two has {playerTwo.Health} health remaining");
        PressKey();


    }
    else
    {
        Console.Clear();
        Console.WriteLine("Player Two starts:");
        Console.WriteLine("Press any key to attack...");
        Console.ReadKey();

        int damageDone = Attack(playerTwo, playerOne);

        Console.WriteLine($"Player Two hit Player One for {damageDone}");

        Console.WriteLine($"Player One has {playerOne.Health} health remaining");
        PressKey();

    }


    playerOneStarts = !playerOneStarts;
}

if (playerOne.Health < 0)
{
    Console.WriteLine("Player Two has won!");
    PressKey();
}
else
{
    Console.WriteLine("Player One has won!");
    PressKey();

}


int Attack(Player attackingPlayer, Player attackedPlayer)
{
    int damage = attackingPlayer.RollDamage();

    attackedPlayer.Health -= damage;

    return damage;
}

void PressKey()
{
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}


//int CalculateRemainingHealth(Player attackedPlayer);
//{
//    int remainingHealth = attackedPlayer.Health;

//    return remainingHealth;
//}