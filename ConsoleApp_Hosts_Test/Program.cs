using ConsoleApp_Hosts_Test;
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

        Console.WriteLine(String.Join("-", Solution.solution(A, B)));
        //Console.WriteLine(String.Join("-", Solution.solution1(A, B)));
    }
}