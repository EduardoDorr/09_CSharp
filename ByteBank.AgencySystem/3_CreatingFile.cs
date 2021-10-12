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
    static void CreatingFile() {
      var accountsExported = "C:/Users/edudo/Desktop/Alura/C# e Orientação a Objetos/Biblioteca/accountsExported.csv";

      using (var streamFile = new FileStream(accountsExported, FileMode.Create)) {
        var output = "456;124586;325.25;Jonathan Silva";
        var encoding = Encoding.UTF8;
        var bytes = encoding.GetBytes(output);

        streamFile.Write(bytes, 0, bytes.Length);
      }

      Console.WriteLine("\nThe application finished! Key enter to exit!");
      Console.ReadLine();
    }

    static void CreateWithWriter() {
      var accountsExported = "C:/Users/edudo/Desktop/Alura/C# e Orientação a Objetos/Biblioteca/accountsExported.csv";

      using (var fs = new FileStream(accountsExported, FileMode.Create))
      using (var writer = new StreamWriter(fs)) {
        writer.Write("456;124586;325.25;Pedro Dorneles");
      }

      Console.WriteLine("\nThe application finished! Key enter to exit!");
      Console.ReadLine();
    }

    static void TestWriter() {
      var accountsExported = "C:/Users/edudo/Desktop/Alura/C# e Orientação a Objetos/Biblioteca/accountsExported.csv";

      using (var streamFile = new FileStream(accountsExported, FileMode.Create))
      using (var writer = new StreamWriter(streamFile)) {
        for (int i = 0; i < 1000000; i++) {
          writer.WriteLine($"Line {i}");
          writer.Flush();

          Console.WriteLine($"Line {i} wrote!");
          Console.ReadLine();
        }        
      }

      Console.WriteLine("\nThe application finished! Key enter to exit!");
      Console.ReadLine();
    }
  }
}
