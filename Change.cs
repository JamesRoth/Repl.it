/* Change.cs - making change with an amount of cents - 5/3/19 */

using System;

namespace ChangeApp {
  class Change {
    static void Main(string[] args) {
      string changeStr;
      int changeInt;

      Console.Write("Enter an amount of change: ");
      changeStr = Console.ReadLine();
      changeInt = Convert.ToInt32(changeStr);

      Console. WriteLine("Quarters: " + changeInt/25);
      Console.ReadLine();
      changeInt = changeInt%25;
      Console. WriteLine("Dimes: " + changeInt/10);
      Console.ReadLine();
      changeInt = changeInt%10;
      Console. WriteLine("Nickels: " + changeInt/5);
      Console.ReadLine();
      changeInt = changeInt%5;
      Console. WriteLine("Pennies: " + changeInt);
      Console.ReadLine();
    }
  }
}
