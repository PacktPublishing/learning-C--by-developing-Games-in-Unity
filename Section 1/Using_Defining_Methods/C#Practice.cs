class OurProgram 
{
		static void Main()
		{
			//As explained in the first video we can create new methods that we may name 
			 //anything we wish. This is a great way to keep our code organized and readible
			//We will create a calculate method and then call it in our Main method
			//As long as we call the Calculate method in the Main method, we can compile and run
			 //the program 
			// Calculate();

			//User Input Calc
			// CalcUserInput();

			//User Input Calc With Params
			System.Console.Write("Please enter a number to be added");
			string userInput = System.Console.ReadLine();
			CalcUserInputParams(userInput);
		}

		// static void Calculate()
		// {
		// 	int valueOne = 2;
		// 	int valueTwo = 3;
		// 	int result;

		// 	result = valueOne + valueTwo;

		// 	System.Console.Write(result);
		// }

		// static void CalcUserInput()
		// {
			//Lets create a small terminal app...here the user will enter a number
			 //and the terminal will print the number added to 5 out with text 
			//We can use an out of the box method on the user input in order to 
			 //convert the string interger to the type integer. We will then add
			 //that number to 5 
			//You may notice that Console.Write cannot convert an integer to a string
			  //in this case we will need to call the Convert.ToInt32 method on Console
			  //.ReadLine in order to convert an integer from a string to an int type
			 //We will also need to specify user input as type int this time as well
			// System.Console.Write("Please enter a number to be added");
			// int valueFive = 5;
			// int userInput = System.Convert.ToInt32(System.Console.ReadLine());
			// int result = valueFive + userInput;
			// System.Console.Write("That number plus 5 is " + result);
		// }

		static void CalcUserInputParams(string userParams)
		{
			//One other way we could have done this calculation from user input is with
			  //Parameters 
			//As mentioned in the first video, parameters a certin type of data that 
			 //the method will be looking for to be provided 
			//Here we will add a string of userParams which will be the integer the user
			 //types in
			//We will need to add a bit of code into the Main method in order to pass
			  //the parameter into the method 
			int valueFive = 5;
			int userInput = System.Convert.ToInt32(userParams);
			int result = valueFive + userInput;
			System.Console.Write("That number plus 5 is " + result);
		}
}
