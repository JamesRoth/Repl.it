/*James Roth - 5/7/19 - TipCalculator.cs - calculating tips*/

using System;

namespace TipCalculatorApp {
  class TipCalculator {
    static void Main(string[] args) {
      double bill;
      double tipPercent;

      Console.WriteLine("Enter the bill cost: ");
      bill = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter % you wish to tip (15% = 0.15): ");
      tipPercent = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Your tip is " + tipPercent*bill + " dollars");
    }
  }
}

