﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zetbox.API.Client.ZetboxService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dasz.at/Zetbox/", ConfigurationName="ZetboxService.IZetboxService", SessionMode=System.ServiceModel.SessionMode.NotAllowed)]
    public interface IZetboxService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dasz.at/Zetbox/IZetboxService/SetObjects", ReplyAction="http://dasz.at/Zetbox/IZetboxService/SetObjectsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://dasz.at/Zetbox/IZetboxService/SetObjectsExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.FaultContractAttribute(typeof(Zetbox.API.ZetboxContextExceptionMessage), Action="http://dasz.at/Zetbox/IZetboxService/SetObjectsZetboxContextExceptionMessageFault" +
            "", Name="ZetboxContextExceptionMessage")]
        byte[] SetObjects(System.Guid version, byte[] msg, Zetbox.API.ObjectNotificationRequest[] notificationRequests);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dasz.at/Zetbox/IZetboxService/GetObjects", ReplyAction="http://dasz.at/Zetbox/IZetboxService/GetObjectsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Zetbox.API.InvalidZetboxGeneratedVersionException), Action="http://dasz.at/Zetbox/IZetboxService/GetObjectsInvalidZetboxGeneratedVersionExcep" +
            "tionFault", Name="InvalidZetboxGeneratedVersionException", Namespace="http://schemas.datacontract.org/2004/07/Zetbox.API")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://dasz.at/Zetbox/IZetboxService/GetObjectsExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Zetbox.API.SerializableCompoundExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Zetbox.API.SerializableNewExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Zetbox.API.SerializableUnaryExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Zetbox.API.SerializableBinaryExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Zetbox.API.SerializableLambdaExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Zetbox.API.SerializableMemberExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Zetbox.API.SerializableMethodCallExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Zetbox.API.SerializableParameterExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Zetbox.API.SerializableContextSourceExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Zetbox.API.SerializableConditionalExpression))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Zetbox.API.SerializableConstantExpression))]
        byte[] GetObjects(System.Guid version, Zetbox.API.SerializableExpression query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dasz.at/Zetbox/IZetboxService/GetListOf", ReplyAction="http://dasz.at/Zetbox/IZetboxService/GetListOfResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://dasz.at/Zetbox/IZetboxService/GetListOfExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.FaultContractAttribute(typeof(Zetbox.API.InvalidZetboxGeneratedVersionException), Action="http://dasz.at/Zetbox/IZetboxService/GetListOfInvalidZetboxGeneratedVersionExcept" +
            "ionFault", Name="InvalidZetboxGeneratedVersionException", Namespace="http://schemas.datacontract.org/2004/07/Zetbox.API")]
        byte[] GetListOf(System.Guid version, Zetbox.API.SerializableType type, int ID, string property);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dasz.at/Zetbox/IZetboxService/FetchRelation", ReplyAction="http://dasz.at/Zetbox/IZetboxService/FetchRelationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://dasz.at/Zetbox/IZetboxService/FetchRelationExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.FaultContractAttribute(typeof(Zetbox.API.InvalidZetboxGeneratedVersionException), Action="http://dasz.at/Zetbox/IZetboxService/FetchRelationInvalidZetboxGeneratedVersionEx" +
            "ceptionFault", Name="InvalidZetboxGeneratedVersionException", Namespace="http://schemas.datacontract.org/2004/07/Zetbox.API")]
        byte[] FetchRelation(System.Guid version, System.Guid relId, int role, int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dasz.at/Zetbox/IZetboxService/GetBlobStream", ReplyAction="http://dasz.at/Zetbox/IZetboxService/GetBlobStreamResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://dasz.at/Zetbox/IZetboxService/GetBlobStreamExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.FaultContractAttribute(typeof(Zetbox.API.InvalidZetboxGeneratedVersionException), Action="http://dasz.at/Zetbox/IZetboxService/GetBlobStreamInvalidZetboxGeneratedVersionEx" +
            "ceptionFault", Name="InvalidZetboxGeneratedVersionException", Namespace="http://schemas.datacontract.org/2004/07/Zetbox.API")]
        System.IO.Stream GetBlobStream(System.Guid version, int ID);
        
        // CODEGEN: Generating message contract since the wrapper name (BlobMessage) of message BlobMessage does not match the default value (SetBlobStream)
        [System.ServiceModel.OperationContractAttribute(Action="http://dasz.at/Zetbox/IZetboxService/SetBlobStream", ReplyAction="http://dasz.at/Zetbox/IZetboxService/SetBlobStreamResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Zetbox.API.InvalidZetboxGeneratedVersionException), Action="http://dasz.at/Zetbox/IZetboxService/SetBlobStreamInvalidZetboxGeneratedVersionEx" +
            "ceptionFault", Name="InvalidZetboxGeneratedVersionException", Namespace="http://schemas.datacontract.org/2004/07/Zetbox.API")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://dasz.at/Zetbox/IZetboxService/SetBlobStreamExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        Zetbox.API.Client.ZetboxService.BlobResponse SetBlobStream(Zetbox.API.Client.ZetboxService.BlobMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dasz.at/Zetbox/IZetboxService/InvokeServerMethod", ReplyAction="http://dasz.at/Zetbox/IZetboxService/InvokeServerMethodResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://dasz.at/Zetbox/IZetboxService/InvokeServerMethodExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        [System.ServiceModel.FaultContractAttribute(typeof(Zetbox.API.InvalidZetboxGeneratedVersionException), Action="http://dasz.at/Zetbox/IZetboxService/InvokeServerMethodInvalidZetboxGeneratedVers" +
            "ionExceptionFault", Name="InvalidZetboxGeneratedVersionException", Namespace="http://schemas.datacontract.org/2004/07/Zetbox.API")]
        byte[] InvokeServerMethod(out byte[] retChangedObjects, System.Guid version, Zetbox.API.SerializableType type, int ID, string method, Zetbox.API.SerializableType[] parameterTypes, byte[] parameter, byte[] changedObjects, Zetbox.API.ObjectNotificationRequest[] notificationRequests);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="BlobMessage", WrapperNamespace="http://dasz.at/Zetbox/", IsWrapped=true)]
    public partial class BlobMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://dasz.at/Zetbox/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://dasz.at/Zetbox/")]
        public string MimeType;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://dasz.at/Zetbox/")]
        public System.Guid Version;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dasz.at/Zetbox/", Order=0)]
        public System.IO.Stream Stream;
        
        public BlobMessage() {
        }
        
        public BlobMessage(string FileName, string MimeType, System.Guid Version, System.IO.Stream Stream) {
            this.FileName = FileName;
            this.MimeType = MimeType;
            this.Version = Version;
            this.Stream = Stream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="BlobResponse", WrapperNamespace="http://dasz.at/Zetbox/", IsWrapped=true)]
    public partial class BlobResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://dasz.at/Zetbox/")]
        public int ID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dasz.at/Zetbox/", Order=0)]
        public System.IO.Stream BlobInstance;
        
        public BlobResponse() {
        }
        
        public BlobResponse(int ID, System.IO.Stream BlobInstance) {
            this.ID = ID;
            this.BlobInstance = BlobInstance;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IZetboxServiceChannel : Zetbox.API.Client.ZetboxService.IZetboxService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZetboxServiceClient : System.ServiceModel.ClientBase<Zetbox.API.Client.ZetboxService.IZetboxService>, Zetbox.API.Client.ZetboxService.IZetboxService {
        
        public ZetboxServiceClient() {
        }
        
        public ZetboxServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ZetboxServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZetboxServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZetboxServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public byte[] SetObjects(System.Guid version, byte[] msg, Zetbox.API.ObjectNotificationRequest[] notificationRequests) {
            return base.Channel.SetObjects(version, msg, notificationRequests);
        }
        
        public byte[] GetObjects(System.Guid version, Zetbox.API.SerializableExpression query) {
            return base.Channel.GetObjects(version, query);
        }
        
        public byte[] GetListOf(System.Guid version, Zetbox.API.SerializableType type, int ID, string property) {
            return base.Channel.GetListOf(version, type, ID, property);
        }
        
        public byte[] FetchRelation(System.Guid version, System.Guid relId, int role, int ID) {
            return base.Channel.FetchRelation(version, relId, role, ID);
        }
        
        public System.IO.Stream GetBlobStream(System.Guid version, int ID) {
            return base.Channel.GetBlobStream(version, ID);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Zetbox.API.Client.ZetboxService.BlobResponse Zetbox.API.Client.ZetboxService.IZetboxService.SetBlobStream(Zetbox.API.Client.ZetboxService.BlobMessage request) {
            return base.Channel.SetBlobStream(request);
        }
        
        public int SetBlobStream(string FileName, string MimeType, System.Guid Version, System.IO.Stream Stream, out System.IO.Stream BlobInstance) {
            Zetbox.API.Client.ZetboxService.BlobMessage inValue = new Zetbox.API.Client.ZetboxService.BlobMessage();
            inValue.FileName = FileName;
            inValue.MimeType = MimeType;
            inValue.Version = Version;
            inValue.Stream = Stream;
            Zetbox.API.Client.ZetboxService.BlobResponse retVal = ((Zetbox.API.Client.ZetboxService.IZetboxService)(this)).SetBlobStream(inValue);
            BlobInstance = retVal.BlobInstance;
            return retVal.ID;
        }
        
        public byte[] InvokeServerMethod(out byte[] retChangedObjects, System.Guid version, Zetbox.API.SerializableType type, int ID, string method, Zetbox.API.SerializableType[] parameterTypes, byte[] parameter, byte[] changedObjects, Zetbox.API.ObjectNotificationRequest[] notificationRequests) {
            return base.Channel.InvokeServerMethod(out retChangedObjects, version, type, ID, method, parameterTypes, parameter, changedObjects, notificationRequests);
        }
    }
}
