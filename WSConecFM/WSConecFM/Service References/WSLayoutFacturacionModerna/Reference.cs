﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.17929
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSConecFM.WSLayoutFacturacionModerna {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="WSLayoutFacturacionModerna.Timbrado_ManagerPort")]
    public interface Timbrado_ManagerPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        object requestTimbrarCFDI(requestTimbrarCFDI request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<object> requestTimbrarCFDIAsync(requestTimbrarCFDI request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        object requestCancelarCFDI(requestCancelarCFDI request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<object> requestCancelarCFDIAsync(requestCancelarCFDI request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        object activarCancelacion(activarCancelacion request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<object> activarCancelacionAsync(activarCancelacion request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Timbrado_ManagerPortChannel : WSConecFM.WSLayoutFacturacionModerna.Timbrado_ManagerPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Timbrado_ManagerPortClient : System.ServiceModel.ClientBase<WSConecFM.WSLayoutFacturacionModerna.Timbrado_ManagerPort>, WSConecFM.WSLayoutFacturacionModerna.Timbrado_ManagerPort {
        
        public Timbrado_ManagerPortClient() {
        }
        
        public Timbrado_ManagerPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Timbrado_ManagerPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Timbrado_ManagerPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Timbrado_ManagerPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public object requestTimbrarCFDI(requestTimbrarCFDI request)
        {
            return base.Channel.requestTimbrarCFDI(request);
        }

        public System.Threading.Tasks.Task<object> requestTimbrarCFDIAsync(requestTimbrarCFDI request)
        {
            return base.Channel.requestTimbrarCFDIAsync(request);
        }

        public object requestCancelarCFDI(requestCancelarCFDI request)
        {
            return base.Channel.requestCancelarCFDI(request);
        }

        public System.Threading.Tasks.Task<object> requestCancelarCFDIAsync(requestCancelarCFDI request)
        {
            return base.Channel.requestCancelarCFDIAsync(request);
        }

        public object activarCancelacion(activarCancelacion request)
        {
            return base.Channel.activarCancelacion(request);
        }

        public System.Threading.Tasks.Task<object> activarCancelacionAsync(activarCancelacion request)
        {
            return base.Channel.activarCancelacionAsync(request);
        }
    }
}
