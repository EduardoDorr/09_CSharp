using ByteBank.AgencySystem.Extensions;
using ByteBank.Models;
using ByteBank.Models.Comparers;
using ByteBank.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.AgencySystem {
  class Program {
    static void Main(string[] args) {
      var accounts = new List<CheckingAccount>() {
        new CheckingAccount(123, 12458),
        new CheckingAccount(325, 44679),
        new CheckingAccount(658, 32165),
        new CheckingAccount(467, 72564),
        null,
        new CheckingAccount(712, 96465),
        new CheckingAccount(987, 65498)
      };

      //accounts.Sort();
      //accounts.Sort(new CheckingAccountSortbyAgency());
      //var accountOrdered = accounts.OrderBy(account => account.Agency);
      /*var accountOrdered =
        accounts.OrderBy(account => {
          if (account == null) {
            return int.MaxValue;
          }

          return account.Number
        }
      );*/

      var accountOrdered = accounts
                            .Where(account => account != null)
                            .OrderBy(account => account.Number);

      /*var accountOrdered = accounts
        .Where(account => account != null)
        .OrderBy(account => account.Agency);*/

      foreach (var account in accountOrdered) {
        Console.WriteLine($"Account Number {account.Number}, Agency {account.Agency}.");
      }

      Console.WriteLine("The application finished! Key enter to exit!");
      Console.ReadLine();
    }

    static void TestSort() {
      var ages = new List<int>();
      var names = new List<string>() {
        "William",
        "Lavousier",
        "Robert",
        "Anne"
      };

      ages.Add(1);
      ages.Add(15);
      ages.Add(23);
      ages.Add(35);
      ages.AddMore(54, 25, 68, 32);
      ages.AddMore(99, -1);

      ages.Sort();
      names.Sort();

      for (int i = 0; i < ages.Count; i++) {
        Console.WriteLine(ages[i]);
      }

      for (int i = 0; i < names.Count; i++) {
        Console.WriteLine(names[i]);
      }
    }
  }
}
