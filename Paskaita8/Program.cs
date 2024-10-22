/////////////////////8 pamoka//////////////////////////////////UNIT TESTING
///

int lenght = Methods.GetTextLength("  test  ");
Console.WriteLine(lenght);
public static class Methods
{
    public static int GetTextLength(string text, bool includeLeadSpace = false, string some = "")
    {
        if (!includeLeadSpace)
        {
            return text.Trim().Length;
        }
        else
            return text.Length;
       
    }
}



