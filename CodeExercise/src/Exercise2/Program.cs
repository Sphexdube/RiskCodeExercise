using System;
using System.IO;

namespace Exercise2
{
  class Program
  {
    static void Main(string[] args)
    {
      var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\..\\..\\assets\\ClientData.xml");

      try
      {
        var client = new Client(sourceFileName);
        client.ClientData();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
