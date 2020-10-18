using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

			//read user input and
			//split the input into an array
			string[] inputArray = getUserInput().Split('+');

			//print the result
			try
			{
				Console.WriteLine("your result is: "+add(inputArray[0], inputArray[1]));
			}
			catch {
				Console.WriteLine("Enter only numbers in format x+y");
			}
			
		}

		static int add(String x , String y)
        {
			int num1, num2;

			//convert the string into int
			num1 = Convert.ToInt32(x);
			num2 = Convert.ToInt32(y);
			return num1 + num2;
        }

		static string getUserInput()
        {
			//get user input 
			Console.WriteLine("Enter your problem in format x+y");
			return Console.ReadLine();
		}
    }
}
