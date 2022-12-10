using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
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
    public void GetAmount_Return1_Int()
    {
      //Arrange
      int bread = 1;
      Bread newBread = new Bread(bread);
      //Act
      int result = newBread.BreadAmount; 
      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void SetCost_OneLoafCost_BreadTotal() {
      //Arrange
      Bread newBread = new Bread(1);

      //Act
      int result = newBread.BreadTotal();

      //Assert
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void SetCost_ThreeLoafCost_BreadTotal() {
      //Arrange
      Bread newBread = new Bread(3);

      //Act
      int result = newBread.BreadTotal();

      //Assert
      Assert.AreEqual(10, result);
    }
  }
}