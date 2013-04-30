//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudyBank.PortableServices.Logs {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="Logs.WCFLogService")]
    public interface WCFLogService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:WCFLogService/LogError", ReplyAction="urn:WCFLogService/LogErrorResponse")]
        System.IAsyncResult BeginLogError(string message, System.AsyncCallback callback, object asyncState);
        
        void EndLogError(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:WCFLogService/LogMessage", ReplyAction="urn:WCFLogService/LogMessageResponse")]
        System.IAsyncResult BeginLogMessage(string message, System.AsyncCallback callback, object asyncState);
        
        void EndLogMessage(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WCFLogServiceChannel : CloudyBank.PortableServices.Logs.WCFLogService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFLogServiceClient : System.ServiceModel.ClientBase<CloudyBank.PortableServices.Logs.WCFLogService>, CloudyBank.PortableServices.Logs.WCFLogService {
        
        private BeginOperationDelegate onBeginLogErrorDelegate;
        
        private EndOperationDelegate onEndLogErrorDelegate;
        
        private System.Threading.SendOrPostCallback onLogErrorCompletedDelegate;
        
        private BeginOperationDelegate onBeginLogMessageDelegate;
        
        private EndOperationDelegate onEndLogMessageDelegate;
        
        private System.Threading.SendOrPostCallback onLogMessageCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public WCFLogServiceClient() {
        }
        
        public WCFLogServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFLogServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFLogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFLogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> LogErrorCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> LogMessageCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CloudyBank.PortableServices.Logs.WCFLogService.BeginLogError(string message, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginLogError(message, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void CloudyBank.PortableServices.Logs.WCFLogService.EndLogError(System.IAsyncResult result) {
            base.Channel.EndLogError(result);
        }
        
        private System.IAsyncResult OnBeginLogError(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string message = ((string)(inValues[0]));
            return ((CloudyBank.PortableServices.Logs.WCFLogService)(this)).BeginLogError(message, callback, asyncState);
        }
        
        private object[] OnEndLogError(System.IAsyncResult result) {
            ((CloudyBank.PortableServices.Logs.WCFLogService)(this)).EndLogError(result);
            return null;
        }
        
        private void OnLogErrorCompleted(object state) {
            if ((this.LogErrorCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.LogErrorCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void LogErrorAsync(string message) {
            this.LogErrorAsync(message, null);
        }
        
        public void LogErrorAsync(string message, object userState) {
            if ((this.onBeginLogErrorDelegate == null)) {
                this.onBeginLogErrorDelegate = new BeginOperationDelegate(this.OnBeginLogError);
            }
            if ((this.onEndLogErrorDelegate == null)) {
                this.onEndLogErrorDelegate = new EndOperationDelegate(this.OnEndLogError);
            }
            if ((this.onLogErrorCompletedDelegate == null)) {
                this.onLogErrorCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnLogErrorCompleted);
            }
            base.InvokeAsync(this.onBeginLogErrorDelegate, new object[] {
                        message}, this.onEndLogErrorDelegate, this.onLogErrorCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CloudyBank.PortableServices.Logs.WCFLogService.BeginLogMessage(string message, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginLogMessage(message, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void CloudyBank.PortableServices.Logs.WCFLogService.EndLogMessage(System.IAsyncResult result) {
            base.Channel.EndLogMessage(result);
        }
        
        private System.IAsyncResult OnBeginLogMessage(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string message = ((string)(inValues[0]));
            return ((CloudyBank.PortableServices.Logs.WCFLogService)(this)).BeginLogMessage(message, callback, asyncState);
        }
        
        private object[] OnEndLogMessage(System.IAsyncResult result) {
            ((CloudyBank.PortableServices.Logs.WCFLogService)(this)).EndLogMessage(result);
            return null;
        }
        
        private void OnLogMessageCompleted(object state) {
            if ((this.LogMessageCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.LogMessageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void LogMessageAsync(string message) {
            this.LogMessageAsync(message, null);
        }
        
        public void LogMessageAsync(string message, object userState) {
            if ((this.onBeginLogMessageDelegate == null)) {
                this.onBeginLogMessageDelegate = new BeginOperationDelegate(this.OnBeginLogMessage);
            }
            if ((this.onEndLogMessageDelegate == null)) {
                this.onEndLogMessageDelegate = new EndOperationDelegate(this.OnEndLogMessage);
            }
            if ((this.onLogMessageCompletedDelegate == null)) {
                this.onLogMessageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnLogMessageCompleted);
            }
            base.InvokeAsync(this.onBeginLogMessageDelegate, new object[] {
                        message}, this.onEndLogMessageDelegate, this.onLogMessageCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override CloudyBank.PortableServices.Logs.WCFLogService CreateChannel() {
            return new WCFLogServiceClientChannel(this);
        }
        
        private class WCFLogServiceClientChannel : ChannelBase<CloudyBank.PortableServices.Logs.WCFLogService>, CloudyBank.PortableServices.Logs.WCFLogService {
            
            public WCFLogServiceClientChannel(System.ServiceModel.ClientBase<CloudyBank.PortableServices.Logs.WCFLogService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginLogError(string message, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = message;
                System.IAsyncResult _result = base.BeginInvoke("LogError", _args, callback, asyncState);
                return _result;
            }
            
            public void EndLogError(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("LogError", _args, result);
            }
            
            public System.IAsyncResult BeginLogMessage(string message, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = message;
                System.IAsyncResult _result = base.BeginInvoke("LogMessage", _args, callback, asyncState);
                return _result;
            }
            
            public void EndLogMessage(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("LogMessage", _args, result);
            }
        }
    }
}
