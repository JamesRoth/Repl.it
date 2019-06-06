/* James Roth - 5/10/19 - UnitConverter.cs - converting from one unit to another */

using System;

namespace UnitConverterApp {
  class UnitConverter {
    static void Main(string[] args) {

      Console.WriteLine("What would you like to convert? Enter 1 for KM to Miles, 2 for KG to LBS, 3 for Liters to Gallons, and 4 for Celsius to Fahrenheight.");
      int convert = Convert.ToInt32(Console.ReadLine());
      
      if (convert == 1)
      {
        Console.WriteLine("Enter km: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(km + " kilometers is " + Math.Round(km*0.621371,2) + " miles");
      }
      if (convert == 2)
      {
        Console.WriteLine("Enter kg: ");
        double kg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(kg + " kilograms is " + Math.Round(kg*2.20462,2) + " pounds");
      }
      if (convert == 3)
      {
        Console.WriteLine("Enter liters: ");
        double liters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(liters + " liters is " + Math.Round(liters*0.264172,2) + " gallons");
      }
      if (convert == 4)
      {
        Console.WriteLine("Enter celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(celsius + " degrees celsius is " + Math.Round(celsius*(9/5)+32) + " degrees farenheight");
      }
      if (convert != 1 & convert != 2 & convert != 3 & convert != 4)
      {
        Console.WriteLine("Error: Use a number between 1 and 4.");
      }

    }
  }
}

