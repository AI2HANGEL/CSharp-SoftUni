List<int> playerOne = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> playerTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

while (playerOne.Count > 0 && playerTwo.Count > 0)
{
    int playerOneCard = playerOne[0];
    int playerTwoCard = playerTwo[0];

    playerOne.RemoveAt(0);
    playerTwo.RemoveAt(0);

    if (playerOneCard > playerTwoCard)
    {
        playerOne.Add(playerOneCard);
        playerOne.Add(playerTwoCard);
    }
    else if (playerTwoCard > playerOneCard)
    {
        playerTwo.Add(playerTwoCard);
        playerTwo.Add(playerOneCard);
    }
}

if (playerOne.Count > playerTwo.Count)
{
    Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
}
else if (playerTwo.Count > playerOne.Count)
{
    Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
}
