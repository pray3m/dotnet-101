using System;

class InterestCalculator
{
    public static void Main()
    {
        Console.WriteLine("Enter the principal, time and rate : ");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(' ');
        double principal = Convert.ToDouble(inputArray[0]);
        double time = Convert.ToDouble(inputArray[1]);
        double rate = Convert.ToDouble(inputArray[2]);

        double result = CalcSimpleInterest(principal, time, rate);

        Console.WriteLine($"The simple interest is : {result}");

    }
    static double CalcSimpleInterest(double p, double t, double r)
    {
        return (p * t * r) / 100;
    }

}