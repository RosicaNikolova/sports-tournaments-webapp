using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Business
{
    public class BadmintonSportType : ISportType
    {
        public string ErrorMessage { get; set; }

        public bool CheckResults(Game game)
        {
            int result1 = game.Result1;
            int result2 = game.Result2;
            int difference = Math.Abs(result1 - result2);

            if (result1 < 0 || result2 < 0)
            {
                ErrorMessage = "Scores are less than 0";
                return false;
                //return "A player cannot have negative points.";
            }
            else if (result1 == 20 && result2 == 20)
            {
                ErrorMessage = "Scores cannot be 20-20. Players should continue playing until two-points difference or until someone reaches 30 points";
                return false;

                //return "Not a valid score. If the score reaches 20-20, it is played until a two-point difference or until someone reaches 30 points.";
            }
            else if (result1 == 30 && result2 == 30)
            {
                ErrorMessage = "Scores cannot be 30-30";
                return false;

                //return "Not a valid score.";
            }
            else if ((result1 < 21 && result2 < 21) || (result1 > 30 || result2 > 30))
            {
                ErrorMessage = "Game is played until one of the players reaches 21 points";
                return false;

               // return "Not a valid score. Games are played until 21 points if a draw at 20 is not reached.";
            }
            else if ((result1 == 21 && result2 == 20) || (result1 == 20 && result2 == 21))
            {
                ErrorMessage = "There must be at least 2 points difference";
                return false;
                //return "Not a valid score. At a point the score was 20-20, which means the match must continue until there is a two-point difference or someone reaches 30 points.";
            }
            else if (result1 > 20 && result2 > 20 && difference > 2 && result1 < 30 && result2 < 30)
            {
                ErrorMessage = "Game should have been played up to 2 points difference or 30 points";
                return false;
               // return "Not a valid score. The match should have been played up to a two-point difference or 30 points.";
            }
            else if (result1 > 20 && result2 > 20 && difference < 2 && result1 < 30 && result2 < 30)
            {
                ErrorMessage = "Game should be played up to 2 points difference";
                return false;
                //return "Not a valid score. The match should have been played up to a two-point difference or 30 points.";
            }
            else if ((result1 == 30 && difference > 2) || (result2 == 30 && difference > 2))
            {
                ErrorMessage = "Game should have been played up to 2 points difference";
                return false;
                //return "Not a valid score. The match should have been played up to a two-point difference.";
            }
            else if (result1 > 20 && result2 > 20 && difference == 2 && result1 < 30 && result2 < 30)
            {
                return true;
           
            }
            else if ((result1 == 30 && difference <= 2) || (result2 == 30 && difference <= 2))
            {
                return true;
            
            }
            else if ((result1 == 21 && result2 < 20) || (result1 < 20 && result2 == 21))
            {
                return true;
           
            }

            return true;
        }

        public string GetErrorMessage()
        {
            return this.ErrorMessage;
        }

        public override string ToString()
        {
            return "Badminton";
        }
    }
}
