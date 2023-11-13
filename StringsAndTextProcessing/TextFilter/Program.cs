using System;

class ReplaceBannedWords
{
    static void Main(string[] args)
    {
        string bannedWords = Console.ReadLine();

        string text = Console.ReadLine();

        string censoredText = CensorText(text, bannedWords);

        Console.WriteLine(censoredText);
    }

    static string CensorText(string text, string bannedWords)
    {
        
        string[] bannedWordsArray = bannedWords.Split(", ");

        
        foreach (string bannedWord in bannedWordsArray)
        {
            string censoredWord = new string('*', bannedWord.Length);
            text = text.Replace(bannedWord, censoredWord);
        }

        return text;
    }
}
