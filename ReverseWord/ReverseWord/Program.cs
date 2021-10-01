using System;
using System.Text;

namespace ReverseWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawContent = args[0].ToString();
            char[] wordCharArray = rawContent.ToCharArray();
            Array.Reverse(wordCharArray);


            string finalContent = new String(wordCharArray);

            Console.WriteLine(finalContent.ToString());
        }
    }
}
