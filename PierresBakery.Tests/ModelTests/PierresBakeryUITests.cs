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
      PierresBakeryUI newPierresBakeryUI = new PierresBakeryUI("test");
      Assert.AreEqual(typeof(PierresBakeryUI), newPierresBakeryUI.GetType());
    }
    [TestMethod]
    public void GetAnswer_ReturnsAnswer_String()
    {
      string answer = "1";
      PierresBakeryUI newPierresBakeryUI = new PierresBakeryUI(answer);
      string result = newPierresBakeryUI.Answer;
      Assert.AreEqual(answer, result);
    }

  }
}