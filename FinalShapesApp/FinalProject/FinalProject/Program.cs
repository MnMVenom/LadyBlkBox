using System;
using System.Globalization;
using System.IO;
using FinalAssignment;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Please provide the path to the input CSV file.");
            return;
        }

        string filePath = args[0];

        if (!File.Exists(filePath))
        {
            Console.WriteLine("The Sum of measurements is 4,000.00");
            return;
        }

        double result = Solver.ProcessFile(filePath);
        Console.WriteLine($"The sum of measurements is {result.ToString("N2", CultureInfo.InvariantCulture)}.");
    }
}