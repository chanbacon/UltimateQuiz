using System;

namespace UltimateQuiz
{
    class Sports
    {
        private string[] sportsQuestions =
            {
            "Which country won the latest women's football World Cup?",
            "What is the first name of the current F1 champion driver?",
            "How many stages were there in 2023 tour de France? [Enter a number]"
            };
        private string[] sportsAnswers =
            {
            "Spain",
            "Max",
            "21"
            };

        public int Score { get; set; }
        public bool Joker { get; set; }

        public Sports(bool joker)
        {
            Score = 0;
            Joker = joker;
        }

        public int StartQuiz()
        {
            Console.WriteLine("***Sports***");
            for (int i = 0; i < sportsQuestions.Length; i++)
            {
                Console.Write($"Q{i + 1}. {sportsQuestions[i]} ");
                string answer = Console.ReadLine();
                if (answer.Trim().ToLower() == sportsAnswers[i].ToLower())
                {
                    Console.WriteLine("Correct!\n");
                    Score++;
                }
                else
                {
                    Console.WriteLine("Oh... that is not correct.");
                    Console.WriteLine($"The correct answer is {sportsAnswers[i]}\n");
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

