using Microsoft.EntityFrameworkCore;

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
  }
}