﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TA_PBO.TranslatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", ConfigurationName="TranslatorService.LanguageService")]
    public interface LanguageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguages", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguagesRespon" +
            "se")]
        string[] GetLanguages(string appId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguages", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguagesRespon" +
            "se")]
        System.Threading.Tasks.Task<string[]> GetLanguagesAsync(string appId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguageNames", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguageNamesRe" +
            "sponse")]
        string[] GetLanguageNames(string appId, string locale);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguageNames", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguageNamesRe" +
            "sponse")]
        System.Threading.Tasks.Task<string[]> GetLanguageNamesAsync(string appId, string locale);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/Detect", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/DetectResponse")]
        string Detect(string appId, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/Detect", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/DetectResponse")]
        System.Threading.Tasks.Task<string> DetectAsync(string appId, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/Translate", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/TranslateResponse")]
        string Translate(string appId, string text, string from, string to);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/Translate", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/TranslateResponse")]
        System.Threading.Tasks.Task<string> TranslateAsync(string appId, string text, string from, string to);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LanguageServiceChannel : TA_PBO.TranslatorService.LanguageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LanguageServiceClient : System.ServiceModel.ClientBase<TA_PBO.TranslatorService.LanguageService>, TA_PBO.TranslatorService.LanguageService {
        
        public LanguageServiceClient() {
        }
        
        public LanguageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LanguageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LanguageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LanguageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetLanguages(string appId) {
            return base.Channel.GetLanguages(appId);
        }
        
        public System.Threading.Tasks.Task<string[]> GetLanguagesAsync(string appId) {
            return base.Channel.GetLanguagesAsync(appId);
        }
        
        public string[] GetLanguageNames(string appId, string locale) {
            return base.Channel.GetLanguageNames(appId, locale);
        }
        
        public System.Threading.Tasks.Task<string[]> GetLanguageNamesAsync(string appId, string locale) {
            return base.Channel.GetLanguageNamesAsync(appId, locale);
        }
        
        public string Detect(string appId, string text) {
            return base.Channel.Detect(appId, text);
        }
        
        public System.Threading.Tasks.Task<string> DetectAsync(string appId, string text) {
            return base.Channel.DetectAsync(appId, text);
        }
        
        public string Translate(string appId, string text, string from, string to) {
            return base.Channel.Translate(appId, text, from, to);
        }
        
        public System.Threading.Tasks.Task<string> TranslateAsync(string appId, string text, string from, string to) {
            return base.Channel.TranslateAsync(appId, text, from, to);
        }
    }
}
