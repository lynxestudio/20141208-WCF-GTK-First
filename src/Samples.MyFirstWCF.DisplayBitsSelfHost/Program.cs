using System;
using System.ServiceModel;
using System.Net;
using Samples.MyFirstWCF.DisplayBitsService;

namespace Samples.MyFirstWCF.DisplayBitsSelfHost
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Uri baseAddress = new Uri("http://localhost:8080/Samples");
			Type instanceType = typeof(DisplayBitsServiceImplementation);
			ServiceHost host = new ServiceHost(instanceType,baseAddress);
			try
			{
				using(host)
				{
				Type contractType = typeof(IDisplayBitsServiceContract);
				string relativeAddress = "DisplayBitsService";
				host.AddServiceEndpoint(contractType,
									new BasicHttpBinding(),
									relativeAddress);
				host.Open();
				Console.WriteLine("DisplayBitsService running. Press <ENTER> to quit.");
				Console.ReadLine();
				host.Close();
				}
			}catch(Exception ex)
			{
			Console.WriteLine(ex.Message);
			}
		}
	}
}
