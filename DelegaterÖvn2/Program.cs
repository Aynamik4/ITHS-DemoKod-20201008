using System;

namespace DelegaterÖvn2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, bool> a = PrintIt;
            a("ItHs", true);
        }
         
        static void PrintIt(string s, bool b)
        {
            if(b)
                Console.WriteLine(s.ToUpper());
            else
                Console.WriteLine(s.ToLower());
        }
    }
}
