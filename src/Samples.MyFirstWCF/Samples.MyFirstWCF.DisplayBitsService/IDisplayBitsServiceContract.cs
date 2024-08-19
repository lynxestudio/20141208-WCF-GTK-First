using System;
using System.ServiceModel;

namespace Samples.MyFirstWCF.DisplayBitsService
{
	[ServiceContract]
	public interface IDisplayBitsServiceContract
	{
		[OperationContract]
		string DisplayToBits (int i);
	}
}

