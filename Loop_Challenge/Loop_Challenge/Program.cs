namespace Loop_Challenge
{
    internal class Program
    {
        /*
         Challenge:
            Imagine you are a developer and get a job in which you need to create a program for a teacher. 
            He needs a program written in c# that calculates the average score of his students. 
            So he wants to be able to enter each score individually and then get 
            the final average score once he enters -1.

            So the tool should check if the entry is a number and should add that to the sum. 
            Finally once he is done entering scores, the program should write onto the console 
            what the average score is.
            The numbers entered should only be between 0 and 20. 
            Make sure the program doesn't crash if the teacher enters an incorrect value.
            Test your program thoroughly.
        */
        static void Main(string[] args)
        {
            AverageScoreCalculator();
            Console.Read();
        }

        public static void AverageScoreCalculator()
        {
            double totalScore = 0;
            double averageScore;
            int numberOfEntries = 0;

            for (numberOfEntries = 0; numberOfEntries < 20;)
            {
                Console.WriteLine("\n \tEnter a student's score (or calculate average of already entered scores with -1):");
                string myScore = Console.ReadLine();

                if (myScore.Equals("-1"))
                {
                    if (numberOfEntries == 0)
                    {
                        Console.WriteLine("No score entered. Cannot calculate the average.");
                    }
                    else
                    {
                        averageScore = totalScore / numberOfEntries;

                        Console.WriteLine("\n.......................................................\n");

                        Console.WriteLine("Number of entries = {0}", numberOfEntries);
                        Console.WriteLine("Total scores entered = {0}", totalScore);

                        Console.WriteLine("AVERAGE SCORE = {0}\n", averageScore);
                    }
                    continue;
                }
                if (int.TryParse(myScore, out int score))
                {
                    totalScore += score; //Added score to running total
                    numberOfEntries++;

                    if (numberOfEntries == 20)
                    {
                        Console.WriteLine("You have exceeded the stipulate number of input (20 entries)");
                    }
                }

                else
                {
                    Console.WriteLine("'{0}' is invalid input.", myScore);
                    Console.WriteLine("Please enter a valid input.\n");
                }
            }
        }
    }
}