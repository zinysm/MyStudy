//int number1 = Convert.ToInt32(Console.ReadLine());
//if (number1 > 100)
//{
//    Console.WriteLine("Skaičius yra didesnis negu 100");
//}
//else if (number1 == 100)
//{
//    Console.WriteLine("Skaičius yra lygus 100");
//}
//else
//{
//    Console.WriteLine("skaičius yra mažesnis negus 100");
//}

//int day = Convert.ToInt32(Console.ReadLine());
//if (day == 1)
//{
//    Console.WriteLine(day + " - pirmadienis");
//    Console.WriteLine(day + " - pirmadienis");
//}
//else if (day == 2)
//{
//    Console.WriteLine(day + " - antradienis");
//}
//else if (day == 3)
//{
//    Console.WriteLine(day + " - trečiadienis");
//}
//else if (day == 4)
//{
//    Console.WriteLine(day + " - ketvirtadienis");
//}
//else if (day == 5)
//{
//    Console.WriteLine(day + " - penktadienis");
//}
//else if (day == 6)
//{
//    Console.WriteLine(day + " - šeštadienis");
//}
//else if (day == 7)
//{
//    Console.WriteLine(day + " - sekmadienis");
//}
//else if (day > 7 || day < 1)
//{
//    Console.WriteLine("Neteisingas dienos skaičius");
//}


//int number2 = Convert.ToInt32(Console.ReadLine());

//if (number2 % 2 == 0)
//{
//    Console.WriteLine("Skaičius yra lyginis");
//}
//else if (number2 % 5 == 0)
//{
//    Console.WriteLine("Skaičius dalijasi iš 5");
//}
//else
//{
//    Console.WriteLine("Skaičius neatitinka sąlygų");
//}

//int temp = Convert.ToInt32(Console.ReadLine());

//if (temp < 0)
//{
//    Console.WriteLine("Temperatūra žemesnė nei 0 - \"Šalta\"");

//}
//else if (temp > 0 && temp <=20)
//{
//    Console.WriteLine("Temperatūra tarp 0 ir 20 - \"Šalta\"");
//}
//else
//{
//    Console.WriteLine("Temperatūra virš 20 - \"karšta\"");
//}

//Console.WriteLine("Kada atsikėlei ryte");
//int time = Convert.ToInt32(Console.ReadLine());
//if (time >0 && time < 12)
//{
//    Console.WriteLine("Geros dienos");
//}
//else if (time> 12 && time < 18)
//{
//    Console.WriteLine("Geros popietės");
//}
//else if (time > 18 && time < 24)
//{
//    Console.WriteLine("Geros vakaro");
//}

//Console.WriteLine("įveskite slaptažodį");
//string pass = Console.ReadLine();
//string pass1 = "Mano";

//if(pass == "Mellon" || pass == pass1)
//{
//    Console.WriteLine("Sėkmingai prisijungta");

//}  

//else if (pass == "01101001 01101110")
//{
//    Console.WriteLine("Nulaužta");
//}
//else
//{
//    Console.WriteLine("Slaptažodis neteisingas, prašome bandyti dar kartą...");
//}

//Console.WriteLine("Įveskite savo amžių");
//int age = Convert.ToInt32(Console.ReadLine());
//if (age < 18)
//{
//    Console.WriteLine("Jums priklauso nepilnamečio akcija");
//}
//else if (age > 18 && age < 65)
//{
//    Console.WriteLine("Jūs esate suaugęs");
//}
//else if (age > 65)
//{
//    Console.WriteLine("Jums priklauso senjoro akcija");
//}

//Console.WriteLine("Įveskite metus");
//int year = Convert.ToInt32(Console.ReadLine());
//if((year % 4 ==0 && year % 100 !=100) || year % 400==0)
//{
//    Console.WriteLine("Tai yra keliamieji metai");
//}
//else
//{
//    Console.WriteLine("Tai nėra keliamieji metai");
//}
//Console.WriteLine("Įveskite skaičių");
//int number35 = Convert.ToInt32(Console.ReadLine());
//if (number35 % 3 == 0 && number35 % 5 == 0)
//{
//    Console.WriteLine("BazingaPop");
//}
//else if (number35 % 3 == 0)
//{
//    Console.WriteLine("Bazinga");
//}
//else if (number35 % 5 == 0)
//{
//    Console.WriteLine("Pop");
//}

