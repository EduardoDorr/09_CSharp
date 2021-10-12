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
    static void TryStreamDirect() {
      var accountsAddress = "C:/Users/edudo/Desktop/Alura/C# e Orientação a Objetos/Biblioteca/accounts.txt";

      using (var streamFile = new FileStream(accountsAddress, FileMode.Open)) {
        var buffer = new byte[1024]; // 1kb
        var bytesRead = -1;

        while (bytesRead != 0) {
          bytesRead = streamFile.Read(buffer, 0, 1024);
          WriteBuffer(buffer, bytesRead);
        }
      }
    }

    static void WriteBuffer(byte[] buffer, int bytesRead) {
      var utf8 = Encoding.Default;
      var text = utf8.GetString(buffer, 0, bytesRead);

      Console.Write(text);


      /*foreach (var myByte in buffer) {
        Console.Write(myByte);
        Console.Write(" ");
      }*/
    }
  }
}