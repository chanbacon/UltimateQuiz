using System;

namespace UltimateQuiz
{ 
    class Player
    {
        public int bScore;
        public int gScore;
        public int sScore;
        public int totalScore;

        public string Name { get; private set; }
        public string JokerCategory {  get; private set; }

        public Player(string name, string jokerCategory)
        {
            Name = name;
            JokerCategory = jokerCategory;
            bScore = 0;
            gScore = 0;
            sScore = 0;
            totalScore = 0;
        }

        public int StartBiologyQuiz(bool joker)
        {
            Biology b = new Biology(joker);
            return bScore += b.StartQuiz();
        }

        public int StartGeographyQuiz(bool joker)
        {
            Geography g = new Geography(joker);
            return gScore += g.StartQuiz();
        }

        public int StartSportsQuiz(bool joker)
        {
            Sports s = new Sports(joker);
            return sScore += s.StartQuiz();
        }
    }
}
