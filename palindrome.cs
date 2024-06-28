Write a method that checks if a given string is a palindrome.

csharp
Copy code
using System;

class Program
{
    static void Main()
    {
        string input = "madam";
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine($"Is '{input}' a palindrome? " + isPalindrome);
    }

    static bool IsPalindrome(string str)
    {
        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
