// Ciklai While ir Do while
//int i = 1;
//while (i <=5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//int i = 1;
//string result = "";
//while (i <= 5)
//{
//    Console.WriteLine("Įveskite teksta: ");
//    string input = Console.ReadLine();
//    result += " " + input;
//    i++;
//}
//Console.WriteLine(result);

//int x = 1;
//int y = 1;
//while (x <= 3)
//{
//    Console.WriteLine("Outer scope: " + x);

//    while (y <= 3)
//    {
//        Console.WriteLine("Inner scoope: " + y);
//        y++;
//    }
//    y = 1; //Nustatome vidinio ciklo skaitkliuka i pradine reikšme
//    x++;     
//}    
//string filePath = "sample.txt";
//try 
//{ 
//    using (StreamReader sr = new StreamReader(filePath))
//    {
//        string line;
//        while ((line = sr.ReadLine()) != null)
//        {
//            Console.WriteLine(line);
//        }
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine("An error occurred: " + ex.Message);
//}
//int number;
//bool isNumber = false;
//do
//{
//    Console.WriteLine("Įveskite skaiciu: ");
//    string input = Console.ReadLine();
//    isNumber = int.TryParse(input, out number);
//    if (isNumber)
//    {
//        Console.WriteLine(isNumber);
//    }
//} while (!isNumber);

//////////////////////////////////UŽDUOTYS/////////////////////////////

//int i = 1;
//while (i <= 5)
//{
//    Console.WriteLine(i);
//    i++;
//}
//int y = 5;
//while (y >= 1)
//{
//    Console.WriteLine(y);
//    y--;
//}

//int i = 2;
//while (i <=10)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//    i++;
//}
//int y = 10;
//while (y >= 1)
//{
//    if (y % 2 != 0)
//    {
//        Console.WriteLine(y);
//    }
//    y--;
//}

//Console.WriteLine("Įveskite skaičių");
//int i = Convert.ToInt32(Console.ReadLine());
//while ( i < 100)
//{
//    Console.WriteLine("įveskite skaičių didesnį už 100");
//    i = Convert.ToInt32(Console.ReadLine());
//}
//int y = i;
//while (y >= 1)
//{
//    Console.WriteLine(y);
//    y--;
//}

//Console.WriteLine("Įveskite skaičių");
//int i = Convert.ToInt32(Console.ReadLine());
//int sum = 1;
//while (i>=1)
//{
//    sum = sum * i;
//    i--;
//}
//Console.WriteLine(sum);
// 2 uzduotis
//Console.WriteLine("Įveskite skaičių");
//int i = Convert.ToInt32(Console.ReadLine());
//int sum = 1;
//bool isMoreThanZero = false;
//if (i>0)
//{
//    isMoreThanZero = true;
//}
//while (isMoreThanZero)
//{
//    while ( i >= 1)
//    {
//        sum = sum * i;
//        i--;
//    }
//    Console.WriteLine(sum);
//    sum = 1;
//    Console.WriteLine("Įveskite skaičių");
//    i = Convert.ToInt32(Console.ReadLine());
//    if ( i< 0)
//    {
//        isMoreThanZero = false;
//        Console.WriteLine("Your number is negative");
//    }

//}

//Console.WriteLine("Įveskite teigiamą skaičių");
//string number = Console.ReadLine();
//int i = 0;
//char[] inputTextnumber = number.ToCharArray();
//string result = " ";
//while (i <= inputTextnumber.Length-1)
//{
//    char digit = inputTextnumber[i];
//    result += digit + ", ";
//    i++;
//}
//Console.WriteLine(result);


//int number;
//bool isNumber = false;
//string i;
//string result = " ";
//do
//{
//    Console.WriteLine("Įveskite skaiciu: ");
//    i= Console.ReadLine();
//    isNumber = int.TryParse(i, out number);
//    if (isNumber)
//    {
//        Console.WriteLine(i);
//    }
//} while (!isNumber);
//int y = Convert.ToInt32(i); 
//while (y >0)
//{
//    result = "*" + result;
//    Console.WriteLine(result);
//    y--;
//}
// 4 uzduotis
int number;
bool isNumber = false;
string i;
string result = " ";

do
{
    Console.WriteLine("Įveskite skaiciu: ");
    i = Console.ReadLine();
    isNumber = int.TryParse(i, out number);
    if (isNumber)
    {
        Console.WriteLine(i);
    }
} while (!isNumber);
int y = Convert.ToInt32(i);
int x = 8;
if (y < 10)
{
    while (x < 8)
    {
        y
        result = "*" + result;
        Console.WriteLine(result);
        y--;
    }
}









