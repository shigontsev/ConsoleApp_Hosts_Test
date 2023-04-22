using System;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string[] A = new[]
        {
            "unlock.microvirus.md",
            "visitwar.com",
            "visitwar.de",
            "visitwar.de.visitwar.de",
            "fruonline.co.uk",
            "australia.open.com",
            "credit.card.us",
            "credit.card.us",
            //"unlock.microvirus.md",
            //"visitwar.com",
            //"visitwar.de",
            //"visitwar.de.visitwar.de",
            //"fruonline.co.uk",
            //"australia.open.com",
            //"credit.card.us",
            //"unlock.microvirus.md",
            //"visitwar.com",
            //"visitwar.de",
            //"visitwar.de.visitwar.de",
            //"fruonline.co.uk",
            //"australia.open.com",
            //"credit.card.us",
            //"unlock.microvirus.md",
            //"visitwar.com",
            //"visitwar.de",
            //"visitwar.de.visitwar.de",
            //"fruonline.co.uk",
            //"australia.open.com",
            //"credit.card.us",
            //"unlock.microvirus.md",
            //"visitwar.com",
            //"visitwar.de",
            //"visitwar.de.visitwar.de",
            //"fruonline.co.uk",
            //"australia.open.com",
            //"credit.card.us"
        };
        string[] B = new[]
        {
            "microvirus.md",
            "visitwar.de",
            "piratebay.co.uk",
            "list.stolen.credit.card.us",
        };
        DateTime dateTime = DateTime.Now;
        Console.WriteLine(String.Join("-", Solution.solution(A, B)));
        Console.WriteLine(DateTime.Now - dateTime);
        dateTime = DateTime.Now;
        Console.WriteLine(String.Join("-", Solution.solution1(A, B)));
        Console.WriteLine(DateTime.Now - dateTime);
        dateTime = DateTime.Now;
        Console.WriteLine(String.Join("-", Solution.solution2(A, B)));
        Console.WriteLine(DateTime.Now - dateTime);
        dateTime = DateTime.Now;
        Console.WriteLine(String.Join("-", Solution.solution3(A, B)));
        Console.WriteLine(DateTime.Now - dateTime);
    }
}

class Solution 
{ 
    public static int[] solution(string[] A, string[] B)
    {
        var list = Enumerable.Range(0, A.Length).ToList();
        foreach (var itemB in B)
        {
            var pattern = $"^[\\w\\.]*{itemB}$";
            for (var i = list.Count - 1; i >= 0; i--)
            {
                if (Regex.IsMatch(A[list[i]], pattern))
                {
                    list.RemoveAt(i);
                }
            }
        }

        return list.ToArray();
    }

    public static int[] solution1(string[] A, string[] B)
    {
        var list = new List<string>(A);
        foreach (var itemB in B)
        {
            list.RemoveAll(x => x.EndsWith(itemB));
        }

        return Enumerable.Range(0, A.Length).Where(i => list.Contains(A[i])).ToArray();
        //return list.Select(x => Array.IndexOf(A, x)).ToArray();
    }

    public static int[] solution2(string[] A, string[] B)
    {
        var list = new HashSet<string>(A);
        foreach (var itemB in B)
        {
            list.RemoveWhere(x => x.EndsWith(itemB));
        }

        return Enumerable.Range(0, A.Length).Where(i => list.Contains(A[i])).ToArray();
        //return list.Select(x => Array.IndexOf(A, x)).ToArray();
    }

    public static int[] solution3(string[] A, string[] B)
    {
        var list = new HashSet<string>(A);
        foreach (var str in list)
        {
            foreach (var itemB in B)
            {
                if (str.EndsWith(itemB))
                {
                    list.Remove(str);
                    break;
                }
            }
        }

        //return list.Select(x => Array.IndexOf(A, x)).ToArray();
        return Enumerable.Range(0, A.Length).Where(i => list.Contains(A[i])).ToArray();
    }
}