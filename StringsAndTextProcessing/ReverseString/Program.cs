
//string command = Console.ReadLine();

//while (command != "end")
//{
//    string currentCommand = command;
//    string newWord = "";
//    for (int i = currentCommand.Length - 1; i >= 0; i--)
//    {
//        newWord += currentCommand[i];
//    }
//    Console.WriteLine($"{currentCommand} = {newWord}");
//    command = Console.ReadLine();

//}

using System.Text;

string command = Console.ReadLine();

while (command != "end")
{
    StringBuilder reversedCommand = new StringBuilder();
    for (int i = command.Length - 1; i >= 0; i--)
    {
        reversedCommand.Append(command[i]);
    }

    Console.WriteLine($"{command} = {reversedCommand}");
    command = Console.ReadLine();
}