using System;
class Program
{
    public static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter a number:");
        while (true)
        {
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered number " + number);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number");
            }
        }
    }
}