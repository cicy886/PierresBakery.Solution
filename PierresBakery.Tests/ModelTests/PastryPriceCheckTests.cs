using Microsoft.VisualStudio.TestTools.UnitTesting;
using PastryPriceCheck.Models;

namespace PastryPriceCheck.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void SetAmountOfPastryToBuy_SetAmount_Int()
    {
      //Arrange
      int pastryAmount = 1;

      //Act
      Pastry newPastry = new Pastry(pastryAmount);

      //Assert
      Assert.AreEqual(1, newPastry.PastryAmount);
    }
    [TestMethod]
    public void SetPriceForPastryOne_SetPrice_Int()
    {
      //Arrange
      int pastryAmount = 1;

      //Act
      Pastry newPastry = new Pastry(pastryAmount);
      newPastry.SetTotalPrice();

      //Assert
      Assert.AreEqual(2, newPastry.SetTotalPrice());
    }
    [TestMethod]
    public void SetPriceForPastryTwo_SetPrice_Int()
    {
      //Arrange
      int pastryAmount = 2;

      //Act
      Pastry newPastry = new Pastry(pastryAmount);
      newPastry.SetTotalPrice();

      //Assert
      Assert.AreEqual(4, newPastry.SetTotalPrice());
    }
    [TestMethod]
    public void SetPriceForPastryThree_SetPrice_Int()
    {
      //Arrange
      int pastryAmount = 3;

      //Act
      Pastry newPastry = new Pastry(pastryAmount);
      newPastry.SetTotalPrice();

      //Assert
      Assert.AreEqual(5, newPastry.SetTotalPrice());
    }
  }
}