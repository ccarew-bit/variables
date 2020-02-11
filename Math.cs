using System;

namespace variables
{
  public class Math
  {
    public void DoSomething()
    {
      var numberOfCupsOfCoffee = 3;
      var fullName = "corinne carew";
      var today = "2/10/2020";
      //Ask the user for their name and store it in a variable called user
      Console.WriteLine("hello, whats your name?");
      var user = Console.ReadLine();
      if (user == "Alice")
      {
        Console.WriteLine("Hi, Alice! Don't eat the cake!");
      }
      else
      {
        Console.WriteLine("hi," + user);
      }
      //Print out a greeting to the user, using their name above added if then alice user
      //Ask the user to input two numbers
      Console.WriteLine("please enter 2 numbers");
      //Get the numbers as Strings using Console.ReadLine
      string number1 = Console.ReadLine();
      string number2 = Console.ReadLine();
      //Convert a String to a double using double.parse. Save the first double value in an operand1 variable and the second double value in an operand2 variable
      var operand1 = double.Parse(number1);
      var operand2 = double.Parse(number2);
      //Add the operands and save in a sum variable
      var sum = double.Parse(number1) + double.Parse(number2);
      Console.WriteLine("sum=" + sum);
      //Subtract the operands and save in a difference variable
      var difference = double.Parse(number1) - double.Parse(number2);
      Console.WriteLine("difference=" + difference);
      //Divide the operands and save in a quotient variable
      var quotient = double.Parse(number1) / double.Parse(number2);
      Console.WriteLine("quotient=" + quotient);
      //Multiply the operands and save in a product variable
      var product = double.Parse(number1) * double.Parse(number2);
      Console.WriteLine("product=" + product);
      //Find the remainder when one operand is divided by the other and save in a remainder variable. 
      var remainder = double.Parse(number2) % double.Parse(number1);
      Console.WriteLine("remainder=" + remainder);
      DateTime todayTime = DateTime.Now;
      Console.WriteLine(todayTime);
    }
  }
}