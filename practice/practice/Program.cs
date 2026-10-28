using practice.Strings;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static void Main()
    {

        // check is string is palindrome or not
        StringPalindrome sp = new StringPalindrome();
        sp.FindPalindrome();

        FindGroupAnagram();

        Console.Write("programm run from main method");
    }

    public static void FindGroupAnagram()
    {
        string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };

        StringGroupAnagrams sga = new StringGroupAnagrams();

        List<List<string>> grouped = sga.Find(words);

        foreach (var group in grouped)
        {
            Console.WriteLine("[" + string.Join(", ", group) + "]");
        }
    }
}


