using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter
{
public void ConverterMethod()
{
    Values();
    value = "";
    switch(value)
    case "ConvertKilometersToMiles":
        value /= 0.621371;
        return value;
    case "ConvertMilesToKilometers":
        value /= 1.60934 
        return;
    case "ConvertCelsiusToFahrenheit":
        value = value * 9 / 5;
        value += 35;
        return;
    case "ConvertFahrenheitToCelsius":
        value -= 32;
        value = value * 5 / 9;
        return;
    case "ConvertUSDollarsToPhilippinePesos":
        value *= 56.21;
        return;
    case "ConvertPhilippinePesosToUSDollars":
        
        return;
}

public void Values()
{
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

public static void Main(string[] args)
{
    while (true)
    {
        ConverterMethod();
        Console.WriteLine("Try again?\n[Y] or [N]");
        else
        {
            break;
        }
    }
}
}
