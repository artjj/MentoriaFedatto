using System;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = "Deuses da tecnologia que tudo conhecem e tudo sabem, digam-me: qual o nome do programador dessa aplicação?".ToCharArray();
            string rawContent = Console.ReadLine();
            ConsoleKey keysPressed;

            //if (( = ) == " ")
            //{
            //    Console.WriteLine($"{rawContent} - rawContent");
            //}


            for (int i = 0; i < rawContent.Length; i++)
            {
                Console.WriteLine(rawContent[i]);
            }
        }
    }
}
