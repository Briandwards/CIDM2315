class Program
{
    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static bool createAccount()
    {
        Console.Write("Enter a username: ");
        string username = Console.ReadLine();

        Console.Write("Enter a password: ");
        string password1 = Console.ReadLine();

        Console.Write("Enter the password again: ");
        string password2 = Console.ReadLine();

        if (password1 != password2)
        {
            Console.WriteLine("Wrong password.");
            return false;
        }

        Console.Write("Enter your birth year: ");
        int birth_year = Convert.ToInt32(Console.ReadLine());

        if (!checkAge(birth_year))
        {
            Console.WriteLine("Could not create an account.");
            return false;
        }

        Console.WriteLine("Account is created successfully.");
        return true;
    }

    static void Main(string[] args)
    {
        createAccount();
    }
}