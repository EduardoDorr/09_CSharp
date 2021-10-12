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
    static void Main(string[] args) {
      Console.WriteLine("Write your name: ");
      var name = Console.ReadLine();
      Console.Write(name);


      ConsoleReader();
      }      
  }
}
