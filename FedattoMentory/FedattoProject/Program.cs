using System;
using System.Text;

namespace FedattoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string rawContent = args[0].ToString();
            //char[] wordCharArray = rawContent.ToCharArray();
            //Array.Reverse(wordCharArray);


            //string finalContent = new String(wordCharArray);

            //Console.WriteLine(finalContent.ToString());


            string questionStr = "Deuses da tecnologia que tudo conhecem e tudo sabem, digam-me: qual o nome do programador dessa aplicação?";

            string finalContent = null;

            ConsoleKeyInfo key;

            ConsoleKeyInfo firstContent = System.Console.ReadKey();

            if (firstContent.Key == ConsoleKey.Spacebar)
            {
                int index = 0;
                while (true && index < questionStr.Length)
                {
                    key = System.Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                        break;
                    finalContent += key.KeyChar;
                    Console.Write(questionStr[index]);
                    index++;
                }
                Console.Read();
            }
            else
            {
                finalContent = firstContent.KeyChar.ToString();
                while (true)
                {
                    key = System.Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                        break;
                    finalContent += key.KeyChar.ToString();

                }

                Console.WriteLine(finalContent);
            }

            Console.WriteLine(finalContent);
        }
    }
}
