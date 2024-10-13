using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to c# calculator");

        StartCalculator();
    }

    static void StartCalculator()
    {
        Console.WriteLine("Enter the first number");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation (+, -, *, /, %):");
        string operation = Console.ReadLine();

        double result = PerformOperation(num1, num2, operation);

        Console.WriteLine($"result =  {result}");
    }
    static double Add(double a,double b) => a+b;
    static double Sub(double a, double b) => a-b;
    static double Mul(double a, double b) =>a*b;
    static double Div(double a, double b) => a/b;
    static double Mod(double a, double b) =>a%b;
    static double PerformOperation(double a, double b,string c)
    {
        return c switch
        {
            "+" => Add(a,b),
            "-" => Sub(a,b),
            "*" => Mul(a,b),
            "/" => Div(a,b),
            "%" => Mod(a,b),
            _ => 0
        };
    }
}