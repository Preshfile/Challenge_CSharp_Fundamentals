namespace Ternary_Operator_Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Challenge:
              create a small application that takes a temperature value as input and checks if the input is an integer or not.
              If the input value is not an integer value, it should print  an error message to the console
              And if the input value is the valid integer then it should work as mentioned below:
              If input temperature value is <=15 it should write "it is too cold here" to the console.
              If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.
              If the input temperature value is > 28 it should write "it is hot here" to the console.
              
              Make sure to use ternary operators and not if statements to check for the three conditions, 
              however you can use if statement for the other conditions like to check if the entered value is a valid integer or not.
          */

            TemperatureCheck();
        }
        public static void TemperatureCheck()
        {
            Console.WriteLine("What is your temperature?");
            string valueOfTemperature = Console.ReadLine();

            if (int.TryParse(valueOfTemperature, out int temperatureValue))
            {
                //Conditional ternary operator with multiple cases
                string temperature = temperatureValue <= 15 ? "It is too cold where you are" :
                temperatureValue >= 16 && temperatureValue <= 28 ? "It is okay where you are" :
                "it is hot where you are";

                Console.WriteLine(temperature);
            }
            else
            {
                Console.WriteLine("Not a valid temperature value");
            }
        }
    }
}