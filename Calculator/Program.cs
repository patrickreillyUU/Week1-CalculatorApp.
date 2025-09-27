Console.WriteLine("Type in your first number followed by the enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in your second number followed by the enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;
Console.WriteLine("The addition of both {0} and {1} is {2}", firstNumber, secondNumber, result);
