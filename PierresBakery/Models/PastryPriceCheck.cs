using System;

namespace PastryPriceCheck.Models
{
  public class Pastry
  {
    public int PastryAmount {get; set;}
    public int Price {get; set;}

    public Pastry(int pastryAmount, int price=0)
    {
      PastryAmount = pastryAmount;
      Price = price;
    }

    public int SetTotalPrice()
    {
      //Pastry: Buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10.
      if (PastryAmount % 3 == 0) 
      {
        Price = PastryAmount/3*5;
      } 
      else if (PastryAmount %3 != 0)
      {
        Price = (PastryAmount/3*5) + (PastryAmount % 3 * 2);
      } 

      return Price;
    }
  }
}