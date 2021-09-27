using System;
using System.Text;

namespace ReverseWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordUnreversed = Console.ReadLine();
            var wordCharArray = wordUnreversed.ToCharArray();
            Array.Reverse(wordCharArray);

            var wordReversed = new String(wordCharArray);

            Console.WriteLine(wordReversed.ToString());
        }
    }
}
