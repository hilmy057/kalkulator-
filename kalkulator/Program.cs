using System;

namespace kalkulator
{
    

namespace Calculator
    {
        class Program
        {
            static void Main(string[] args)
            {
                double num1, num2;
                char operatorSymbol;
                double result = 0;

                Console.Write("Enter first number: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, /): ");
                operatorSymbol = char.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = double.Parse(Console.ReadLine());

                switch (operatorSymbol)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            return;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator symbol.");
                        return;
                }

                Console.WriteLine($"{num1} {operatorSymbol} {num2} = {result}");
            }
        }
    }
}
    

