using System;

namespace WorkStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            //Recursos interessantes para strings
            string original = "ABCD abcd EFGH efgh ABCD";
            int str1 = original.IndexOf("A");
            int str2 = original.LastIndexOf("A");
            string str3 = original.Substring(3, 7);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
    }
}
