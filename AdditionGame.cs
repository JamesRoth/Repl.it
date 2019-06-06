/* AdditionGame.cs - A simple addition input/output game - 5/1/19 */

using System;

namespace AdditionGameApp {
  class AdditionGame {
    static void Main(string[] args) {
      int num1;
      int num2;
      int answerInt;
      string answerString;
      Random rnd = new Random();
      num1 = rnd.Next(1,10);
      num2 = rnd.Next(1,10);
      Console.Write("What is "+num1+" + "+num2+"? ");
      answerString = Console.ReadLine();
      answerInt = Convert.ToInt32(answerString);
      if (answerInt == (num1 + num2))
      {
        Console.WriteLine("Correct!");
      }
      else
      {
        Console.WriteLine("Incorrect!");
      }
    }
  }
}
