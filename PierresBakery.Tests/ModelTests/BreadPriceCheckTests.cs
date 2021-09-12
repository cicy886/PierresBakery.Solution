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
  }

}