using System;

namespace TemperatureConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            // Loop until the user chooses to exit
            do
            {
                // Display the menu
                Console.Clear();
                Console.WriteLine("Temperature Converter");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Convert Celsius to Kelvin");
                Console.WriteLine("3. Convert Fahrenheit to Celsius");
                Console.WriteLine("4. Convert Fahrenheit to Kelvin");
                Console.WriteLine("5. Convert Kelvin to Celsius");
                Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Enter your choice (1-7):");

                // Read user input
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ConvertCelsiusToFahrenheit();
                        break;
                    case "2":
                        ConvertCelsiusToKelvin();
                        break;
                    case "3":
                        ConvertFahrenheitToCelsius();
                        break;
                    case "4":
                        ConvertFahrenheitToKelvin();
                        break;
                    case "5":
                        ConvertKelvinToCelsius();
                        break;
                    case "6":
                        ConvertKelvinToFahrenheit();
                        break;
                    case "7":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                // Pause before returning to the menu (if not exiting)
                if (userInput != "7")
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }

            } while (userInput != "7");  // Continue until the user chooses to exit
        }

        // Method to convert Celsius to Fahrenheit
        static void ConvertCelsiusToFahrenheit()
        {
            Console.WriteLine("Enter temperature in Celsius:");
            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

        // Method to convert Celsius to Kelvin
        static void ConvertCelsiusToKelvin()
        {
            Console.WriteLine("Enter temperature in Celsius:");
            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double kelvin = celsius + 273.15;
                Console.WriteLine($"{celsius}°C = {kelvin}K");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

        // Method to convert Fahrenheit to Celsius
        static void ConvertFahrenheitToCelsius()
        {
            Console.WriteLine("Enter temperature in Fahrenheit:");
            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

        // Method to convert Fahrenheit to Kelvin
        static void ConvertFahrenheitToKelvin()
        {
            Console.WriteLine("Enter temperature in Fahrenheit:");
            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                double kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;
                Console.WriteLine($"{fahrenheit}°F = {kelvin}K");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

        // Method to convert Kelvin to Celsius
        static void ConvertKelvinToCelsius()
        {
            Console.WriteLine("Enter temperature in Kelvin:");
            if (double.TryParse(Console.ReadLine(), out double kelvin))
            {
                double celsius = kelvin - 273.15;
                Console.WriteLine($"{kelvin}K = {celsius}°C");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

        // Method to convert Kelvin to Fahrenheit
        static void ConvertKelvinToFahrenheit()
        {
            Console.WriteLine("Enter temperature in Kelvin:");
            if (double.TryParse(Console.ReadLine(), out double kelvin))
            {
                double fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;
                Console.WriteLine($"{kelvin}K = {fahrenheit}°F");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }
}
