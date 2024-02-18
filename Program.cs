using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;


namespace C_calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                //variable of result
                int res;
                Console.Write("Enter first number:");
                //convert string to number 32bytes
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = number1 + number2;
                        Console.WriteLine("Addition:" + res);
                        break;
                    case "-":
                        res = number1 - number2;
                        Console.WriteLine("Subtraction:" + res);
                        break;
                    case "*":
                        res = number1 * number2;
                        Console.WriteLine(" Multiplication:" + res);
                        break;
                    case "/":
                        res = number1 / number2;
                        Console.WriteLine(" Division: " + res);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
            
        }
    }
}
