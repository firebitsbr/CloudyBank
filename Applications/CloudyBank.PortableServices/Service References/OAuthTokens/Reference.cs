//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudyBank.PortableServices.OAuthTokens {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TokenDto", Namespace="http://schemas.datacontract.org/2004/07/CloudyBank.Dto")]
    public partial class TokenDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string ApplicationNameField;
        
        private int IdField;
        
        private string ScopeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationName {
            get {
                return this.ApplicationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ApplicationNameField, value) != true)) {
                    this.ApplicationNameField = value;
                    this.RaisePropertyChanged("ApplicationName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Scope {
            get {
                return this.ScopeField;
            }
            set {
                if ((object.ReferenceEquals(this.ScopeField, value) != true)) {
                    this.ScopeField = value;
                    this.RaisePropertyChanged("Scope");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="OAuthTokens.WCFOAuthManagementService")]
    public interface WCFOAuthManagementService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:WCFOAuthManagementService/InvalidateToken", ReplyAction="urn:WCFOAuthManagementService/InvalidateTokenResponse")]
        System.IAsyncResult BeginInvalidateToken(int tokenID, System.AsyncCallback callback, object asyncState);
        
        bool EndInvalidateToken(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:WCFOAuthManagementService/GetTokensForCustomer", ReplyAction="urn:WCFOAuthManagementService/GetTokensForCustomerResponse")]
        System.IAsyncResult BeginGetTokensForCustomer(int customerID, System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<CloudyBank.PortableServices.OAuthTokens.TokenDto> EndGetTokensForCustomer(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WCFOAuthManagementServiceChannel : CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InvalidateTokenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public InvalidateTokenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetTokensForCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetTokensForCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<CloudyBank.PortableServices.OAuthTokens.TokenDto> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<CloudyBank.PortableServices.OAuthTokens.TokenDto>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFOAuthManagementServiceClient : System.ServiceModel.ClientBase<CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService>, CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService {
        
        private BeginOperationDelegate onBeginInvalidateTokenDelegate;
        
        private EndOperationDelegate onEndInvalidateTokenDelegate;
        
        private System.Threading.SendOrPostCallback onInvalidateTokenCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetTokensForCustomerDelegate;
        
        private EndOperationDelegate onEndGetTokensForCustomerDelegate;
        
        private System.Threading.SendOrPostCallback onGetTokensForCustomerCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public WCFOAuthManagementServiceClient() {
        }
        
        public WCFOAuthManagementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFOAuthManagementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFOAuthManagementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFOAuthManagementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<InvalidateTokenCompletedEventArgs> InvalidateTokenCompleted;
        
        public event System.EventHandler<GetTokensForCustomerCompletedEventArgs> GetTokensForCustomerCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService.BeginInvalidateToken(int tokenID, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginInvalidateToken(tokenID, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService.EndInvalidateToken(System.IAsyncResult result) {
            return base.Channel.EndInvalidateToken(result);
        }
        
        private System.IAsyncResult OnBeginInvalidateToken(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int tokenID = ((int)(inValues[0]));
            return ((CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService)(this)).BeginInvalidateToken(tokenID, callback, asyncState);
        }
        
        private object[] OnEndInvalidateToken(System.IAsyncResult result) {
            bool retVal = ((CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService)(this)).EndInvalidateToken(result);
            return new object[] {
                    retVal};
        }
        
        private void OnInvalidateTokenCompleted(object state) {
            if ((this.InvalidateTokenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.InvalidateTokenCompleted(this, new InvalidateTokenCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void InvalidateTokenAsync(int tokenID) {
            this.InvalidateTokenAsync(tokenID, null);
        }
        
        public void InvalidateTokenAsync(int tokenID, object userState) {
            if ((this.onBeginInvalidateTokenDelegate == null)) {
                this.onBeginInvalidateTokenDelegate = new BeginOperationDelegate(this.OnBeginInvalidateToken);
            }
            if ((this.onEndInvalidateTokenDelegate == null)) {
                this.onEndInvalidateTokenDelegate = new EndOperationDelegate(this.OnEndInvalidateToken);
            }
            if ((this.onInvalidateTokenCompletedDelegate == null)) {
                this.onInvalidateTokenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnInvalidateTokenCompleted);
            }
            base.InvokeAsync(this.onBeginInvalidateTokenDelegate, new object[] {
                        tokenID}, this.onEndInvalidateTokenDelegate, this.onInvalidateTokenCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService.BeginGetTokensForCustomer(int customerID, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetTokensForCustomer(customerID, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.Generic.List<CloudyBank.PortableServices.OAuthTokens.TokenDto> CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService.EndGetTokensForCustomer(System.IAsyncResult result) {
            return base.Channel.EndGetTokensForCustomer(result);
        }
        
        private System.IAsyncResult OnBeginGetTokensForCustomer(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int customerID = ((int)(inValues[0]));
            return ((CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService)(this)).BeginGetTokensForCustomer(customerID, callback, asyncState);
        }
        
        private object[] OnEndGetTokensForCustomer(System.IAsyncResult result) {
            System.Collections.Generic.List<CloudyBank.PortableServices.OAuthTokens.TokenDto> retVal = ((CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService)(this)).EndGetTokensForCustomer(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetTokensForCustomerCompleted(object state) {
            if ((this.GetTokensForCustomerCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetTokensForCustomerCompleted(this, new GetTokensForCustomerCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetTokensForCustomerAsync(int customerID) {
            this.GetTokensForCustomerAsync(customerID, null);
        }
        
        public void GetTokensForCustomerAsync(int customerID, object userState) {
            if ((this.onBeginGetTokensForCustomerDelegate == null)) {
                this.onBeginGetTokensForCustomerDelegate = new BeginOperationDelegate(this.OnBeginGetTokensForCustomer);
            }
            if ((this.onEndGetTokensForCustomerDelegate == null)) {
                this.onEndGetTokensForCustomerDelegate = new EndOperationDelegate(this.OnEndGetTokensForCustomer);
            }
            if ((this.onGetTokensForCustomerCompletedDelegate == null)) {
                this.onGetTokensForCustomerCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetTokensForCustomerCompleted);
            }
            base.InvokeAsync(this.onBeginGetTokensForCustomerDelegate, new object[] {
                        customerID}, this.onEndGetTokensForCustomerDelegate, this.onGetTokensForCustomerCompletedDelegate, userState);
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
        
        protected override CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService CreateChannel() {
            return new WCFOAuthManagementServiceClientChannel(this);
        }
        
        private class WCFOAuthManagementServiceClientChannel : ChannelBase<CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService>, CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService {
            
            public WCFOAuthManagementServiceClientChannel(System.ServiceModel.ClientBase<CloudyBank.PortableServices.OAuthTokens.WCFOAuthManagementService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginInvalidateToken(int tokenID, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = tokenID;
                System.IAsyncResult _result = base.BeginInvoke("InvalidateToken", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndInvalidateToken(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("InvalidateToken", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetTokensForCustomer(int customerID, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = customerID;
                System.IAsyncResult _result = base.BeginInvoke("GetTokensForCustomer", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.Generic.List<CloudyBank.PortableServices.OAuthTokens.TokenDto> EndGetTokensForCustomer(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.Generic.List<CloudyBank.PortableServices.OAuthTokens.TokenDto> _result = ((System.Collections.Generic.List<CloudyBank.PortableServices.OAuthTokens.TokenDto>)(base.EndInvoke("GetTokensForCustomer", _args, result)));
                return _result;
            }
        }
    }
}
