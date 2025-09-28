CalculatorApp();

void CalculatorApp()
{
    //Declare the variables and initialise them to 0.
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    //Ask the user to type the first number. 
    Console.WriteLine("Type in your first number followed by the enter key");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    //Ask the user to type the second number. 
    Console.WriteLine("Type in your second number followed by the enter key");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    //Use a loop to make the relevent decision. 
    //And perform the request maths operation. 
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - ADD");
    Console.WriteLine("2 - SUBTRACT");
    Console.WriteLine("3 - DIVIDE");
    Console.WriteLine("4 - MULTIPLY");

    //Convert string to integer. 
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        //Perform the calculation. 
        result = firstNumber + secondNumber;

        //Now output the answer to the console.
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {firstNumber} from {secondNumber} equals {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} from {secondNumber} equals {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} by {secondNumber} equals {result}");
    }
    else 
    {
        Console.WriteLine("You did not enter a valid number between 1 and 4");
    }

}