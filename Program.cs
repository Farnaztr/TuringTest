using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Human_Check
{
    class Program
    {
        static void type(string typing, int delay = 20)
        {

            foreach (char message in typing)
            {
                Console.Write(message);
                Thread.Sleep(delay);
            }
        }
        static void Draw(string question)
        {
            Console.WriteLine("      O");
            Console.WriteLine("     /|>───►"+question);
            Console.WriteLine("     / \\");
         
        }
        static void Main(string[] args)
        {
           
                
            
            Console.ForegroundColor = ConsoleColor.Cyan;


            string[] lines = {
    "╔══════════════════════════════════════════════════════════╗",
    "║                    WELCOME TO HUMAN-CHECK                ║",
    "║                                                          ║",
    "║      In a world where AIs learn to mimic emotions and    ║",
    "║      humans hide behind screens, your task is simple:    ║",
    "║                                                          ║",
    "║                     Spot the human.                      ║",
    "║                                                          ║",
    "║      Each response you see might come from a person...   ║",
    "║      or a machine trained to deceive.                    ║",
    "║                                                          ║",
    "║      Choose wisely. Fail the test, and the cost won't    ║",
    "║      just be artificial...                               ║",
    "║                                                          ║",
    "║                    Good luck, observer.                  ║",
    "╚══════════════════════════════════════════════════════════╝"
};


            int consoleWidth = Console.WindowWidth;


            if (consoleWidth < 50)
            {
                Console.WriteLine("Please widen the console window for better display.");
            }
            else
            {
                foreach (string line in lines)
                {
                    int spaces = (consoleWidth - line.Length) / 2;
                    if (spaces < 0) spaces = 0;
                    Console.WriteLine(new string(' ', spaces) + line);
                }
            }
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\t\t\t\t\t\tpress 'Enter' to continue.");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
            Console.Clear();

            int score = 0;
            Console.ForegroundColor = ConsoleColor.Gray;

            Draw("Question 1:");
            Console.ForegroundColor = ConsoleColor.Red;

            type("\r\nA: I miss the way the sunlight used to hit my window at 5 PM. It felt like home.\r\nB: Environmental light patterns are recorded and used to simulate comfort in virtual settings.\r\n\r\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            type("Which one is more likely to be human? (A/B):");
            char input = char.Parse(Console.ReadLine().ToLower().Trim());
            if (input == 'a')
            {
                score++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPerfect!Correct.");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (input == 'b')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n!inCorrect!");
                Thread.Sleep(2000);
                Console.Clear();   
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nplease next time choose from the options.");
                Thread.Sleep(2000);
                Console.Clear();

            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Draw("Question 2:");
            Console.ForegroundColor = ConsoleColor.Red;
            type("A: I encountered a runtime error but managed to fix it using exception handling techniques.\r\nB: I almost cried when I thought I’d lost my entire project, but then it compiled.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            type("\n\nWhich one is more likely to be human? (A/B):");
            char input2 = char.Parse(Console.ReadLine().ToLower().Trim());
            if (input2 == 'b')
            {
                score++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPerfect!Correct.");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (input2 == 'a')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n!inCorrect!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nplease next time choose from the options.");
                Thread.Sleep(2000);
                Console.Clear();

            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Draw("Question 3:");
            Console.ForegroundColor = ConsoleColor.Red;
            type("A: Sometimes, I just stare at the stars and wonder if someone’s doing the same, thinking of me.\r\nB: The cosmos is vast and observing it often leads to increased philosophical thought.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            type("\n\nWhich one is more likely to be human? (A/B):");
            char input3 = char.Parse(Console.ReadLine().ToLower().Trim());
            if (input3 == 'a')
            {
                score++;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPerfect!Correct.");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (input3 == 'b')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n!inCorrect!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nplease next time choose from the options.");
                Thread.Sleep(2000);
                Console.Clear();

            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Draw("Question 4:");
            Console.ForegroundColor = ConsoleColor.Red;
            type("A: Hunger detected. Initiating food protocol: locate, acquire, consume.\r\nB: Ugh, I’m starving. I could literally eat a pizza the size of my head.\r\n\r\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            type("\nWhich one is more likely to be human? (A/B):");
            char input4 = char.Parse(Console.ReadLine().ToLower().Trim());
            if (input4 == 'b')
            {
                score++;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPerfect!Correct.");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (input4 == 'a')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n!inCorrect!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nplease next time choose from the options.");
                Thread.Sleep(2000);
                Console.Clear();

            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Draw("Question 5:");
            Console.ForegroundColor = ConsoleColor.Red;
            type("A: Failure is not optimal. Data indicates a need to improve performance metrics.\r\nB: I failed again today. But maybe tomorrow... maybe I’ll get it right.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            type("\n\nWhich one is more likely to be human? (A/B):");
            char input5 = char.Parse(Console.ReadLine().ToLower().Trim());
            if (input5 == 'b')
            {
                score++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPerfect!Correct.");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (input5 == 'a')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n!inCorrect!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nplease next time choose from the options.");
                Thread.Sleep(2000);
                Console.Clear();

            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\nYour final score: " + score + " out of 5.\n");
            Thread.Sleep(1000);

            if (score == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                type("\n Wow! You got all 5 correct.");
                type("You just passed a mini Turing Test — great human instincts!");
            }
            else if (score >= 3&&score<=4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                type($"\n Not bad! You scored {score} out of 5.");
                type("You're pretty good at spotting humans from machines.");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                type($"\n You scored {score} out of 5.");
                type("The AI got the better of you this time.");
                type("Even the Turing Test can be tricky — keep practicing!");
            }

            Console.ReadKey();

        }
    }
}


