string desired_book = Console.ReadLine();
bool isfound = false;
int book_counter = 0;

while (true)
{
    string book = Console.ReadLine();
   
    if (book == "No More Books")
    {
        break;
    }

    if (book == desired_book)
    {
        isfound = true;
        break;
    }
    book_counter += 1;

}

if (isfound)
{
    Console.WriteLine($"You checked {book_counter} books and found it.");
}
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {book_counter} books.");
}