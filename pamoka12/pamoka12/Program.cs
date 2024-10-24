//Paskaitos sablonai

//int [] emptyArray = new int [10];
//int[] arrayWithInitialValues = { 1, 2, 3, 88, 105, 999 };

//Console.WriteLine(emptyArray[5]);

//arrayWithInitialValues[4] = 23;

//string[] sentences = { "abc", "text", "random" };
//for (int i = 0; i < sentences.Length; i++)
//{
//    Console.WriteLine(sentences[i]);
//}

//for(int i = 0; i <emptyArray.Length; i++)
//{
//    emptyArray[i] = i * i;
//    Console.WriteLine(emptyArray[i]);
//}

// Uzduotys 1.1


//for (int i = 0; i < arrayWithInitialValues.Length; i++)
//{
//    arrayWithInitialValues[i] = arrayWithInitialValues[i] * arrayWithInitialValues[i];
//}
//Console.WriteLine("{" + arrayWithInitialValues[0] + "," + arrayWithInitialValues[1] + "," + arrayWithInitialValues[2] + "," + arrayWithInitialValues[3] + "," + arrayWithInitialValues[4] + "," + arrayWithInitialValues[5] + "");

//int [] numbers = { 5, 2, 3, 10 , 6, 9 };
////int [] results = Methods.RoundNumber(numbers);
//int [] resultsReverse = Methods.Reverse(numbers);
////int total = Methods.TotalSum(numbers);
//int max = Methods.MaxNumber(numbers);
////Console.WriteLine(total);
//Console.WriteLine(max);
//Methods.ResultPrint(resultsReverse);
string word = "labas";
char [] chars = Methods.CharsArray(word);
Methods.ResultPrint(chars); 

public static class Methods
{
    
    public static int[] RoundNumber(int[] numbers)
    {

        int[] results = new int[numbers.Length]; 
        for (int i = 0; i < numbers.Length; i++)
        {
            results[i] = numbers[i] * numbers[i];
           
        }
        return results;
    }
    public static void ResultPrint(char[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    public static int TotalSum(int[] numbers)
    {

        int result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            
            result = result + numbers[i];

        }
        return result;
    }
    public static int MaxNumber(int[] numbers)
    {
        int result = 0;     
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > result)
            {
                result = numbers[i];
            }
                       

        }
        return result;
    }
    public static int[] Reverse(int[] numbers)
    {
        int j = numbers.Length-1;
        int[] results = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
          results[i] = numbers[numbers.Length - i-1];
        }
        return results;
    }
    public static char[] CharsArray(string word)
    {
        char[] chars = word.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = chars[i];
        }
        return chars;
    }
}


    