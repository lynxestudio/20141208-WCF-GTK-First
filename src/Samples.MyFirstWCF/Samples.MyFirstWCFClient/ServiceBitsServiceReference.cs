// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



[System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org/", ConfigurationName="IDisplayBitsServiceContract")]
public interface IDisplayBitsServiceContract {
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDisplayBitsServiceContract/DisplayToBits", ReplyAction="http://tempuri.org/IDisplayBitsServiceContract/DisplayToBitsResponse")]
    string DisplayToBits(int i);
}

public interface IDisplayBitsServiceContractChannel : IDisplayBitsServiceContract, System.ServiceModel.IClientChannel {
}

public class DisplayBitsServiceContractClient : System.ServiceModel.ClientBase<IDisplayBitsServiceContract>, IDisplayBitsServiceContract {
    
    public DisplayBitsServiceContractClient() {
    }
    
    public DisplayBitsServiceContractClient(string endpointConfigurationName) : 
            base(endpointConfigurationName) {
    }
    
    public DisplayBitsServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
    }
    
    public DisplayBitsServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
    }
    
    public DisplayBitsServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpoint) : 
            base(binding, endpoint) {
    }
    
    public string DisplayToBits(int i) {
        return base.Channel.DisplayToBits(i);
    }
}
