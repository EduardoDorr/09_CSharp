using ByteBank.AgencySystem.Extensions;
using ByteBank.Models;
using ByteBank.Models.Comparers;
using ByteBank.Models.Employees;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.AgencySystem {
  partial class Program {
    static void UsingStreamReader() {
      var accountsAddress = "C:/Users/edudo/Desktop/Alura/C# e Orientação a Objetos/Biblioteca/accounts.csv";
      using (var streamFile = new FileStream(accountsAddress, FileMode.Open))
      using (var reader = new StreamReader(streamFile, Encoding.Default)) {
        while (!reader.EndOfStream) {
          var line = reader.ReadLine();
          var account = ConvertToCheckingAccount(line);
          Console.WriteLine($"Account: {account.Number} / Agency: {account.Agency} / Balance: {account.Balance} / Owner: {account.Owner.Name}");
        }
      }
      Console.WriteLine("\nThe application finished! Key enter to exit!");
      Console.ReadLine();
    }

    static CheckingAccount ConvertToCheckingAccount(string line) {
      var fields = line.Split(';');

      var agency = int.Parse(fields[0]);
      var number = int.Parse(fields[1]);
      var balance = double.Parse(fields[2].Replace('.', ','));
      var owner = fields[3];

      var client = new Client();
      client.Name = owner;

      var result = new CheckingAccount(agency, number);
      result.Deposit(balance);
      result.Owner = client;

      return result;
    }
  }
}