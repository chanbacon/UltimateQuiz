using System;

namespace UltimateQuiz
{
    class Biology
    {
        private string[] biologyQuestions =
            {
            "How many legs do a termite have? [Enter a number]",
            "What is the biggest animal ever existed?",
            "What is the full name of T-Rex?",
            };
        private string[] biologyAnswers =
            {
            "6",
            "blue whale",
            "tyrannosaurus rex",
            };
        public int Score { get; set; }
        public bool Joker { get; set; }

        public Biology(bool joker)
        {
            Score = 0;
            Joker = joker;
        }

        public int StartQuiz()
        {
            Console.WriteLine("***Biology***");
            for (int i = 0; i < biologyQuestions.Length; i++)
            {
                Console.Write($"Q{i+1}. {biologyQuestions[i]} ");
                string answer = Console.ReadLine();
                if (answer.Trim().ToLower() == biologyAnswers[i].ToLower())
                {
                    Console.WriteLine("Correct!\n");
                    Score++;
                }
                else
                {
                    Console.WriteLine("Oh... that is not correct.");
                    Console.WriteLine($"The correct answer is {biologyAnswers[i]}\n");
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

