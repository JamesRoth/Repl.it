/*InputTest.cs - using basic input statements - 4/30/19*/

using System;

namespace InputTestApp {
  class InputTest {
    public static void Main(string[] args) {
      string nameStr;
      Console.Write("Enter your name: ");
      nameStr = Console.ReadLine();
      Console.WriteLine("Hello, " + nameStr);

      string ageStr;
      int ageInt;
      Console.Write("How old are you?: ");
      ageStr = Console.ReadLine();
      ageInt = Convert.ToInt32(ageStr);
      Console.WriteLine("You will be " + (ageInt+1) + " years old next year.");
    }
  }
}
