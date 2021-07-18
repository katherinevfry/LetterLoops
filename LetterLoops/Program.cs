using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type something!!");
            var userInput = Console.ReadLine().ToLower();

            int loopNumber = 0;
            string output = "";
             
            for (var i = 0; i < userInput.Length; i ++)
            {
               loopNumber++;
                for (var j = 0; j < loopNumber; j++)
                {
                   if (j == 0 && i > 0)
                    {
                        var letterZero = char.ToUpper(userInput[i]);
                        output += $"-{letterZero}";
                    }
                   else
                    {
                        output += $"{userInput[i]}";
                    }
                }
                
            }

            Console.WriteLine($"{output}");

        }
    }
}
