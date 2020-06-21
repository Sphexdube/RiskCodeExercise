using System.IO;
using System.Xml.Linq;

namespace Common
{
  public class FormatConverter
  {
    public string GetInput(string sourceFileName)
    {
      using (var stream = File.OpenRead(sourceFileName))
      using (var reader = new StreamReader(stream))
      {
        return reader.ReadToEnd();
      }
    }
    public XDocument CreateXDocument(string input)
    {
      return XDocument.Parse(input);
    }
  }
}
