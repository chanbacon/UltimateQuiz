// this is a fun quiz that tests your general knowledge

using System;
using System.Diagnostics.Metrics;
using System.Security.Authentication;

namespace UltimateQuiz
{
    class Program
    {
        //this method introduces the quiz
        public static void Introduction()
        {
            Console.WriteLine("Hello! Welcome to the Ultimate Quiz");
            Console.Write("where you can prove that you are smarter than your colleague! (press 'Enter' to continue)");
            Console.ReadLine();
            Console.WriteLine("There are 3 categories: geography, sports and biology");
            Console.WriteLine("with 3 questions in each category.");
            Console.WriteLine("You can use 'Joker' on one category to " +
                "double the score. (press 'Enter' to continue)");
            Console.ReadLine();
        }

        //this method prompt user to input name
        public static string GetName()
        {
            Console.Write("Enter your name to start the quiz: ");
            string input = Console.ReadLine();
            //make sure the input is not blank
            while (input == "")
            {
                Console.Write("Please don't leave it blank. ");
                Console.Write("Enter your name to start the quiz: ");
                input = Console.ReadLine();
            }
            Console.WriteLine($"\nHi, {input}! You seem to have a clever name! " +
                $"(press 'Enter' to continue)");
            Console.ReadLine();
            return input;
        }

        //this method prompt user to indicate where to use 'Joker'
        public static string GetJoker()
        {
            Console.WriteLine("In which category are you using your 'Joker'?");
            Console.Write("Enter '1' for geography, '2', for biology, '3' for sports: ");
            string input = Console.ReadLine();
            //ensure valid input
            while (!(input == "1" || input == "2" || input == "3")) 
            {
                Console.Write("Enter '1' for geography, '2', for biology, '3' for sports: ");
                input = Console.ReadLine();
            }
            //convert the number to category
            switch (input)
            {
                case "1":
                    input = "geography";
                    break;
                case "2":
                    input = "biology";
                    break;
                case "3":
                    input = "sports";
                    break;
            }
            Console.WriteLine($"You put 'Joker' on {input}. Good choice!");
            Console.WriteLine("Let's start! (press 'Enter' to continue)");
            Console.ReadLine();
            return input;     
        }

        //this method starts the quiz
        public static void StartQuiz(Player player)
        {
            //initiate the quiz differently depending on where 'Joker' is
            switch (player.JokerCategory)
            {
                case "geography":
                    player.StartGeographyQuiz(true);
                    player.StartBiologyQuiz(false);
                    player.StartSportsQuiz(false);
                    break;
                case "biology":
                    player.StartGeographyQuiz(false);
                    player.StartBiologyQuiz(true);
                    player.StartSportsQuiz(false);
                    break;
                case "sports":
                    player.StartGeographyQuiz(false);
                    player.StartBiologyQuiz(false);
                    player.StartSportsQuiz(true);
                    break;
            }
        }

        //this method diplay the results of individual player
        public static void DisplayResults(Player player)
        {
            Console.WriteLine("That was the end. Let's see your score (press 'Enter' to continue)");
            Console.ReadLine();
            Console.WriteLine($"{player.Name}'s Results");
            Console.WriteLine("==========================");
            Console.WriteLine($"Joker used in {player.JokerCategory}");
            Console.WriteLine($"Geography: {player.gScore}");
            Console.WriteLine($"Biology: {player.bScore}");
            Console.WriteLine($"Sports: {player.sScore}");
            player.totalScore = player.gScore + player.bScore + player.sScore;
            Console.WriteLine($"Total score: {player.totalScore}\n");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
        }

        //this method prompts user to invite a colleague to take the quiz
        public static void InviteColleague()
        {
            Console.WriteLine("You did great!");
            Console.WriteLine("Now, invite a colleague nearby to take the quiz!" +
                "(press 'Enter' to continue)");
            Console.ReadLine();
            try
            {
                Console.Clear();
            }
            catch
            {
            }
            Console.WriteLine("Press 'Enter' when your colleague is here.");
            Console.ReadLine();
        }

        //this method compare the results of the two players
        public static void CompareResults(Player p1, Player p2)
        {
            Console.Write("Are you ready for the final result!?".ToUpper());
            Console.WriteLine(" (press 'Enter' to continue)");
            Console.ReadLine();
            if (p1.totalScore > p2.totalScore)
            {
                Console.WriteLine($"{p1.Name} is smarter than {p2.Name}!!!".ToUpper());
            } 
            else if (p1.totalScore < p2.totalScore)
            {
                Console.WriteLine($"{p2.Name} is smarter than {p1.Name}!!!".ToUpper());
            }
            else
            {
                Console.WriteLine($"{p1.Name} and {p2.Name} are equally smart!!!".ToUpper());
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            //Player 1: 
            Introduction();
            string p1Name = GetName();
            string p1Joker = GetJoker();
            Player p1 = new Player(p1Name, p1Joker);
            StartQuiz(p1);
            DisplayResults(p1);
            InviteColleague();       
            
            //Player 2:
            Introduction();
            string p2Name = GetName();
            string p2Joker = GetJoker();
            Player p2 = new Player(p2Name, p2Joker);
            StartQuiz(p2);
            DisplayResults(p2);

            CompareResults(p1, p2);
        }
    }
}
