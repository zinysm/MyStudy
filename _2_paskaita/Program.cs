//override firstline
string firstLine = "vienas";
string secondLine = "du";
string thirdLine = firstLine + secondLine;
Console.WriteLine(firstLine);
firstLine = firstLine + secondLine;
Console.WriteLine(firstLine);
Console.WriteLine(thirdLine);




//cw = Console.WriteLine()

///////////////////////////////////////////////////////


//priskiriame eilutę kintamajui

string city = "Vilnius";

//kviečiame eilutė parametrą
int wordLength = "Vilnius".Length;


// kviečiame string kintamojo

int wordLength2 = city.Length;

Console.WriteLine(wordLength);
Console.WriteLine(wordLength2);

string city1 = "T";
string city2 = "CodeAcademy";
char myChar = city2[1];
char myChar1 = city1[0];
Console.WriteLine(myChar);
Console.WriteLine(myChar1);

int lastIndex = city2.Length - 1;

char lastChar = city2[city2.Length-1];

Console.WriteLine(lastChar);

//Tuscios eilutes

string word1 = "";
string word2;

//Replace
string word3 = "mama";
string word4 = word3.Replace("m", "p");
Console.WriteLine(word4+" "+word3);

//Uzduotys

string ConsoleOutuput = Console.ReadLine();
int number = ConsoleOutuput.Length;
char char1 = ConsoleOutuput[5];
string vardas = ConsoleOutuput.Substring(1);
string vardas2 = ConsoleOutuput.Substring(3, 5);
Console.WriteLine(number);
Console.WriteLine(char1);
Console.WriteLine(vardas);
Console.WriteLine(vardas2);

//dublikuoti eilute uzdedam kursori CTRL+D

//IndexOf

int check = ConsoleOutuput.IndexOf('a');
int check2 = ConsoleOutuput.IndexOf("nd");
Console.WriteLine(check);
Console.WriteLine(check2);
string myword10 = ConsoleOutuput.Trim().Replace('a', 'd'); //pirma panaikina tarpus priekyje ir gale ir pakeicia raide

//Trim
Console.WriteLine(ConsoleOutuput.Length);
Console.WriteLine(ConsoleOutuput.Trim().Length); //vienu metu galimi keli metodai
Console.WriteLine(myword10);

//Apjungti eilutes

string word7 = "ap", word8 = "gal" , word9 = "voti";
//string word8 = "gal";
//string word9 = "voti ";

string result = "";
string result2 = "";
result = result + word7 + word8 + word9;
result2 = string.Concat(word7, word8, word9);

Console.WriteLine(result);
Console.WriteLine(result2);

//ToString()
int number10 = 987;
string numberString = number10.ToString();
string numberString2 = Convert.ToString(number10);
int convertedNumber = Convert.ToInt32(numberString);
string charString = numberString[0].ToString();
string upperCase = numberString.ToUpper(); //ad
string lowerCase = numberString.ToLower();




