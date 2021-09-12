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
  }
}