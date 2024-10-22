using System;
using System.Threading.Channels;

namespace _9pamoka_ref_out
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //string text = " abcd ";
    //        //int y =10;
    //        //int z = 20;
    //        //Console.WriteLine(y);
    //        //Console.WriteLine(z);
    //        //Swap(ref y, ref z);
    //        //Console.WriteLine(y);
    //        //Console.WriteLine(z);
    //        //IncrementByN(ref y);
    //        //Console.WriteLine(y);
    //        //TrimAndCapitalize(ref text);
    //        //Console.WriteLine(text);
    //        GetUserData(out string name, out string surname);
    //        Console.WriteLine($"{name} {surname}");

    //    }
    //    //static void Swap (ref int y, ref int z)
    //    //{
    //    //    int x = y;
    //    //    y = z;
    //    //    z = x;
    //    //}
    //    //static void IncrementByN (ref int y)
    //    //{
    //    //    while (y < 100)
    //    //    {
    //    //        y += 10;
    //    //    }
    //    //}
    //    //static void TrimAndCapitalize(ref string text)
    //    //{
    //    //    char[] symbols = text.Trim().ToCharArray();
    //    //    text = (char.ToUpper(symbols[0]) + text.Trim().Substring(1));
    //    //}

    //}

    //}
    internal class Program
    {
        static void Main(string[] args)
        {

            //GetUserData(out string name, out string surname);
            //Console.WriteLine($"{name} {surname}");
            //OneHundred(out int input);
            int dividedValue = Divide(out int MOD);
            Console.WriteLine($"Liekana {MOD} ir {dividedValue}");

        }

        public static void GetUserData(out string name, out string surname)
        {
            Console.WriteLine("įveskite vardą");
            name = Console.ReadLine();
            Console.WriteLine("įveskite pavardę");
            surname = Console.ReadLine();

        }
        public static int OneHundred(out int input)
        {
            bool isValid = false;
            input = 0;
            
           while (input < 100)
            {
                Console.WriteLine("Įveskite skaičių");
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Įveskite skaičių");
                    continue;
                }
                isValid = true;
                
            };
            Console.WriteLine("Įvedėte didesnį negu 100");
            return input;
           
        }


        public static int Divide(out int mod)
        {
            bool isValidnumber = false;
            

            double numberA=0;
            double numberB=0;
            while (!isValidnumber)
            {
                Console.WriteLine("Įveskite A skaičių");
                if (!double.TryParse(Console.ReadLine(), out numberA))
                {
                    
                    continue;
                }
                else if (!double.TryParse(Console.ReadLine(), out numberB))
                {
                   continue;
                }
                else if (numberB == 0)
                {
                    Console.WriteLine("Dalyba iš 0 negalima");
                    continue;
                }
                isValidnumber = true;
            };
            double result = numberA % numberB;
            double result2 = numberA / numberB;
            int divide = (int)result2;
            mod = (int)result;
            return divide;
            
        }

       

    }

}