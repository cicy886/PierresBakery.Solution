using System;
using BreadPriceCheck.Models;
using PastryPriceCheck.Models;

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
      if (result == "1" && confirmOneOrTwo == "Y" || result == "1" && confirmOneOrTwo == "y")
      {
        AddBread();
      }
      if (result == "2" && confirmOneOrTwo == "Y" || result == "2" && confirmOneOrTwo == "y")
      {
        AddPastry();
      }
      // if (confirmOneOrTwo == "N" || confirmOneOrTwo == "n"){
      //   Main();
      // }
    }
    static void AddBread()
    {
      Console.WriteLine("Please enter how many bread you want:");
      string stringNumberOfBread = Console.ReadLine();
      int intNumberOfBread = int.Parse(stringNumberOfBread);
      Bread newBread = new Bread (intNumberOfBread);
      int breadAmount = newBread.BreadAmount;
      int finalPrice = newBread.SetTotalPrice();
      Console.WriteLine("You ordered " + breadAmount + " loaf (loaves) of bread.");
      Console.WriteLine("Your total price for bread is " + finalPrice + " dollors");
    }
    static void AddPastry()
    {
      Console.WriteLine("Please enter how many Pastry you want:");
      string stringNumberOfPastry = Console.ReadLine();
      int intNumberOfPastry = int.Parse(stringNumberOfPastry);
      Pastry newPastry= new Pastry (intNumberOfPastry);
      int pastryAmount = newPastry.PastryAmount;
      int finalPrice = newPastry.SetTotalPrice();
      Console.WriteLine("You ordered " + pastryAmount + " pastry (pastries).");
      Console.WriteLine("Your total price for pastry (pastries) is " + finalPrice + " dollors");
    }
  }
}
