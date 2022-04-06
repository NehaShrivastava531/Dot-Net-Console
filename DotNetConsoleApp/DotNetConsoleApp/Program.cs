using DotNetLibraryClass;
using System;
using System.Collections;

namespace DotNetConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 classobj = new Class1();

            char choice2;
            do
            {
                Console.Write("Enter First Number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Take one operation number:");
                Console.WriteLine("1. Additon");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                char choice = char.Parse(Console.ReadLine());
                

                    if (choice == '1')
                    {
                        Console.WriteLine(classobj.Add(num1, num2));
                    }
                    else if (choice == '2')
                    {
                        Console.WriteLine(classobj.Sub(num1, num2));
                    }
                    else if(choice == '3')
                    {
                        Console.WriteLine(classobj.Mul(num1, num2));
                    }
                    else if ((choice == '4'))
                    {
                        Console.WriteLine(classobj.Div(num1, num2));
                    }
                    Console.WriteLine("Do you want to calculate again(type y or n): ");
                    choice2 = char.Parse(Console.ReadLine());
            }
            while (choice2 == 'y' || choice2 == 'Y');


            Console.ReadLine();

        }
    }
}
