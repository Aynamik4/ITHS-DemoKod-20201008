using System;

namespace DelegateDemo2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Tilldela variabeln a av typen Action<string> metoden MyParameterAction.
            Action<string> a = MyParameterAction;

            // Anropa metoden som variabeln a tilldelats.
            a("ITHS Rules!");
        }

        static void MyParameterAction(string s)
        {
            Console.WriteLine(s);
        }
    }
}
