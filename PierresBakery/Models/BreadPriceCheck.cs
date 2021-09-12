using System;
using System.Collections.Generic;


namespace BreadPriceCheck.Models
{
  public class Bread
  {
    public int BreadAmount {get; set;}
    public int Price {get; set;}

    public Bread(int breadAmount, int price=0)
    {
      BreadAmount = breadAmount;
      Price = price;
    }

    public int SetTotalPrice()
    {
      //Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
      if (BreadAmount % 3 == 0) 
      {
        Price = BreadAmount/3*10;
      } 
      else if (BreadAmount %3 != 0)
      {
        Price = (BreadAmount/3*10) + (BreadAmount % 3 * 5);
      } 

      return Price;
    }

  }
}