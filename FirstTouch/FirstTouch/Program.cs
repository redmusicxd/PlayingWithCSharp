using System;
using System.Text.RegularExpressions;

namespace FirstTouch
{
    class MainClass
    {
        public static void Calculator(int a, int b)
        {
            int c = 0;
            string d, ask;
            Console.WriteLine("Arithmethic Operation:");
            do
            {
                d = Console.ReadLine();
                if (d == "*" || d == "times")
                    c = 1;
                else if (d == "+" || d == "add")
                    c = 2;
                else if (d == "-" || d == "substract")
                    c = 3;
                else if (d == "/" || d == "divide")
                    c = 4;
                else if (d == "mod" || d == "%")
                    c = 5;
                else
                    Console.WriteLine("Try Again!");

            } while (c == 0);
            switch (c)
            {
                case 1:
                    Console.Write("Result: {0}", a * b);
                    break;
                case 2:
                    Console.Write("Result: {0}", a + b);
                    break;
                case 3:
                    Console.Write("Result: {0}", a - b);
                    break;
                case 4:
                    Console.Write("Result: {0}", a / b);
                    break;
                case 5:
                    Console.Write("Result: {0}", a % b);
                    break;
                default:
                    Console.WriteLine("Select a operation.");
                    break;
            }
            Console.WriteLine("\n" +
                "Would you like to try another tool?");
            ask = Console.ReadLine();
            if (ask == "yes" || ask == "y" || ask == "Y")
                MainClass.Main(null);
            else
                return;
        }
        public static void Currency(string b)
        {
            double t = 0;
            double[] exchange = { 4.72, 4.26, 4.33, 2.41, 5.26 };
            string ask;
            string currency = Regex.Match(b, @"[a-zA-Z]+").Value;
            string origin = Regex.Match(b, @"\d+").Value;

            if (currency == null && origin == null)
                Console.WriteLine("Invalid parameters!");
            if (string.Equals(currency, "CHF", StringComparison.CurrentCultureIgnoreCase))
                t = double.Parse(origin) * exchange[2];
            if (string.Equals(currency, "EUR", StringComparison.CurrentCultureIgnoreCase))
                t = double.Parse(origin) * exchange[0];
            if (string.Equals(currency, "USD", StringComparison.CurrentCultureIgnoreCase))
                t = double.Parse(origin) * exchange[1];
            if (string.Equals(currency, "BGN", StringComparison.CurrentCultureIgnoreCase))
                t = double.Parse(origin) * exchange[3];
            if (string.Equals(currency, "GBP", StringComparison.CurrentCultureIgnoreCase))
                t = double.Parse(origin) * exchange[4];
            if (t != 0) Console.WriteLine("RON: {0}", t);
            Console.WriteLine("\n" +
               "Would you like to try another tool?");
            ask = Console.ReadLine();
            if (ask == "yes" || ask == "y" || ask == "Y")
                MainClass.Main(null);
            else
                return;
        }
        public static void Weight(float a, string b)
        {
            if (Regex.IsMatch(b, @"g\w*", RegexOptions.IgnoreCase))
            {
                Console.WriteLine("From Metric");
                if(string.Equals(b, "kg", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Pounds: " + a * 2.2046);
                    Console.WriteLine("Ounces: " + a * 35.27396195);
                }
                
            }
            Console.WriteLine("\n" +
            "Would you like to try another tool?");
            string ask = Console.ReadLine();
            if (ask == "yes" || ask == "y" || ask == "Y")
                MainClass.Main(null);
            else
                return;
        }
        public static void Main(string[] args)
        {
            int a, b, c=0;
            string d;
            int so = 0;
            Console.Write("Select a tool: \n 1. Calculator \n 2. Currency Converter\nChoice: ");
            while(!int.TryParse(Console.ReadLine(), out c))
            {

                try
                {
                    Console.WriteLine("Invalid Input"); 
                    so++;
                    if(so == 5)
                    {
                        Console.WriteLine("Try Again!");
                    }
                    if(so == 8)
                    {
                        Console.WriteLine("Last Chance!");
                    }
                    if (so == 9)
                    {
                        return;
                    }

                }
                catch(FormatException)
                {
                    c = int.Parse(Console.ReadLine()); continue;
                }
            }

            switch (c)
            {
                case 1:
                    Console.Write("1st Number: ");
                    while (!int.TryParse(Console.ReadLine(), out a))
                    {
                        try
                        {
                            Console.WriteLine("Not a valid number!");
                            if (so == 5)
                            {
                                Console.WriteLine("Try Again!");
                            }
                            if (so == 8)
                            {
                                Console.WriteLine("Last Chance!");
                            }
                            if (so == 9)
                            {
                                return;
                            }

                        }
                        catch (FormatException)
                        {
                            a = int.Parse(Console.ReadLine()); continue;
                        }
                    }
                    Console.Write("2nd Number: ");
                    while (!int.TryParse(Console.ReadLine(), out b))
                    {
                        try
                        {
                            Console.WriteLine("Not a valid number!");
                            if (so == 5)
                            {
                                Console.WriteLine("Try Again!");
                            }
                            if (so == 8)
                            {
                                Console.WriteLine("Last Chance!");
                            }
                            if (so == 9)
                            {
                                return;
                            }

                        }
                        catch (FormatException)
                        {

                            b = int.Parse(Console.ReadLine()); continue;
                        }
                    }
                    Calculator(a, b);
                    break;
                case 2:
                    Console.WriteLine("Currency & Value");
                    d = Console.ReadLine();
                    Currency(d);
                    break;
                case 3:
                    float e = float.Parse(Console.ReadLine());
                    string f = Console.ReadLine();
                    Weight(e, f);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
