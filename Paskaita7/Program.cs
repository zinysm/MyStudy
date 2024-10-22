///////////////////////////////Metodai////////////////////////

//namespace _7_metodai
//{

//    internal class Programa
//    {
//        static void Main(string[] args)
//        {
//            //int x = ReturnNumber();
//            //Console.WriteLine("Hello world");
//            //PrintMenu();
//            //int userSelection = GetUserSelection();
//            //Console.WriteLine("jūs pasirinkite: " + userSelection);
//            //if (userSelection != -1)
//            //{
//            //    ProcessSelection(userSelection);
//            //}
//            DateTime input = new DateTime(1990, 6, 15);
//            if (IsOfLegalAge(input))
//            {
//                Console.WriteLine("Įvestas legalus amžius");
//            }
//            else
//            {
//                Console.WriteLine("Įvestas nelegalus amžius");
//            }

//        }

//        public static bool IsOfLegalAge(DateTime birthdate)
//        {
//            return CalculateAge(birthdate) >= 20;
//        }
//        public static int CalculateAge(DateTime birthdate)
//        {
//            return DateTime.Now.Year - birthdate.Year;
//        }
//        private static int ReturnNumber()
//        {
//            return 100;
//        }

//        private static void PrintMenu()
//        {
//            Console.WriteLine("1. Spausdinti prekes");
//            Console.WriteLine("2. Žiūrėti krepšelį");
//            Console.WriteLine("3. Išvalyti krepšelį");
//            Console.WriteLine("4. Pirkti");
//            Console.WriteLine("5. Išjungti programą");

//        }

//        public static void ProcessSelection(int selection)
//        {
//            switch (selection)
//            {
//                case 1:
//                    Console.WriteLine("1. Spausdinti prekes");
//                    break;
//                case 2:
//                    Console.WriteLine("2. Žiūrėti krepšelį");
//                    break;
//                case 3:
//                    Console.WriteLine("3. Išvalyti krepšelį");
//                    break;
//                case 4:
//                    Console.WriteLine("4. Pirkti");
//                    break;
//                case 5:
//                    Console.WriteLine("5. Išjungti programą");
//                    break;
//        }
//        }
//        private static int GetUserSelection()
//        {
//            Console.WriteLine("Įveskite pasirinkimą");
//            string input = Console.ReadLine();
//            if (!string.IsNullOrEmpty(input))
//            {
//                if(int.TryParse(input, out int result) && (result >=1 && result <=5))
//                {
//                    return result;
//                }
//                Console.WriteLine("Įveskite skaičių tarp 1 ir 5");
//            }
//            return -1;
//        }
//    }
//}

////////////////////////////Užduotys////////////////////////////////////////

using System.Diagnostics.CodeAnalysis;

///
namespace Užduotys_7pamoka;


internal class Programa
{
    static void Main(string[] args)
    {
        //string pass = Password();
        //IsPasswordValid(pass);
        //string EmailCheck = Email();
        //IsEmailValid(EmailCheck);
        //double doleriai = Dollars();
        //ConvertToEuros(doleriai);
        //string name = firsName();
        //string surname = lastName();
        //GetInitials(name,surname);
        //double height = Height();
        //double radius = Radius();
        //CalculateCylindeVolume(height, radius);
        //int number = Number2();
        //Console.WriteLine(IsNumberEven(number)); 
        //Recursion(number);
    }

    public static string Password()
    {
        Console.WriteLine("Įveskite slaptažodį");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Jūsų slaptažodis: "+ input);
            return input;
        }
        Console.WriteLine("Jūs neįvedėte slaptažodžio");
        return "-1";
    }
    public static void IsPasswordValid(string check)
    {

        bool password = false;
        if (check.Length >= 8)
        {
            password = true;
        }
        Console.WriteLine(password);
    }

    public static string Email()
    {
        Console.WriteLine("Įveskite el. paštą");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Jūsų el. paštas: " + input);
            return input;
        }
        Console.WriteLine("Jūs el. pašto");
        return "-1";
    }
    public static void IsEmailValid(string EmailCheck)
    {
        bool email = false;
        char[] symbols = EmailCheck.ToCharArray();
        if ((symbols.Contains<char>('@')) && (symbols.Contains<char>('.')))
        {
            email= true;
        }
        Console.WriteLine(email);
    }
    public static double Dollars()
    {
        Console.WriteLine("Įveskite turimus dolerius");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            double number;
            bool check = double.TryParse(input, out number);
            return number;
        }
        Console.WriteLine("Neteisingai įvesta");
        return -1;
    }
    public static void ConvertToEuros(double doleriai)
    {
        double sum;
        sum = doleriai * 0.85;
        Console.WriteLine(sum);
    }
    public static string firsName()
    {
        Console.WriteLine("Įveskite savo vardą");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Jūsų vardas: " + input);
            return input;
        }
        Console.WriteLine("Jūs neįvedėte savo vardo");
        return "-1";
    }
    public static string lastName()
    {
        Console.WriteLine("Įveskite savo pavardę");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Jūsų pavardė: " + input);
            return input;
        }
        Console.WriteLine("Jūs neįvedėte savo pavardės");
        return "-1";
    }
    public static void GetInitials(string name, string surname)
    {
        string both = name + " " + surname;
        Console.WriteLine(both);
    }
    public static void CalculateCylindeVolume(double height, double radius)
    {
        
        double sum = height * radius*radius*3.14;
        Console.WriteLine(sum);
    }
    public static double Radius()
    {
        Console.WriteLine("Įveskite cylindro radiusą");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            double number;
            bool check = double.TryParse(input, out number);
            return number;
        }
        Console.WriteLine("Neteisingai įvesta");
        return -1;
    }
    public static double Height()
    {
        Console.WriteLine("Įveskite cylindro aukštį");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            double number;
            bool check = double.TryParse(input, out number);
            return number;
        }
        Console.WriteLine("Neteisingai įvesta");
        return -1;
    }
    public static int Recursion(int number)
    {
        
        if ((number-1) ==0)
        {
        
         return 1;

        }
        else
        {
            return number * Recursion(number - 1);
        }
        
        Console.WriteLine(number);
        return number;
        
        
    }
    public static int Number()
    {
        Console.WriteLine("Įveskite skaičių faktorialui skaičiuoti");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            int number;
            bool check = int.TryParse(input, out number);
            return number;
        }
        Console.WriteLine("Neteisingai įvesta");
        return -1;
    }
    public static int Number2()
    {
        Console.WriteLine("Įveskite skaičių");
        string input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            int number;
            bool check = int.TryParse(input, out number);
            return number;
        }
        Console.WriteLine("Neteisingai įvesta");
        return -1;
    }
    public static bool IsNumberEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        return false;
    }
}