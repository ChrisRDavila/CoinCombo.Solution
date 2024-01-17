using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombo.Models;


namespace CoinCombo.Tests
{
  [TestClass]
  public class CountCoinsTests

  {
    [TestMethod]
    public void ChangeConstructor_CreateInstances_Change()
    {
      //Act
      Change testChange = new Change(97);
      //Assert
      Assert.AreEqual(typeof(Change), testChange.GetType());
    }

    [TestMethod]
    public void GetAmount_ReturnAmoint_Int()
    {
      //Arrange
      int testAmount = 97;
      Change newChange = new Change(testAmount);
      //Act
      int result = newChange.Cents;
      //Assert
      Assert.AreEqual(testAmount, result);
    }

    
  }
}    