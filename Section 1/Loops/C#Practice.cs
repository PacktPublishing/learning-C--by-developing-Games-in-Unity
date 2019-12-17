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
			//When writing code you may want a repeat action to take place without having to
			 //continuously write out the same logic over and over. Such things can become
			 //tedious and cost a lot of time
			//Loops help to fix this problem, they are designed to continuously do one type
			 //of operation and will stop when a certain conditiona is met
			//Here we will take a look at two kinds of loops, For and While 
			Console.Write("Please enter a number between 1 and 10 ");
			int userInput = Convert.ToInt32(Console.ReadLine());

			//While Loops
			//Here we will state the condition that WHILE a number we enter between
			 //1 and 10 is less than 10, then we will add one to that number and print
			 //out all results 
			
			// while (userInput < 10)
			// {
			// In here the logic is that once the loop has reached the condition we have provided it
			 //it will BREAK out of the loop. We will use the phrase "Process done" for this example
			//If the user enters in a number larger than 10 or less than 1 we will have the program just
			 //print out the words "process done" and break out of the loop since we
			 //do not want any numbers over 10 or under 1
				// userInput += 1;
				// Console.Write(userInput + "\n");
				// if (userInput > 10 || userInput < 1)
				// {
					// break;
				// }
			// }
			// Console.Write("Process Done");

			//For Loops
			//When using for loops we can specify a lot right in the beginning to determine
			 //what the loop will do while increasing each integer
			//Here we will define an integer called "i" which will we will store our userInput
			  //value in, then we will tell it that as long as i is the value of userInput and
			  //less than ten, keep adding 1 to it
			//similarly to our previous example, once the integers reach 10, the loop will break
			  //we will add another nested conditional to break automatically if the input value
			  //is more than 10 or less than 1 similarly to before 
			//You can now see that by using loops there is a lot less writing needed

			int i;
			for (i = userInput; i <= 10; i++)
			{
				Console.Write(i + "\n");
				if (userInput > 10 || userInput < 1)
				{
					break;
				}
			}
			Console.Write("Process Done");
		}

	}
}
