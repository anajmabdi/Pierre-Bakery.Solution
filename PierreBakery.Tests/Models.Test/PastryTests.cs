using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
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
    public void GetAmount_Return1_Pastry()
    {
      //Arrange
      int pastry = 1;
      Pastry newPastry = new Pastry(pastry);
      //Act
      int result = newPastry.PastryAmount; 
      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void SetCost_CalculatesPastryCost_PastryTotal() {
      //Arrange
      Pastry newPastry = new Pastry(4);

      //Act
      int result = newPastry.PastryTotal();

      //Assert
      Assert.AreEqual(7, result);
    }
  }
}