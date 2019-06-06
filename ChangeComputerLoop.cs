/* James Roth - 5/14/19 - ChangeComputerLoop.cs - finding the change from an amount of money with loops */

using System;

namespace ChangeComputerLoopApp {
  class ChangeComputerLoop {
    static void Main(string[] args) {
      int change;
      int quarters = 0;
      int dimes = 0;
      int nickels = 0;
      int pennies = 0;

      Console.Write("Enter an amount of change: ");
      change = Convert.ToInt32(Console.ReadLine());

      while (change - 25 >= 0)
      {
        quarters += 1;
        change -= 25;
      }

      while (change - 10 >= 0)
      {
        dimes += 1;
        change -= 10;
      }

      while (change - 5 >= 0)
      {
        nickels += 1;
        change -= 5;
      }

      while (change - 1 >= 0)
      {
        pennies += 1;
        change -= 1;
      }

      Console.WriteLine("Quarters: " + quarters);
      Console.WriteLine("Dimes: " + dimes);
      Console.WriteLine("Nickels: " + nickels);
      Console.WriteLine("Pennies: " + pennies);
    }
  }
}
