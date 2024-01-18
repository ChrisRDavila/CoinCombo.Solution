using CoinCombo.Models;
using System;
using CoinCombo.UserInterfaceModels;

namespace CoinCombo
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.Beep();
      Console.WriteLine(WelcomeBanner.Welcome);
      Console.WriteLine("Welcome to CoinCombo C# Console App!");
      Console.WriteLine("Enter an amount of pennies to convert to change: ");
      int userInput = int.Parse(Console.ReadLine());
      Change newChange = new Change(userInput);
      ConfirmOrEditChange(newChange);

      static void ConfirmOrEditChange(Change newChange)
      {
        Console.WriteLine($"You entered {newChange.Cents} pennies. Is this correct? (Y/N)");
        string userConfirm = Console.ReadLine();
        if(userConfirm == "Y" || userConfirm == "y")
        {
          Console.WriteLine("Great! Here's your change:");
          Console.WriteLine($"{newChange.CalculateCoins()[0]} quarters, {newChange.CalculateCoins()[1]} dimes, {newChange.CalculateCoins()[2]} nickels, and {newChange.CalculateCoins()[3]} pennies.");
          Console.WriteLine(GoodbyeBanner.Goodbye);
        }
        else if (userConfirm == "N" || userConfirm == "n")
        {
          Console.WriteLine("Please enter the correct amount of pennies: ");
          int userEdit = int.Parse(Console.ReadLine());
          newChange.Cents = userEdit;
          ConfirmOrEditChange(newChange);
        }
        else
        {
          Console.WriteLine("Please enter Y or N.");
          ConfirmOrEditChange(newChange);
        }
      }
    }
  }
}








//       Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
//       Console.Beep();
//       Console.WriteLine(WelcomeBanner.Welcome);
//       Console.WriteLine("Welcome to CoinCombo C# Console App!");
//       Console.WriteLine("Enter an amount of pennies to convert to change: ");
//       int userInput = Int.Parse(Console.ReadLine());
//       Change newChange = new Change(userInput);
//       ConfirmOrEditChange(newChange);

//       static void ConfirmOrEditChange(Change newChange);
//       {
//         Console.WriteLine($"You entered {newChange.Cents} pennies. Is this correct? (Y/N)");
//         string userConfirm = Console.ReadLine();
//         if(userConfirm == "Y" || userConfirm == "y");
//         {
//           Console.WriteLine("Great! Here's your change:");
//           Console.WriteLine($"{newChange.CalculateCoins()[0]} quarters, {newChange.CalculateCoins()[1]} dimes, {newChange.CalculateCoins()[2]} nickels, and {newChange.CalculateCoins()[3]} pennies.");
            
//             // Console.WriteLine($"{(newChange.CalculateCoins()[0] > 0 ? newChange.CalculateCoins()[0] + " quarters, " : "")}" +
//             //       $"{(newChange.CalculateCoins()[1] > 0 ? newChange.CalculateCoins()[1] + " dimes, " : "")}" +
//             //       $"{(newChange.CalculateCoins()[2] > 0 ? newChange.CalculateCoins()[2] + " nickels, " : "")}" +
//             //       $"{(newChange.CalculateCoins()[3] > 0 ? newChange.CalculateCoins()[3] + " pennies." : "")}");
            
//           Console.WriteLine(GoodbyeBanner.Goodbye);
          
//           else if (userConfirm == "N" || userConfirm == "n");
//           {
//             Console.WriteLine("Please enter the correct amount of pennies: ");
//             int userEdit = Int.Parse(Console.ReadLine());
//             newChange.Cents = userEdit;
//             ConfirmOrEditChange(newChange);
//           }
//           else
//           {
//             Console.WriteLine("Please enter Y or N.");
//             ConfirmOrEditChange(newChange);
//           }
//         } 
//       }
//     }
// }