//Console.WriteLine("Įveskite 1 skaičių");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Įveskite 2 skaičių");
//int number2 = Convert.ToInt32(Console.ReadLine());
//if(number1>0 && number2>0)
//{
//    Console.WriteLine("Abu skaičiai yra teigiami");
//}
//else if ((number1>0 && number2<0) || (number1 < 0 && number2>0))
//{
//    Console.WriteLine("Tik vienas skaičius yra teigiamas");
//}
//else 
//{
//    Console.WriteLine("Nei vienas skaičius nėra teigiams");
//}

//Console.WriteLine("Įveskite 1 skaičių");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Įveskite 2 skaičių");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Įveskite 3 skaičių");
//int number3 = Convert.ToInt32(Console.ReadLine());
//if (number3 == number2 && number2 == number1)
//{
//    Console.WriteLine("Visi skaičiai lygūs");
//}
//else if ((number3 != number2 && number2 == number1) || (number3 == number2 && number2 != number1) || (number1 == number3 && number2 != number1))
//{
//    Console.WriteLine("Du skaičiai yra lygūs");
//}
//else 
//{
//    Console.WriteLine("Nė vienas skaičius yra lygus");
//}
//if ((number1>0 && (number2>0 || number3>0) || (number2>0 && (number1>0 || number3>0) || (number3>0 && (number1>0 || number2>0)))))
//{
//    int sum = number1 + number2 + number3;
//    Console.WriteLine(sum);

//}
//else
//{
//    Console.WriteLine("Neįmanoma suskaičiuoti sumos");
//}

//Console.WriteLine("Įveskite metus ir mėnesį");
//string yearMonth = Console.ReadLine();
//string month = yearMonth.Substring(5,1);
//char m = yearMonth[4];
//if ((month == "1"|| month == "2" || month == "3") && m = "0")
//{
//    Console.WriteLine("Šaltas laikotarpis");
//}
//else if ((month == "6" || month == "7" || month == "8") && m = "0")
//{
//    Console.WriteLine("Karštas laikotarpis");
//}
//else
//{
//    Console.WriteLine("Vidutinis laikotarpis");
//}


//Console.WriteLine("Įveskite 1 skaičių");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Įveskite 2 skaičių");
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Įveskite 3 skaičių");
//int number3 = Convert.ToInt32(Console.ReadLine());
//if ((number1 > number2 + number3) || (number2 > number1 + number3) || (number3 > number1 + number2))
//{
//    Console.WriteLine("Galima sudaryti trikampį");
//}
//else
//{
//    Console.WriteLine("Negalima sudaryti trikampio");
//}

string product1 = "Obuolys";
int price1 = 3;
string product2 = "duona";
int price2 = 2;
string product3 = "pienas";
int price3 = 4;
Console.WriteLine(product1+ " " + price1 +" eur");
Console.WriteLine(product2 + " " + price2 + " eur");
Console.WriteLine(product3 + " " + price3 + " eur");
Console.WriteLine("Įveskite produktą 1");
string basket1 = Console.ReadLine();
Console.WriteLine("Įveskite produktą 2");
string basket2 = Console.ReadLine();
Console.WriteLine("Įveskite produktą 2");
string discountInput = Console.ReadLine();
bool discount = false;
Console.WriteLine("Ar turite kortele> Y/N");
string discountInput = Console.ReadLine();
if (discountInput == "Y")
{
    discount = true;
}

if (( basket1 == product1 || basket1 == product2 || basket1 == product3) && ((basket2 == product1 || basket2 == product2 || basket2 == product3)))
{
    if (discount)
    {
        //Apply discount 10%
    }
    else
    {

    }
}




