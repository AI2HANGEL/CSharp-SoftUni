char startLetter = Char.Parse(Console.ReadLine());
char endLetter = Char.Parse(Console.ReadLine());


if (startLetter <= endLetter)
{

    for (char letter = startLetter; letter <= endLetter; letter++)
    {
        Console.Write(letter + " ");
    }

}
