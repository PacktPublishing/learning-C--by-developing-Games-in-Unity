using System;
namespace Practice
{
  class OurProgram 
{
		//Classes are contained in Namespaces 
		//System is the namespace which contains the OurProgram class 
		//Namespaces allow for multiple classes with different names 
		//By combining the Namespace, the class, and the method, the program will
		 //figure out what method to call
		//Lets create the Practice namespace which will contain the OurProgram 
	      //class which will contain our Main method 
	    //You may not have to write name spaces, however it is a best practice, 
	    //If you specify a namespace you do not need to write it into your code
	      //by adding the System namespace we can take it off of our Console.Write
	      //line 
		static void Main()
		{
			CalcUserInput();
		}

		static void CalcUserInput()
		{
			Console.Write("Please enter a number to be added");
			int valueFive = 5;
			int userInput = Convert.ToInt32(Console.ReadLine());
			int result = valueFive + userInput;
			Console.Write("That number plus 5 is " + result);
		}

	}
}
