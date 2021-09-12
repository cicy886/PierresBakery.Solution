using System;
using BreadPriceCheck.Models;
using PastryPriceCheck.Models;

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
      Console.WriteLine("Would you like to order anything? Y/N");
      string chooseBreadOrPastry = Console.ReadLine();
      if (chooseBreadOrPastry == "Y" || chooseBreadOrPastry == "y")
      {
        AddProduct();
      }
      else if (chooseBreadOrPastry == "N" || chooseBreadOrPastry == "n")
      {
        Console.Clear();
        Console.WriteLine("Goodbye!");
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Invalid answer. Please start over.");
        Main();
      }

    }
    static void AddProduct()
    {
      Console.Clear();
      Console.WriteLine("Please enter how many bread you want:");
      string stringNumberOfBread = Console.ReadLine();
      int intNumberOfBread = int.Parse(stringNumberOfBread);
      Bread newBread = new Bread (intNumberOfBread);
      int breadAmount = newBread.BreadAmount;
      int breadPrice = newBread.SetTotalPrice();
      if (breadAmount <0)
      {
        Console.WriteLine("Invalid input.");
        Main();
      }
      else
      {
        Console.WriteLine("You ordered " + breadAmount + " loaf (loaves) of bread.");
        Console.WriteLine("Your total price for bread is " + breadPrice + " dollors.");
      }

      // Console.Clear();
      Console.WriteLine("Please enter how many Pastry you want:");
      string stringNumberOfPastry = Console.ReadLine();
      int intNumberOfPastry = int.Parse(stringNumberOfPastry);
      Pastry newPastry= new Pastry (intNumberOfPastry);
      int pastryAmount = newPastry.PastryAmount;
      int pastryPrice = newPastry.SetTotalPrice();
      if (pastryAmount <0)
      {
        Console.WriteLine("Invalid input");
      }
      else{
              Console.WriteLine("You ordered " + pastryAmount + " pastry (pastries).");
      Console.WriteLine("Your total price for pastry (pastries) is " + pastryPrice + " dollors.");
      Console.WriteLine("Your total cost for this entire order is " + (breadPrice + pastryPrice) + " dollors.");
      }
    }
  }
}
