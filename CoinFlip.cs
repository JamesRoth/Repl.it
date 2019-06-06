/* James Roth - 5/7/19 - CoinFlip.cs - flipping a coin */

using System;

namespace CoinFlipApp {
  class CoinFlip {
    static void Main(string[] args) {
    
    Random rnd = new Random();
    int coin = rnd.Next(0, 2);

    if (coin == 1)
    {
      Console.WriteLine("Heads!");
    }
    else
    {
      Console.WriteLine("Tails!");
    } 
    }
  }
}
