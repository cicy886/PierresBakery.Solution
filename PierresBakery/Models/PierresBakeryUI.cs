using System;

namespace PierresBakery.Models
{
  public class PierresBakeryUI
  {
    public static void Main ()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("The products available in Pierre's Bakery are:");
      Console.WriteLine ("1. Bread.");
      Console.WriteLine("2. Pastry.");
      Console.WriteLine("We are having a promotion now! Here are the prices:");
      Console.WriteLine("Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.");
      Console.WriteLine("Please press 1 to choose Bread, press 2 to choose pastry:");
      string chooseBreadOrPastry = Console.ReadLine();
    }
  }
}