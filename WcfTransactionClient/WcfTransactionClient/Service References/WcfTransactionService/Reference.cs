﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfTransactionClient.WcfTransactionService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfTransactionService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateUser", ReplyAction="http://tempuri.org/IService1/CreateUserResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
        bool CreateUser(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateUser", ReplyAction="http://tempuri.org/IService1/CreateUserResponse")]
        System.Threading.Tasks.Task<bool> CreateUserAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateDefaultUser", ReplyAction="http://tempuri.org/IService1/CreateDefaultUserResponse")]
        bool CreateDefaultUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateDefaultUser", ReplyAction="http://tempuri.org/IService1/CreateDefaultUserResponse")]
        System.Threading.Tasks.Task<bool> CreateDefaultUserAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WcfTransactionClient.WcfTransactionService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WcfTransactionClient.WcfTransactionService.IService1>, WcfTransactionClient.WcfTransactionService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CreateUser(string name) {
            return base.Channel.CreateUser(name);
        }
        
        public System.Threading.Tasks.Task<bool> CreateUserAsync(string name) {
            return base.Channel.CreateUserAsync(name);
        }
        
        public bool CreateDefaultUser() {
            return base.Channel.CreateDefaultUser();
        }
        
        public System.Threading.Tasks.Task<bool> CreateDefaultUserAsync() {
            return base.Channel.CreateDefaultUserAsync();
        }
    }
}