using System.Collections.Generic;
using System.Xml.Serialization;

namespace Common.Models
{
	public class Risk
	{
		[XmlElement(ElementName = "riskSequence")]
		public string RiskSequence { get; set; }
		[XmlElement(ElementName = "riskName")]
		public string RiskName { get; set; }
		[XmlElement(ElementName = "sumInsured")]
		public decimal SumInsured { get; set; }
		[XmlElement(ElementName = "premium")]
		public decimal Premium { get; set; }
	}

	[XmlRoot(ElementName = "risks")]
	public class Risks
	{
		[XmlElement(ElementName = "risk")]
		public List<Risk> Risk { get; set; }
	}

	[XmlRoot(ElementName = "client")]
	public class Client
	{
		[XmlElement(ElementName = "code")]
		public string Code { get; set; }
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "productName")]
		public string ProductName { get; set; }
		[XmlElement(ElementName = "risks")]
		public Risks Risks { get; set; }
	}

	[XmlRoot("clients")]
	public class Clients
	{
		[XmlElement(ElementName = "client")]
		public Client Client { get; set; }
	}
}