namespace ConsoleApp_Hosts_Test
{
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

            Console.WriteLine(string.Join("-", Solution.solution(A, B)));
            //Console.WriteLine(String.Join("-", Solution.solution1(A, B)));
        }
    }

    public class Solution
    {
        public static int[] solution(string[] A, string[] B)
        {
            var list = new HashSet<string>(A);
            foreach (var itemB in B)
            {
                list.RemoveWhere(x => x.EndsWith(itemB));
            }

            return Enumerable.Range(0, A.Length).Where(i => list.Contains(A[i])).ToArray();
        }

        //public static int[] solution1(string[] A, string[] B)
        //{
        //    if (B.Length == 0)
        //        return Enumerable.Range(0, A.Length).ToArray();
        //    if (A.Length == 0)
        //        return new int[0];

        //    var list = new HashSet<string>(A);
        //    foreach (var str in list)
        //    {
        //        foreach (var itemB in B)
        //        {
        //            if (str.EndsWith(itemB))
        //            {
        //                list.Remove(str);
        //                break;
        //            }
        //        }
        //    }

        //    return Enumerable.Range(0, A.Length).Where(i => list.Contains(A[i])).ToArray();
        //}
    }
}