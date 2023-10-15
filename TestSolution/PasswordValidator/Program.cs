
static bool IsPasswordValid(string password)
{
    bool valid = true;

    if (password.Length < 6 || password.Length > 10)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
        valid = false;
    }

    if (!IsAlphanumeric(password))
    {
        Console.WriteLine("Password must consist only of letters and digits");
        valid = false;
    }

    if (CountDigits(password) < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
        valid = false;
    }

    return valid;
}

static bool IsAlphanumeric(string text)
{
    foreach (char c in text)
    {
        if (!char.IsLetterOrDigit(c))
        {
            return false;
        }
    }
    return true;
}

static int CountDigits(string text)
{
    int count = 0;
    foreach (char c in text)
    {
        if (char.IsDigit(c))
        {
            count++;
        }
    }
    return count;
}

string password = Console.ReadLine();

if (IsPasswordValid(password))
{
    Console.WriteLine("Password is valid");
}
