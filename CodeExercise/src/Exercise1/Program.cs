using System;
using System.IO;

namespace Exercise1
{
  class Program
  {
    static void Main(string[] args)
    {
      var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\..\\..\\assets\\CodeExercise.xml");

      try
      {
        var section = new Section(sourceFileName);
        section.ReadAttribute();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
