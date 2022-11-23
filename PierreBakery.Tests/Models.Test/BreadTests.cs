using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfItem_Item()
    {
    Bread newBread = new Bread();
    Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}