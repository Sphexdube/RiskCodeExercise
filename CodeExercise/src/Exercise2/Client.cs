using Common;
using Common.Models;
using System;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Exercise2
{
  public class Client
  {
    private readonly FormatConverter _formatConverter;
    private readonly string _sourceFileName;
    public Client(string sourceFileName)
    {
      _formatConverter = new FormatConverter();
      _sourceFileName = sourceFileName;
    }
    public void ClientData()
    {
      var input = _formatConverter.GetInput(_sourceFileName);
      var xDoc = _formatConverter.CreateXDocument(input);

      var clients = GetClients(xDoc);
      displayInformation(clients);
    }
    private Clients GetClients(XDocument xDoc)
    {
      var xClients = xDoc.Root.Descendants().FirstOrDefault(d => d.Name.LocalName.Equals("clients"));
      var serializer = new XmlSerializer(typeof(Clients));

      using (var reader = xClients.CreateReader())
      {
        var clients = (Clients)serializer.Deserialize(reader);
        return clients;
      }
    }
    private void displayInformation(Clients clients)
    {
      var riskList = clients.Client.Risks.Risk
                            .OrderBy(x => x.RiskSequence)
                            .ToList();

      var totalSumInsured = riskList.Sum(x => x.SumInsured);
      var totalPremium = riskList.Sum(x => x.Premium);


      foreach (var r in riskList)
      {

        Console.WriteLine($"Risk: {r.RiskSequence} \n" +
                          $"Risk Name: {r.RiskName} \n" +
                          $"Risk Sum Insured: {r.SumInsured} \n" +
                          $"Risk Premium: {r.Premium} \n");
    
      }

      Console.WriteLine($"Total Risk Sum Insured: {totalSumInsured}");
      Console.WriteLine($"Total Risk Premium {totalPremium}");
      Console.WriteLine($"Average Premium for Every Odd Risk: {}");

      Console.ReadLine();
    }
  }
}

