using System;

class Program
{
    static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information

        
        
        double input;

        Console.WriteLine("Velg konvertering:");
        Console.WriteLine("1. Fra Celsius til Fahrenheit");
        Console.WriteLine("2. Fra Fahrenheit til Celsius");
        string? choice = Console.ReadLine();

        Console.WriteLine("Skriv inn Temperaturen du vil velge: ");
        try
        {
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Du skrev inn: " + input);

            if(choice == "1"){
                double fahrenheit = convertToFahrenheit(input);
                Console.WriteLine("Det blir: " + fahrenheit + " fahrenheit");
            }else if (choice == "2")
            {
                double celsius = convertToCelsius(input);
                Console.WriteLine("Det blir: " + celsius + " celsius");
            }
            else{
                Console.WriteLine("Ugyldig valg");
            }            

        }
        catch (System.FormatException)
        {
            Console.WriteLine("Du må skrive inn et tall");
        }


    }

    static double convertToFahrenheit(double input)
    {
        double result = (input * 9 / 5) + 32;
        return result;
    }

    static double convertToCelsius(double input)
    {
        double result = (input - 32) * 5 / 9;
        return result;
    }
}