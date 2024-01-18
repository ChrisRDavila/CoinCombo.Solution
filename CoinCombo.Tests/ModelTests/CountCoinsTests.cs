using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombo.Models;
using System.Collections.Generic;


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

    [TestMethod]
    public void SetAmount_SetValueOfAmount_Void()
    {
      //Arrange
      Change newChange = new Change(75);
      int newAmount = 75;
      //Act
      newChange.Cents = newAmount;
      //Assert
      Assert.AreEqual(newAmount, newChange.Cents);
    }

    [TestMethod]
    public void CalculateCoins_ReturnsAmountOfQuarters_Int()
    {
      //Arrange
      int testAmount = 50;
      Change newChange = new Change(testAmount);
      //Act
      int result = newChange.CalculateCoins()[0];
      //Assert
      Assert.AreEqual(result, 2);
    }
    [TestMethod]
    public void CalculateCoins_ReturnsAmountOfDimes_Int()
    {
      //Arrange
      int testAmount = 20;
      Change newChange = new Change(testAmount);
      //Act
      int result = newChange.CalculateCoins()[1];
      //Assert
      Assert.AreEqual(result, 2);
    }
    [TestMethod]
    public void CalculateCoins_ReturnsAmountOfNickels_Int()
    {
      //Arrange
      int testAmount = 6;
      Change newChange = new Change(testAmount);
      //Act
      int result = newChange.CalculateCoins()[2];
      //Assert
      Assert.AreEqual(result, 1);
    }
    [TestMethod]
    public void CalculateCoins_ReturnsAmountOfPennies_Int()
    {
      //Arrange
      int testAmount = 4;
      Change newChange = new Change(testAmount);
      //Act
      int result = newChange.CalculateCoins()[3];
      //Assert
      Assert.AreEqual(result, 4);
    }
    [TestMethod]
    public void CalculateCoins_ReturnsAmountOfAllCoins_Int()
    {
      //Arrange
      int testAmount = 41;
      Change newChange = new Change(testAmount);
      //Act
      List<int> result = newChange.CalculateCoins();
      List<int> sample = new List<int> {1,1,1,1};
      //Assert
      CollectionAssert.AreEqual(result, sample);
    }
  }
}    