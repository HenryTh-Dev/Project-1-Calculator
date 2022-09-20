using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class Program2
    {
        enum Menu { Sum = 1, Sub, Div, Multi, Pote, SRoot, Exit }

        static void Main(string[] args)
        {
            bool cExit = false;
            while (!cExit)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Calc, select a option below: ");
                Console.WriteLine("1-Sum\n2-Subtraction\n3-Division\n4-Multiplication\n5-Potency\n6-Square Root\n7-Exit");
                try
                {
                    Menu option = (Menu)int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case Menu.Exit:
                            cExit = true;
                            break;
                        case Menu.Sum:
                            Sum();
                            break;
                        case Menu.Sub:
                            Sub();
                            break;
                        case Menu.Div:
                            Div();
                            break;
                        case Menu.Multi:
                            Multi();
                            break;
                        case Menu.Pote:
                            Pote();
                            break;
                        case Menu.SRoot:
                            Sqrt();
                            break;
                        default:
                            break;

                    }
                    Console.Clear();

                }catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Choose a option from 1 to 7!");
                    Console.ReadLine();
                }

            }


        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Two numbers sum");
            Console.WriteLine("Type the first number:");
            float aSoma = float.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number:");
            float bSoma = float.Parse(Console.ReadLine());
            float resuSoma = (float)aSoma + (float)bSoma;
            Console.WriteLine($"The equation result is: {resuSoma}");
            Console.WriteLine("Press ENTER to return to main menu");
            Console.ReadLine();
        }

        static void Sub()
        {
            Console.Clear();
            Console.WriteLine("Two numbers subtraction");
            Console.WriteLine("Type the first number:");
            float aSub = float.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number:");
            float bSub = float.Parse(Console.ReadLine());
            float resuSub = (float)aSub - (float)bSub;
            Console.WriteLine($"The equation result is: {resuSub}");
            Console.WriteLine("Press ENTER to return to main menu");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.Clear();
            Console.WriteLine("Two numbers division:");
            Console.WriteLine("Type the first number:");
            float aDiv = float.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number:");
            float bDiv = float.Parse(Console.ReadLine());
            float resuDiv = (float)aDiv / (float)bDiv;
            Console.WriteLine($"The equation result is: {resuDiv}");
            Console.WriteLine("Press ENTER to return to main menu");
            Console.ReadLine();
        }
        static void Multi()
        {
            Console.Clear();
            Console.WriteLine("Two numbers multiplication");
            Console.WriteLine("Type the first number:");
            float aMulti = float.Parse(Console.ReadLine());
            Console.WriteLine("Type the second number:");
            float bMulti = float.Parse(Console.ReadLine());
            float resuMulti = ((float)aMulti * (float)bMulti);
            Console.WriteLine($"The equation result is: {resuMulti}");
            Console.WriteLine("Press ENTER to return to main menu");
            Console.ReadLine();
        }
        static void Pote()
        {
            Console.Clear();
            Console.WriteLine("Potency");
            Console.WriteLine("Type the base:");
            float aPot = float.Parse(Console.ReadLine());
            Console.WriteLine("Type the exponent:");
            float bPot = float.Parse(Console.ReadLine());
            float resuPot = (float)Math.Pow(aPot, bPot);
            Console.WriteLine($"The equation result is: {resuPot}");
            Console.WriteLine("Press ENTER to return to main menu");
            Console.ReadLine();
        }
        static void Sqrt()
        {
            Console.Clear();
            Console.WriteLine("Type the number you want to know the square root:");
            float aSqrt = float.Parse(Console.ReadLine());
            double resuSqrt = Math.Sqrt(aSqrt);
            Console.WriteLine("The square root of " + aSqrt + " is: " + resuSqrt);
            Console.WriteLine("Press ENTER to return to main menu");
            Console.ReadLine();
        }




        


    } 
}
