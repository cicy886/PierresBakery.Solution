using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreadPriceCheck.Models;

namespace BreadPriceCheck.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void SetAmountOfBreadToBuy_SetAmount_Int()
    {
      //Arrange
      int breadAmount = 1;

      //Act
      Bread newBread = new Bread(breadAmount);

      //Assert
      Assert.AreEqual(1, newBread.BreadAmount);
    }
    [TestMethod]
      public void SetPriceForBreadOne_SetPrice_Int()
      {
        //Arrange
        int breadAmount = 1;

        //Act
        Bread newBread = new Bread(breadAmount);
        newBread.SetTotalPrice();

        //Assert
        Assert.AreEqual(5, newBread.SetTotalPrice());
      }
          [TestMethod]
      public void SetPriceForBreadTwo_SetPrice_Int()
      {
        //Arrange
        int breadAmount = 2;

        //Act
        Bread newBread = new Bread(breadAmount);
        newBread.SetTotalPrice();

        //Assert
        Assert.AreEqual(10, newBread.SetTotalPrice());
      }
          [TestMethod]
      public void SetPriceForBreadThree_SetPrice_Int()
      {
        //Arrange
        int breadAmount = 3;

        //Act
        Bread newBread = new Bread(breadAmount);
        newBread.SetTotalPrice();

        //Assert
        Assert.AreEqual(10, newBread.SetTotalPrice());
      }
          [TestMethod]
      public void SetPriceForBreadFour_SetPrice_Int()
      {
        //Arrange
        int breadAmount = 4;

        //Act
        Bread newBread = new Bread(breadAmount);
        newBread.SetTotalPrice();

        //Assert
        Assert.AreEqual(15, newBread.SetTotalPrice());
      }
          [TestMethod]
      public void SetPriceForBreadFive_SetPrice_Int()
      {
        //Arrange
        int breadAmount = 5;

        //Act
        Bread newBread = new Bread(breadAmount);
        newBread.SetTotalPrice();

        //Assert
        Assert.AreEqual(25, newBread.SetTotalPrice());
      }
      //     [TestMethod]
      // public void SetPriceForBreadSix_SetPrice_Int()
      // {
      //   //Arrange
      //   int breadAmount = 6;

      //   //Act
      //   Bread newBread = new Bread(breadAmount);
      //   newBread.SetTotalPrice();

      //   //Assert
      //   Assert.AreEqual(20, newBread.SetTotalPrice());
      // }
  }
}