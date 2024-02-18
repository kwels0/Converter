using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter
{
    public class Converter
    {
        private double kilometers;
        private double miles;
        private double celsius;
        private double fahrenheit;
        private double USDollars;
        private double PHPeso;

        public double Kilometers
        { get; set; }
        public double Miles
        { get; set; }
        public double Celsius 
        { get; set; }
        public double Fahrenheit
        { get; set; }
        public double MoneyUSDollars
        { get; set; } 
        public double MoneyPHPeso
        { get; set; }

        public double ConvertKilometersToMiles()
        {
            return Kilometers * 0.621371;
        }

        public double ConvertMilesToKilometers()
        {
            return Miles * 1.60934;
        }

        public double ConvertCelsiusToFahrenheit()
        {
            return (Celsius * 9 / 5) + 32;
        }

        public double ConvertFahrenheitToCelsius()
        {
            return (Fahrenheit - 32) * 5 / 9;
        }

        public double ConvertUSDollarsToPHPesos()
        {
            return MoneyUSDollars * 56.21;
        }

        public double ConvertPHPesoToUSDollars()
        {
            return MoneyPHPeso / 56.21;
        }
    }
    public class Driver
    {
        public static void Main()
        {
            Converter values = new Converter();
            while (true)
            {
                Console.WriteLine(@"
Press the number of which value you want to convert.
[1] Kilometers to Miles
[2] Miles to Kilometers
[3] Celcius to Fahrenheit
[4] Fahrenheit to Celcius
[5] US Dollar to PH Peso
[6] PH Peso to US Dollar
[7] Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    Console.WriteLine("Enter the length of kilometers: ");
                    values.Kilometers = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Converted value of {values.Kilometers}km is {values.ConvertKilometersToMiles()}m");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 2:
                    Console.WriteLine("Enter the length of miles: ");
                    values.Miles = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Converted value of {values.Miles}m is {values.ConvertMilesToKilometers()}km");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 3:
                    Console.WriteLine("Enter the temparature of celcius: ");
                    values.Celsius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Converted value of {values.Celsius}°C is {values.ConvertCelsiusToFahrenheit()}°F");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 4:
                    Console.WriteLine("Enter the temparature of fahrenheit: ");
                    values.Fahrenheit = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Converted value of {values.Fahrenheit}°F is {values.ConvertFahrenheitToCelsius()}°C");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 5:
                    Console.WriteLine("Enter the amount of US Dollar: ");
                    values.MoneyUSDollars = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Converted value of {values.MoneyUSDollars}$ is {values.ConvertUSDollarsToPHPesos()}₱");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 6:
                    Console.WriteLine("Enter the amount of PH Peso: ");
                    values.MoneyPHPeso = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Converted value of {values.MoneyPHPeso}₱ is {values.ConvertPHPesoToUSDollars()}$");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                    case 7:
                    Console.WriteLine("Exiting");
                    Console.WriteLine(@"
███████████████████████████████████████████████
███████████████████████████████████████████████
███████████████████████████ ███████████▒▓██████
█████████████████████████▒ ▒ █████████ ░░ █████
███████████████████████▓ ███░▒██████ ▓███ █████
█████████████████████▒ ████▓   ▒▓▓░  ░▓██ █████
██████████████████                        █████
████████████████                          █████
██████████████                            █████
██████████████                            ▒████
███▓         ░                             ▓███
███▒    ▒▒▒▒            ░█████     ░█████  ▓███
█████████████████░                        ▓████
████████████████████░                   ▒██████
███████████████████████████████████████████████");
                    return;

                    default:
                    Console.WriteLine("Invalid Choice. Please try again!");
                    break;
                }
            }
        }
    }
}// orginal lines w/o design 127 haha