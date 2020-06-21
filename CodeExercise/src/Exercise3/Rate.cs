using Common;

namespace Exercise3
{
  public class Rate
  {
    private readonly FormatConverter _formatConverter;
    private readonly string _sourceFileName;
    public Rate(string sourceFileName)
    {
      _formatConverter = new FormatConverter();
      _sourceFileName = sourceFileName;
    }
    public void GetInputRisk()
    {
      var input = _formatConverter.GetInput(_sourceFileName);
      var xDoc = _formatConverter.CreateXDocument(input);
    }
  }
}
