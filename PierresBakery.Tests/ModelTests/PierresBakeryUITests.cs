using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PierresBakeryUITests
  {
    [TestMethod]
    public void PierresBakeryUIConstructor_CreatesInstanceOfPierresBakeryUI_PierresBakeryUI()
    {
      PierresBakeryUI newPierresBakeryUI = new PierresBakeryUI();
      Assert.AreEqual(typeof(PierresBakeryUI), newPierresBakeryUI.GetType());
    }
  }
}