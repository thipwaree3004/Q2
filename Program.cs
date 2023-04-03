using System;

class Program
{
    static void Main(string[] args)
    {
        double number, sum = 0, max = double.MinValue, min = double.MaxValue;
        int count = 0;
        string mode;

        do
        {
            Console.Write("Enter a number (type 'End' to stop): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "end")
            {
                break;
            }

            if (double.TryParse(input, out number))
            {
                count++;
                sum += number;

                if (number > max)
                {
                    max = number;
                }

                if (number < min)
                {
                    min = number;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number or 'End'.");
            }
        } while (true);

        do
        {
            Console.Write("Enter mode (type 'FindMax', 'FindMin', 'FindMean', or 'End' to stop): ");
            mode = Console.ReadLine().ToLower();

            switch (mode)
            {
                case "findmax":
                    Console.WriteLine("Max value: " + max);
                    break;
                case "findmin":
                    Console.WriteLine("Min value: " + min);
                    break;
                case "findmean":
                    double mean = sum / count;
                    Console.WriteLine("Mean value: " + mean);
                    break;
                case "end":
                    return;
                default:
                    Console.WriteLine("Invalid mode. Please enter 'FindMax', 'FindMin', 'FindMean', or 'End'.");
                    break;
            }
        } while (true);
    }
}