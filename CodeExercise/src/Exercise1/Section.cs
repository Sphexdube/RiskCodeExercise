using Common;
using System;
using System.Xml.XPath;

namespace Exercise1
{
  public class Section
  {
    private readonly string xPath = "DocumentMessage/Document/insuranceFile/product/productSections/productSection/sectionName"; // XPATH to retrieve the following attribute on line 63

    private readonly FormatConverter _formatConverter;
    private readonly string _sourceFileName;

    public Section(string sourceFileName)
    {
      _formatConverter = new FormatConverter();
      _sourceFileName = sourceFileName;
    }
    public void ReadAttribute()
    {
      var input = _formatConverter.GetInput(_sourceFileName);
      var xDoc = _formatConverter.CreateXDocument(input);

      var xElement = xDoc.XPathSelectElement(xPath);

      Console.WriteLine(xElement);
      Console.ReadLine();
    }
  }
}
