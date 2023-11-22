using static System.Formats.Asn1.AsnWriter;

namespace HighestScoreAndScorerChecker
{
    internal class Program
    {
        //Global Variables
        static int highScore = 300;
        static string highScoreHolder = "Amaechi";

        static void Main(string[] args)
        {
            /*
             Challenge 
             Create an application with a score, highScore and a highScorePlayer.
             Create a method which has two parameters, one for the score and one for the playerName.
             Whenever that method is called, it should be checked if the score of the player is higher than the highScore, if so, 
             New highScore and "New highScore holder is generated

             Tips: Consider which variables are required globally and which ones locally.
            */

            CheckHighScoreMethod1();
            CheckHighScoreMethod2(70, "Ola");
            CheckHighScoreMethod2(700, "Ndubuisi");
            CheckHighScoreMethod2(300, "Ife");
            CheckHighScoreMethod2(1000, "Uju");

            Console.Read();
        }

        //one way
        public static void CheckHighScoreMethod1()
        {
            int score;
            string player;

            Console.WriteLine("Please provide the following information: ");

            Console.WriteLine("Player's name: ");
            player = Console.ReadLine();

            Console.WriteLine("Player's Score: ");
            string myScore = Console.ReadLine();

            // if code when parsed is successful and the score is greater than highScore.
            if (int.TryParse(myScore, out score) && score > highScore)
            {
                highScore = score;
                highScoreHolder = player;

                Console.WriteLine("New highScore is: {0}...", highScore);
                Console.WriteLine("and the new high score holder is: {0}", highScoreHolder);
            }
            else
            {
                Console.WriteLine("The high score \"{0}\" is not yet broken\n", highScore);

                Console.WriteLine("High score remains {0} and\nHigh score holder remains {1}", highScore, highScoreHolder);

            }
        }

        //Another way
        public static void CheckHighScoreMethod2(int score1, string player1)
        {/*
            Console.WriteLine("\nHigh score check for {0}...\n", player1);

            // if code when parsed is successful and the score is greater than highScore.
            if (score1 > highScore)
            {
                highScore = score1;
                highScoreHolder = player1;

                Console.WriteLine("New highScore is: {0}...", highScore);

                Console.WriteLine("and the new high score holder is: {0}", highScoreHolder);

            }
            else
            {
                Console.WriteLine("The high score {0} is not yet broken\n", highScore);

                Console.WriteLine("The high score remains {0}...", highScore);
                Console.WriteLine("and the high score holder remains {0}\n", highScoreHolder);
            }*/
        }

    }
}