class OurProgram 
{
	//we will two different key ways to print to the console and also
	 //to receive input from our user
	//System.Console.Write will print the value of a variable
	//A variable is a piece of code that stores data 
	//We can use variables to do math within our program
	//When we run our program we would first need to compile it in the
	  //console using the command mcs & our file name
	//We should get a .exe file which we can then run using the command
	  //mono & file name. If you do not you probably have a compiler error
	static void Main()
	{
		//Integers
		//Here we will create three variables and add them
		// int numbOne = 1;
		// int numbTwo = 1; 
		// int result;
		// result = numbOne + numbTwo;
		// System.Console.Write(result);

		//Strings 
		//Variables can also store text known as "Strings"
		// string phraseOne = "Hey I am learning";
		// System.Console.Write(phraseOne);
		//strings can also be joined together. This is called "String
		  //interpolation"
		// System.Console.Write(phraseOne + " C# programming with Dan!");
		//We can also retreive user input by using the .ReadLine function
		//We can use this to customize our message 
		// string userInput = System.Console.ReadLine();
		// System.Console.Write(phraseOne + " " + userInput);

		//Floats 
		//When using floats or decimal values, you must specify the type as "float" 
		 //and also add the suffix of "f" after the value
		float floatOne = 1.5f;
		float floatTwo = 2.5f;
		float resultFloat; 
		resultFloat = floatOne + floatTwo;
		System.Console.Write(resultFloat);
	}

}