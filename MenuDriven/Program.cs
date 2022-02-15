using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDriven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tArithmetic Operations");
            Console.WriteLine("\t\t\t\t\t---------------------");
            char choice;
            do
            {
                Console.WriteLine("enter number1");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter number2");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Menu: \n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Exit");

                Console.WriteLine("enter the choice");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Addition of two numbers : " + (a + b));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction of two numbers : " + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication of two  numbers: " + (a * b));
                        break;
                    case 4:
                        Console.WriteLine("Division of two numbers: " + (a / b));
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Do you want to continue(y/n)?");
                choice = Convert.ToChar(Console.ReadLine());


                    
            





            } while (choice == 'y');
        }
    }
}
