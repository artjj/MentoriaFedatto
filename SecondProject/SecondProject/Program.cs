using System;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string questionStr = "Deuses da tecnologia que tudo conhecem e tudo sabem, digam-me: qual o nome do programador dessa aplicação?";

            string finalContent = null;
            ConsoleKeyInfo key;

            ConsoleKeyInfo firstContent = System.Console.ReadKey();

            if (firstContent.Key == ConsoleKey.Spacebar)
            {
                int index = 0;
                while (true)
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
            //if (( = ) == " ")
            //{
            //    Console.WriteLine($"{rawContent} - rawContent");
            //}

            //Console.WriteLine(password);
        }
    }
}
