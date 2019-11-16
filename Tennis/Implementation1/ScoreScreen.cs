using System;

namespace Tennis.Implementation1
{
    public static class ScoreScreen
    {
        public static string Display(this TieScore score)
        {
            switch (score)
            {
                case TieScore.LoveAll:
                    return "Love-All";
                case TieScore.FifteenAll:
                    return "Fifteen-All";
                case TieScore.ThirtyAll:
                    return "Thirty-All";
                case TieScore.Deuce:
                    return "Deuce";
                default:
                    throw new Exception("Impossible state");
            }
        }

        public static string Display(this OnGoingScore score)
        {
            switch (score)
            {
                case OnGoingScore.Love:
                    return "Love";
                case OnGoingScore.Fifteen:
                    return "Fifteen";
                case OnGoingScore.Thirty:
                    return "Thirty";
                case OnGoingScore.Forty:
                    return "Forty";
                default:
                    throw new Exception("Impossible state");
            }
        }
    }
}