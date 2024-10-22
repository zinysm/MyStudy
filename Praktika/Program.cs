//Console.WriteLine("Įveskite tekstą");
//char[] symbols = Console.ReadLine().ToCharArray();
//symbols[0] = char.ToUpper(symbols[0]);
//Console.WriteLine(new string(symbols));

//string text;
//do
//{
//    Console.WriteLine("Įveskite tekstą ne trumpesni nei 10 symbolių");
//    text = Console.ReadLine();
//} while (text.Length < 10);
//char[] symbols = text.ToCharArray();
//symbols[1] = 'g';
//symbols[3] = 'b';
//symbols[5] = '*';
//symbols[7] = 'x';
//symbols[9] = 'w';
//Console.WriteLine(new string (symbols));
//string input;
//do
//{
//   Console.WriteLine("Įveskite 5 symbolių tekstą");
//   input = Console.ReadLine();
//} while (input.Length != 5);
//if (input.Length == 5)
//{
//    {
//        Console.WriteLine("Įveskite skaičių");
//        string number = Console.ReadLine();
//        char[] inputText = input.ToCharArray();
//        Console.WriteLine(new string (inputText[0]+number+ inputText[1] + number+ inputText[2] + number+ inputText[3] + inputText[4] + number));
//    }
//}

//Console.WriteLine("Įveskite tekstą");
//string input = Console.ReadLine();
//char[] symbols = input.ToCharArray();
//if (symbols[0] == char.ToUpper(symbols[0]))
//{
//    Console.WriteLine(input.ToUpper());
//}
//else
//{
//    Console.WriteLine(new string (char.ToUpper(symbols[0]) + input.Substring(1)));
//}

//Console.WriteLine("Įveskite tekstą");
//string input = Console.ReadLine();
//if (input.Count(x => x == 'a')>0)
//{
//    Console.WriteLine(input + " " + input.IndexOf('a'));
//}
//else
//{
//    Console.WriteLine("Simbolis a nerastas");
//}
//Console.WriteLine("Įveskite tekstą");
//string input = Console.ReadLine();
//if (input.Contains("labas"))
//{
//    Console.WriteLine(new string(input.Reverse().ToArray()));
//}
//else
//{
//    Console.WriteLine(input);
//}

