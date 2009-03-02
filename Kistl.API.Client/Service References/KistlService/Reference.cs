//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.API.Client.KistlService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KistlService.IKistlService")]
    public interface IKistlService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKistlService/GetList", ReplyAction="http://tempuri.org/IKistlService/GetListResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IKistlService/GetListExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        string GetList(Kistl.API.SerializableType type, int maxListCount, Kistl.API.SerializableExpression filter, Kistl.API.SerializableExpression[] orderBy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKistlService/GetListOf", ReplyAction="http://tempuri.org/IKistlService/GetListOfResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IKistlService/GetListOfExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        string GetListOf(Kistl.API.SerializableType type, int ID, string property);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKistlService/GetObject", ReplyAction="http://tempuri.org/IKistlService/GetObjectResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IKistlService/GetObjectExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        string GetObject(Kistl.API.SerializableType type, int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKistlService/SetObject", ReplyAction="http://tempuri.org/IKistlService/SetObjectResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IKistlService/SetObjectExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        string SetObject(Kistl.API.SerializableType type, string xmlObj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKistlService/FetchRelation", ReplyAction="http://tempuri.org/IKistlService/FetchRelationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IKistlService/FetchRelationExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        string FetchRelation(Kistl.API.SerializableType ceType, int role, int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKistlService/Generate", ReplyAction="http://tempuri.org/IKistlService/GenerateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IKistlService/GenerateExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        void Generate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKistlService/HelloWorld", ReplyAction="http://tempuri.org/IKistlService/HelloWorldResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IKistlService/HelloWorldExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        string HelloWorld(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IKistlServiceChannel : Kistl.API.Client.KistlService.IKistlService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class KistlServiceClient : System.ServiceModel.ClientBase<Kistl.API.Client.KistlService.IKistlService>, Kistl.API.Client.KistlService.IKistlService {
        
        public KistlServiceClient() {
        }
        
        public KistlServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KistlServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KistlServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KistlServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetList(Kistl.API.SerializableType type, int maxListCount, Kistl.API.SerializableExpression filter, Kistl.API.SerializableExpression[] orderBy) {
            return base.Channel.GetList(type, maxListCount, filter, orderBy);
        }
        
        public string GetListOf(Kistl.API.SerializableType type, int ID, string property) {
            return base.Channel.GetListOf(type, ID, property);
        }
        
        public string GetObject(Kistl.API.SerializableType type, int ID) {
            return base.Channel.GetObject(type, ID);
        }
        
        public string SetObject(Kistl.API.SerializableType type, string xmlObj) {
            return base.Channel.SetObject(type, xmlObj);
        }
        
        public string FetchRelation(Kistl.API.SerializableType ceType, int role, int ID) {
            return base.Channel.FetchRelation(ceType, role, ID);
        }
        
        public void Generate() {
            base.Channel.Generate();
        }
        
        public string HelloWorld(string name) {
            return base.Channel.HelloWorld(name);
        }
    }
}
