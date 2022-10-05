using System;

class Converter
{
    decimal euro_rate, dollar_rate;
    public Converter(decimal euros, decimal dollars)
    {
        euro_rate = euros;
        dollar_rate = dollars;
    }
    public decimal convert_h_to_euro(decimal hrv)
    {
        return (hrv / euro_rate);
    }
    public decimal convert_h_to_dollar(decimal hrv)
    {
        return (hrv / dollar_rate);
    }
    public decimal convert_euro_to_h(decimal euros)
    {
        return (euros * euro_rate);
    }
    public decimal convert_dollar_to_h(decimal dollars)
    {
        return (dollars * dollar_rate);
    }
}
class Program
{
    const decimal euro_rate = (decimal)36.52;
    const decimal dollar_rate = (decimal)36.93;
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the amount of hryvnias:");
        decimal hryvnias;
        while (true)
        {
            try
            {

                hryvnias = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input, try again");
            }
        }
        Converter conv = new Converter(euro_rate, dollar_rate);
        string input = "";
        Console.WriteLine("Choose currency to convert to: \"euro\", or \"dollar\". Type \"stop\" to terminate");
        input = Console.ReadLine();
        while (input != "stop")
        {
            if (input == "euro")
            {
                decimal x = conv.convert_h_to_euro(hryvnias);
                Console.WriteLine("Converted to " + x + " euros");
                break;
            }
            else if (input == "dollar")
            {
                decimal x = conv.convert_h_to_dollar(hryvnias);
                Console.WriteLine("Converted to " + x + " dollars");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect input, try again");
                input = Console.ReadLine();
            }
        }
        Console.WriteLine("Choose currency to convert from: \"euro\", or \"dollar\". Type \"stop\" to terminate");
        input = Console.ReadLine();
        while (input != "stop")
        {
            if (input == "euro")
            {
                while (true)
                {
                    try
                    {

                        Console.WriteLine("Input the amount of euros:");
                        decimal euros = Convert.ToInt32(Console.ReadLine());
                        decimal x = conv.convert_euro_to_h(euros);
                        Console.WriteLine("Converted to " + x + " hryvnias");
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect input, try again");
                    }
                }
                break;
            }
            else if (input == "dollar")
            {
                while (true)
                {
                    try
                    {

                        Console.WriteLine("Input the amount of dollars:");
                        decimal dollars = Convert.ToInt32(Console.ReadLine());
                        decimal x = conv.convert_dollar_to_h(dollars);
                        Console.WriteLine("Converted to " + x + " hryvnias");
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Incorrect input, try again");
                    }
                }
                break;
            }
            else
            {
                Console.WriteLine("Incorrect input, try again");
                input = Console.ReadLine();
            }
        }
    }
}