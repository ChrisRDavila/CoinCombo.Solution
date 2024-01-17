using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace  CoinCombo.Models
{
  public class Change
  {
    public int Cents { get; set; }
    // private int _qC;
    // private int _dC;
    // private int _nC;
    // private int _pC;

    public Change(int money)
    {
      Cents = money;
    }

    public List<int> CalculateCoins()
    {
      int money = Cents;
      List<int> moneyList = new List<int> {0, 0, 0, 0};
      while (money >= 25)
      {
        money -= 25;
        moneyList[0] += 1;
      }
      while (money >= 10)
      {
        money -= 10;
        moneyList[1] += 1;
      }
      while (money >= 5)
      {
        money -= 5;
        moneyList[2] += 1;
      }
      while (money >= 1)
      {
        money -= 1;
        moneyList[3] += 1;
      }
      return moneyList;
    }

    
  }
}