﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplicationClient.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.MyCalculatorTest")]
    public interface MyCalculatorTest {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyCalculatorTest/Add", ReplyAction="http://tempuri.org/MyCalculatorTest/AddResponse")]
        double Add(double x, double y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyCalculatorTestChannel : ConsoleApplicationClient.ServiceReference2.MyCalculatorTest, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyCalculatorTestClient : System.ServiceModel.ClientBase<ConsoleApplicationClient.ServiceReference2.MyCalculatorTest>, ConsoleApplicationClient.ServiceReference2.MyCalculatorTest {
        
        public MyCalculatorTestClient() {
        }
        
        public MyCalculatorTestClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyCalculatorTestClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCalculatorTestClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCalculatorTestClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double x, double y) {
            return base.Channel.Add(x, y);
        }
    }
}
