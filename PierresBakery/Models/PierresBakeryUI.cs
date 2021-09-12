using System;
using BreadPriceCheck.Models;

namespace PierresBakery.Models
{
  public class PierresBakeryUI
  {
    public string Answer { get; set; }

    // private static List<PierresBakeryUI> _instances = new List<PierresBakeryUI> {};

    public PierresBakeryUI(string answer)
    {
      Answer = answer;
    }

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
      PierresBakeryUI newPierresBakeryUI = new PierresBakeryUI(chooseBreadOrPastry);
      string result = newPierresBakeryUI.Answer;
      Console.WriteLine("You chose " + result + ". Is it correct? Y/N");
      string confirmOneOrTwo = Console.ReadLine();
      if (result == "1" && confirmOneOrTwo == "Y")
      {
        Console.WriteLine("Please type in how many bread you want:");
        string stringNumberOfBread = Console.ReadLine();
        int intNumberOfBread = int.Parse(stringNumberOfBread);
        // Bread newBread = new Bread();
        // newBread.TotalPrice();
      }
    }
  }
}

//         Console.WriteLine("Please type in how many bread you want:");
//         string stringNumberOfBread = Console.ReadLine();
//         int intNumberOfBread = int.Parse(stringNumberOfBread);
//         if (intNumberOfBread == 1) 
//         {
//           Console.WriteLine("You need to pay 5 dollors.");
//         }