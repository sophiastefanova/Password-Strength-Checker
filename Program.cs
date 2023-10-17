using System;
using System.Diagnostics.Metrics;
using System.Drawing;

class Password
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your password:");
        string userPassword = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;

            if (Length(userPassword) == false)
            {
                Console.WriteLine("Your password needs to be at least 8 characters!");
            }
            if (SpecialChars(userPassword) == false)
            {
                Console.WriteLine("You need at least one special character!");
            }
            if (TwoSpecialChars(userPassword) == false)
            {
                Console.WriteLine("Special chars CANNOT repeat one after the other!");
            }
            if (UpperCaseCheck(userPassword) == false)
            {
                Console.WriteLine("Your passwords needs at least one upper case letter!");
            }
            if (LowerCaseCheck(userPassword) == false)
            {
                Console.WriteLine("Your passwords needs at least one lower case letter!");
            }
            if (Numbers(userPassword) == false)
            {
                Console.WriteLine("You need to have at least one number in your password!");
            }
        
        Console.ResetColor();
        Environment.Exit(0);
    }

    public static bool Length(string password)
    {
        if (password.Length >=8)
            return true;
        else
            return false;
    }

    public static bool SpecialChars(string password)
    {
        int count = 0;
        foreach(char c in password)
        {
            if (!char.IsLetterOrDigit(c))
                count++;
        }

        if (count == 0)
            return false;
        else
            return true;
    }

    public static bool TwoSpecialChars(string password)
    {
        char[] arr = password.ToCharArray();
        bool twoSpecialCh = true;

        for (int i = 0; i < password.Length - 1; i++)
        {
            int count = 0;

            string twoCh = $"{arr[i]}" + $"{arr[i + 1]}";
            char[] onlyTwoCh = twoCh.ToCharArray();

            foreach (char c in onlyTwoCh)
            {
                if (!char.IsLetterOrDigit(c))
                    count++;
            }

            if (count >= 2)
            {
                twoSpecialCh = false;
                break;
            }
        }
        return twoSpecialCh;
    }

    public static bool UpperCaseCheck(string password)
    {
        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                return true; 
            }
        }

        return false;
    }

    public static bool LowerCaseCheck(string password)
    {
        foreach (char c in password)
        {
            if (char.IsLower(c))
            {
                return true;
            }
        }

        return false;
    }

    public static bool Numbers(string password)
    {
        int count = 0;
        bool a = true;

        foreach (char c in password)
        {
            a = Char.IsDigit(c); 

            if (a == true)
                count++;
        }

        if (count >= 1)
            return true;
        else
            return false;
    }
}