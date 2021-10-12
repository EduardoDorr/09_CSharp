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
    static void BinaryWriter() {
      var accountsExported = "C:/Users/edudo/Desktop/Alura/C# e Orientação a Objetos/Biblioteca/BinaryWriter.csv";

      using (var fs = new FileStream(accountsExported, FileMode.Create))
      using (var writer = new BinaryWriter(fs)) {
        writer.Write(456); // Agency
        writer.Write(164259); // Number
        writer.Write(4000.50); // Balance
        writer.Write("Jonathan Silva"); // Owner
      }

      Console.WriteLine("\nThe application finished! Key enter to exit!");
      Console.ReadLine();
    }

    static void BinaryReader() {
      var accountsExported = "C:/Users/edudo/Desktop/Alura/C# e Orientação a Objetos/Biblioteca/BinaryWriter.csv";

      using (var fs = new FileStream(accountsExported, FileMode.Open))
      using (var reader = new BinaryReader(fs)) {
        var agency = reader.ReadInt32();
        var number = reader.ReadInt32();
        var balance = reader.ReadDouble();
        var owner = reader.ReadString();

        Console.WriteLine($"Agency: {agency} / Number: {number} / Balance: {balance} / Owner: {owner}");
      }

      Console.WriteLine("\nThe application finished! Key enter to exit!");
      Console.ReadLine();
    }
  }
}
