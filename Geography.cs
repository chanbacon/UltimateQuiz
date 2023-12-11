using System;

namespace UltimateQuiz
{
    class Geography
    {
        private string[] geographyQuestions =
            {
            "How many countries does Estonia border? [Enter a number]",
            "What is the biggest country in South America?",
            "What is the capital of Australia?"
            };
        private string[] geographyAnswers =
            {
            "4",
            "Brazil",
            "Canberra"
            };
        public int Score { get; set; }
        public bool Joker { get; set; }               

        public Geography(bool joker) { 
            Score = 0;
            Joker = joker;
        }

        public int StartQuiz()
        {
            Console.WriteLine("***Geography***");
            for (int i = 0; i < geographyQuestions.Length; i++)
            {
                Console.Write($"Q{i + 1}. {geographyQuestions[i]} ");
                string answer = Console.ReadLine();
                if (answer.Trim().ToLower() == geographyAnswers[i].ToLower())
                {
                    Console.WriteLine("Correct!\n");
                    Score++;
                }
                else
                {
                    Console.WriteLine("Oh... that is not correct.");
                    Console.WriteLine($"The correct answer is {geographyAnswers[i]}\n");
                }
            }
            if (Joker == true)
            {
                return Score * 2;
            }
            else
            {
                return Score;
            }
        }
    }
}