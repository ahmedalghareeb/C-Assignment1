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
				Console.WriteLine("your result is: " + add(inputArray));
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
				Console.WriteLine("Enter only numbers in format x+y");
			}
			
		}

		static int add(string[] stringArray)
        {
			int result = 0;
			foreach (string stringNum in stringArray) 
				result = result + Convert.ToInt32(stringNum);
			return result;
        }

		static string getUserInput()
        {
			//get user input 
			Console.WriteLine("Enter your problem in format x+y+...+n");
			return Console.ReadLine();
		}
    }
}
