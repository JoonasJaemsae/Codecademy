using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            //Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            //string entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            // Type your code below
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            Console.ReadLine();

            string[] questions = {
                "Eggplant is a type of berry.",
                "The events of the famous novel 1984 take place in 2023.",
                "The name of the programming language that is more comfortable to manipulate strings in than C# is called C."
            };
            bool[] answers = { true, false, true };
            RunQuiz(questions, answers);
            Console.ReadLine();
        }

        static void RunQuiz(string[] questions, bool[] answers)
        {
            bool[] responses = new bool[questions.Length];
            int askingIndex = 0;

            if (questions.Length != responses.Length)
            {
                Console.WriteLine("Length mismatch! Abort mission.");
            }

            foreach (string question in questions)
            {
                string input;
                bool isBool = true;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or false?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool userResponse = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {userResponse} | Answer: {answer}");
                if (userResponse == answer)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }
    }
}
