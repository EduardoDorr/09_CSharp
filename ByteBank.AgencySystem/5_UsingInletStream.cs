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
    static void ConsoleReader() {
      var exported = "C:/Users/edudo/Desktop/Alura/C# e Orientação a Objetos/Biblioteca/ConsoleWriter.txt";

      using (var consoleStream = Console.OpenStandardInput())
      using (var fs = new FileStream(exported, FileMode.Create)) {
        var buffer = new byte[1024]; // 1kb
        
        while (true) {
          var bytesRead = consoleStream.Read(buffer, 0, 1024);
          fs.Write(buffer, 0, bytesRead);
          fs.Flush();

          Console.WriteLine($"Bytes read from console: {bytesRead}");
        }
      }

      Console.WriteLine("\nThe application finished! Key enter to exit!");
      Console.ReadLine();
    }
  }
}
