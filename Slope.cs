/* James Roth - 5/8/19 - Calulating the slope from two points */

using System;

namespace SlopeApp {
  class Slope {
    static void Main(string[] args) {
    
    Console.WriteLine("Enter X1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter X2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    if (x1-x2 != 0 & y2-y1 != 0)
    {
      Console.WriteLine("Slope: " + (y1-y2)/(x1-x2));
    }
    if (y1-y2 == 0)
    {
      Console.WriteLine("Slope: 0");
    } 
    if (x1-x2 == 0)
    {
      Console.WriteLine("Slope: undefined");
    }

    }
  }
}
