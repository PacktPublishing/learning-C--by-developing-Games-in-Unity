using System;
namespace Practice
{
  class OurProgram 
{
		static void Main()
		{
			CalcUserInput();
		}

		static void CalcUserInput()
		{
			//IF/ELSE
			//Lets give our small app some logic by adding in some conditional statements
			 //A conditional directs which code to run depending on a specific out come
			//Here we will set up an if/else statement which will print a different output
			  //depending on the integer passed
			// Console.Write("Please enter a number between 1 and 10 ");
			// int userInput = Convert.ToInt32(Console.ReadLine());
			// //we use && for and, as well as || for or 
			// if (userInput >= 1 && userInput <= 5)
			// {
			// 	Console.Write("That number is between 1 and 5");
			// }
			// else 
			// {
			// 	Console.Write("That number is greater than 5");
			// }

			//IF/ELSEIF/ELSE
			//If we want to add a bit more logic to our application, we can add
			  //an else if statement in between the if and the else. It is also 
			  //possible to end a conditional with an else if statement 
			// Console.Write("Please enter a number between 1 and 10 ");
			// int userInput = Convert.ToInt32(Console.ReadLine());
			// if (userInput > 1 && userInput < 5)
			// {
			// 	Console.Write("That number is between 1 and 5");
			// }
			// else if (userInput > 5 && userInput < 10)
			// {
			// 	Console.Write("That number is between 5 and 10");
			// }
			// else 
			// {
			// 	Console.Write("That number is 1, 5, or 10");
			// }

			//BOOLEANS
			//another way we can set up conditional logic is by using Booleans
			//Booleans can be either a true of false value and can trigger certain
			  //logic in a conditional 
			//Lets create a boolean that will be set to false, if a number is more than
			 //10 or less than 1 then it will trigger the conditional to switch to true
			 //well add one more else if statement that will respond if the boolean is true
			 //we will then use a "nested conditional" inside that new else if to print 
			 //something else to the console 
			bool outOfRange = false; 
			Console.Write("Please enter a number between 1 and 10 ");
			int userInput = Convert.ToInt32(Console.ReadLine());
			if (userInput > 1 && userInput < 5)
			{
				Console.Write("That number is between 1 and 5");
			}
			else if (userInput > 5 && userInput < 10)
			{
				Console.Write("That number is between 5 and 10");
			}
			else if (userInput < 1 || userInput > 10)
			{
				outOfRange = true;
				if (outOfRange == true)
				{
					Console.Write("That number is out of the range");
				}
			}
			else 
			{
				Console.Write("That number is 1, 5, or 10");
			}
		}

	}
}
