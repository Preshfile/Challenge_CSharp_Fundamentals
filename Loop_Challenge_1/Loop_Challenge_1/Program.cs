namespace Loop_Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a student counter...
            //that increments each time an enter is pressed

            StudentCounter();
        }
        public static void StudentCounter()
        {
            int count = 0;
            string enteredText = "";

            while (enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to continue the count or press any letter to exit");
                enteredText = Console.ReadLine();

                count++;
                Console.WriteLine("current student count is {0}", count);
            }
            Console.WriteLine("\n{0} number of students were counted", count);
        }
    }
}