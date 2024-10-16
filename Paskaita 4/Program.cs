////////////////////////////////////////////////////////////////// Reikia naudoti tokį patį inputa kaip ir case
///1 pvz.

//int day = 4;
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Pirmadienis");
//        break;
//    case 2:
//        Console.WriteLine("Antradienis");
//        break;
//    case 3:
//        Console.WriteLine("Trečiadienis");
//        break;
//    default:
//        Console.WriteLine("Neteisinga diena");
//        break;
//}

////////////////////////////////////////////////////////////////
/////2 pvz.


//int operation = 1; 
//string result = operation switch
//{
//    1 => "Case 1",
//    2 => "Case 2",
//    3 => "Case 3",
//    _ => "Default case"
//};
//Console.WriteLine(result);

////////////////////////////////////////////////////////////////
/////3 pvz.
//string operation2 = "+";
//int num1 = 2;
//int num2 = 3;
//int result2 = operation2 switch
//{
//    "+" => (num1 + num2),
//    "-" => (num1 - num2),
//    _   => 0
//};
//Console.WriteLine(result2);

//int day = Convert.ToInt32(Console.ReadLine());
//string result = day switch
//{
//    1 => "Pirmadienis",
//    2 => "Antradienis",
//    3 => "Trečiadienis",
//    4 => "Ketvirtadienis",
//    5 => "Penktadienis",
//    6 => "Šeštadienis",
//    7 => "Sekmadienis",
//    _ => "Neteisinga diena"
//};
//Console.WriteLine(result);

//int age = Convert.ToInt32(Console.ReadLine());
//string result2 = age switch
//{
//    < 7 => "iki mokiklinukas",
//    >= 7 and <= 18 => "Moksleivis",
//    > 18 and <= 25 => "Studentas",
//    > 26 and <= 65 => "Darbuotojas",
//    _ => "Pensininkas"
//};
//Console.WriteLine(result2);
//int month = Convert.ToInt32(Console.ReadLine());
//string result2 = month switch
//{
//    1 => "sausis",
//    2 => "vasaris",
//    3 => "kovas",
//    4 => "balandis",
//    5 => "gegužė",
//    6 => "birželis",
//    7 => "liepa",
//    8 => "rugpjūtis",
//    9 => "rugsėjis",
//   10 => "spalis",
//   11 => "lapktritis",
//   12 => "Gruodis",
//    _ => "Nėra tokio mėnesio"
//};
//Console.WriteLine(result2);

//Console.WriteLine("įveskite geometrinę figūrą");
//string figure = Console.ReadLine().ToLower();
//    double result;
//    switch(figure)
//    {
//        case "kvadratas":
//        Console.WriteLine("įveskite kvadrato kraštinę");
//        int a = Convert.ToInt32(Console.ReadLine());
//        result = a * a;
//        Console.WriteLine(result);
//        break;
//        case "stačiakampis":
//            Console.WriteLine("įveskite stačiakmapio 1-mąją kraštinę");
//            int b = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("įveskite stačiakmapio 2-ąją kraštinę");
//            int c = Convert.ToInt32(Console.ReadLine());
//            result = b * c;
//            Console.WriteLine(result);
//        break;
//    case "apskritimas":
//            Console.WriteLine("įveskite apskritimo R");
//            int r = Convert.ToInt32(Console.ReadLine());
//            result = 3.14 * r * r;
//            Console.WriteLine(result);
//        break;
//    default:
//        Console.WriteLine("Neteisinga figūra");
//        break;
//    }
Console.WriteLine("įveskite specialybę");
string prof = Console.ReadLine().ToLower();
double extraPoint = 1.5d;
double mainPoint = 0;
switch (prof)
{
    case "matematika":
        {
            Console.WriteLine("įveskite metinį vidurkį");
            int vid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("įveskite matematikos egzamino rezultatą procentais");
            int egz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ar dalyvavai olimpiadoje T/N");
            string userInput = Console.ReadLine();
            int point1 = vid switch
            {
                < 7 => 5,
                >= 7 and <= 8 => 6,
                > 8 and < 10 => 7,
                _ => 0
            };
            int point2 = egz switch
            {
                < 50 => 5,
                >= 70 and <= 80 => 6,
                > 80 and < 100 => 7,
                _ => 0
            };
            if (userInput == "T")
            {
                mainPoint = point1 + point2 + extraPoint;
            }
            Console.WriteLine(mainPoint);
            break;
        };
    case "biologija":
        {
            Console.WriteLine("įveskite metinį vidurkį");
            int vid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("įveskite biologijos egzamino rezultatą procentais");
            int egz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ar dalyvavai olimpiadoje T/N");
            string userInput = Console.ReadLine();
            int point1 = vid switch
            {
                < 7 => 5,
                >= 7 and <= 8 => 6,
                > 8 and < 10 => 7,
                _ => 0
            };
            int point2 = egz switch
            {
                < 50 => 5,
                >= 70 and <= 80 => 6,
                > 80 and < 100 => 7,
                _ => 0
            };
            if (userInput == "T")
            {
                mainPoint = point1 + point2 + extraPoint;
            }
            Console.WriteLine(mainPoint);
            break;
        };
    case "fizika":
        {
            Console.WriteLine("įveskite metinį vidurkį");
            int vid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("įveskite fizikos egzamino rezultatą procentais");
            int egz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ar dalyvavai olimpiadoje T/N");
            string userInput = Console.ReadLine();
            int point1 = vid switch
            {
                < 7 => 5,
                >= 7 and <= 8 => 6,
                > 8 and < 10 => 7,
                _ => 0
            };
            int point2 = egz switch
            {
                < 50 => 5,
                >= 70 and <= 80 => 6,
                > 80 and < 100 => 7,
                _ => 0
            };
            if (userInput == "T")
            {
                mainPoint = point1 + point2 + extraPoint;
            }
            Console.WriteLine(mainPoint);
            break;
    default:
    Console.WriteLine(mainPoint);
    break;

        };
}
string result2 = mainPoint switch
{
   < 11.5 => "Maži šansai",
   >12 and <14 => "Vidutiniai šansai",
    > 14 => "Dideli šansai",
    _ => " "
};
Console.WriteLine(result2);

















//        if (userInput == "T")
//        {


//        }
//}






