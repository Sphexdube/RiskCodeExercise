using System;
using System.IO;

namespace Exercise3
{
  class Program
  {
    static void Main(string[] args)
    {
      var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\..\\..\\assets\\InputRiskXml.xml");

      try
      {
        var rate = new Rate(sourceFileName);
        rate.GetInputRisk();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
