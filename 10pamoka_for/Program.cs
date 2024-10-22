//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}
//for (int i = 4; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}
//for (int i = 0; i <= 10; i += 3)
//{
//    Console.WriteLine(i);
//}
//string result = "Mano vardas";
//for (int i = 0; i < result.Length; i++)
//{
//    Console.WriteLine(result[i]);
//}

//internal class Program
//{
//    static void Main(string[] args)
//    {



//    }
//}
//for (int i = 2; i <= 100; i += 2)
//{
//    Console.WriteLine(i);
//}
//int sum = 0;
//Console.WriteLine("įveskite skaičių");
//int.TryParse(Console.ReadLine(), out int n);
//for (int i = 1; i <= n; i++)
//{
//    sum = sum + i;

//}
//Console.WriteLine($"suma {sum}");
//int n;
//bool isValid = false;
//int sum = 0;
//do
//{
//    Console.WriteLine("įveskite skaičių");
//} while (!int.TryParse(Console.ReadLine(), out n));
//for (int i = 1; i <= n; i++)
//{
//    int square = i * i;
//    Console.WriteLine(square);
//}
//int n;
//bool isValid = false;
//int sum = 0;
//do
//{
//    Console.WriteLine("įveskite skaičių");
//} while (!int.TryParse(Console.ReadLine(), out n));


//for (int i = 1; i <= n; i++)
//{
//    sum = sum + i;
//}
//Console.WriteLine($"Vidurkis {(double)sum / n}");
//int n;
//bool isValid = false;
//int sum = 0;
//do
//{
//    Console.WriteLine("įveskite skaičių");
//} while (!int.TryParse(Console.ReadLine(), out n));
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("*");
//}

for (int i = 1; i <= 100; i++)
{
    for (int j = i; j % 3 == 0; j++)
    {
        Console.WriteLine(j);
    }
}
