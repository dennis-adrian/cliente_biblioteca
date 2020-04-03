﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAP4.ClienteLibros.ClientesService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Clientes", Namespace="http://schemas.datacontract.org/2004/07/DAP4.Biblioteca.Dominio")]
    [System.SerializableAttribute()]
    public partial class Clientes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cliente_apellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cliente_domicilioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cliente_emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime cliente_fecha_nacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cliente_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cliente_telefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_clienteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cliente_apellido {
            get {
                return this.cliente_apellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.cliente_apellidoField, value) != true)) {
                    this.cliente_apellidoField = value;
                    this.RaisePropertyChanged("cliente_apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cliente_domicilio {
            get {
                return this.cliente_domicilioField;
            }
            set {
                if ((object.ReferenceEquals(this.cliente_domicilioField, value) != true)) {
                    this.cliente_domicilioField = value;
                    this.RaisePropertyChanged("cliente_domicilio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cliente_email {
            get {
                return this.cliente_emailField;
            }
            set {
                if ((object.ReferenceEquals(this.cliente_emailField, value) != true)) {
                    this.cliente_emailField = value;
                    this.RaisePropertyChanged("cliente_email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime cliente_fecha_nac {
            get {
                return this.cliente_fecha_nacField;
            }
            set {
                if ((this.cliente_fecha_nacField.Equals(value) != true)) {
                    this.cliente_fecha_nacField = value;
                    this.RaisePropertyChanged("cliente_fecha_nac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cliente_nombre {
            get {
                return this.cliente_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.cliente_nombreField, value) != true)) {
                    this.cliente_nombreField = value;
                    this.RaisePropertyChanged("cliente_nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cliente_telefono {
            get {
                return this.cliente_telefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.cliente_telefonoField, value) != true)) {
                    this.cliente_telefonoField = value;
                    this.RaisePropertyChanged("cliente_telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_cliente {
            get {
                return this.id_clienteField;
            }
            set {
                if ((this.id_clienteField.Equals(value) != true)) {
                    this.id_clienteField = value;
                    this.RaisePropertyChanged("id_cliente");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientesService.IClientesService")]
    public interface IClientesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/ObtenerClientePorId", ReplyAction="http://tempuri.org/IClientesService/ObtenerClientePorIdResponse")]
        DAP4.ClienteLibros.ClientesService.Clientes ObtenerClientePorId(int id_cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/ObtenerClientePorId", ReplyAction="http://tempuri.org/IClientesService/ObtenerClientePorIdResponse")]
        System.Threading.Tasks.Task<DAP4.ClienteLibros.ClientesService.Clientes> ObtenerClientePorIdAsync(int id_cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/ObtenerClientePorApellido", ReplyAction="http://tempuri.org/IClientesService/ObtenerClientePorApellidoResponse")]
        DAP4.ClienteLibros.ClientesService.Clientes ObtenerClientePorApellido(string cliente_apellido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/ObtenerClientePorApellido", ReplyAction="http://tempuri.org/IClientesService/ObtenerClientePorApellidoResponse")]
        System.Threading.Tasks.Task<DAP4.ClienteLibros.ClientesService.Clientes> ObtenerClientePorApellidoAsync(string cliente_apellido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/ListarClientes", ReplyAction="http://tempuri.org/IClientesService/ListarClientesResponse")]
        DAP4.ClienteLibros.ClientesService.Clientes[] ListarClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/ListarClientes", ReplyAction="http://tempuri.org/IClientesService/ListarClientesResponse")]
        System.Threading.Tasks.Task<DAP4.ClienteLibros.ClientesService.Clientes[]> ListarClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/InsertarCliente", ReplyAction="http://tempuri.org/IClientesService/InsertarClienteResponse")]
        DAP4.ClienteLibros.ClientesService.Clientes InsertarCliente(DAP4.ClienteLibros.ClientesService.Clientes cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/InsertarCliente", ReplyAction="http://tempuri.org/IClientesService/InsertarClienteResponse")]
        System.Threading.Tasks.Task<DAP4.ClienteLibros.ClientesService.Clientes> InsertarClienteAsync(DAP4.ClienteLibros.ClientesService.Clientes cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/ActualizarCliente", ReplyAction="http://tempuri.org/IClientesService/ActualizarClienteResponse")]
        DAP4.ClienteLibros.ClientesService.Clientes ActualizarCliente(DAP4.ClienteLibros.ClientesService.Clientes cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/ActualizarCliente", ReplyAction="http://tempuri.org/IClientesService/ActualizarClienteResponse")]
        System.Threading.Tasks.Task<DAP4.ClienteLibros.ClientesService.Clientes> ActualizarClienteAsync(DAP4.ClienteLibros.ClientesService.Clientes cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/EliminarCliente", ReplyAction="http://tempuri.org/IClientesService/EliminarClienteResponse")]
        bool EliminarCliente(int id_cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientesService/EliminarCliente", ReplyAction="http://tempuri.org/IClientesService/EliminarClienteResponse")]
        System.Threading.Tasks.Task<bool> EliminarClienteAsync(int id_cliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientesServiceChannel : DAP4.ClienteLibros.ClientesService.IClientesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientesServiceClient : System.ServiceModel.ClientBase<DAP4.ClienteLibros.ClientesService.IClientesService>, DAP4.ClienteLibros.ClientesService.IClientesService {
        
        public ClientesServiceClient() {
        }
        
        public ClientesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DAP4.ClienteLibros.ClientesService.Clientes ObtenerClientePorId(int id_cliente) {
            return base.Channel.ObtenerClientePorId(id_cliente);
        }
        
        public System.Threading.Tasks.Task<DAP4.ClienteLibros.ClientesService.Clientes> ObtenerClientePorIdAsync(int id_cliente) {
            return base.Channel.ObtenerClientePorIdAsync(id_cliente);
        }
        
        public DAP4.ClienteLibros.ClientesService.Clientes ObtenerClientePorApellido(string cliente_apellido) {
            return base.Channel.ObtenerClientePorApellido(cliente_apellido);
        }
        
        public System.Threading.Tasks.Task<DAP4.ClienteLibros.ClientesService.Clientes> ObtenerClientePorApellidoAsync(string cliente_apellido) {
            return base.Channel.ObtenerClientePorApellidoAsync(cliente_apellido);
        }
        
        public DAP4.ClienteLibros.ClientesService.Clientes[] ListarClientes() {
            return base.Channel.ListarClientes();
        }
        
        public System.Threading.Tasks.Task<DAP4.ClienteLibros.ClientesService.Clientes[]> ListarClientesAsync() {
            return base.Channel.ListarClientesAsync();
        }
        
        public DAP4.ClienteLibros.ClientesService.Clientes InsertarCliente(DAP4.ClienteLibros.ClientesService.Clientes cliente) {
            return base.Channel.InsertarCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<DAP4.ClienteLibros.ClientesService.Clientes> InsertarClienteAsync(DAP4.ClienteLibros.ClientesService.Clientes cliente) {
            return base.Channel.InsertarClienteAsync(cliente);
        }
        
        public DAP4.ClienteLibros.ClientesService.Clientes ActualizarCliente(DAP4.ClienteLibros.ClientesService.Clientes cliente) {
            return base.Channel.ActualizarCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<DAP4.ClienteLibros.ClientesService.Clientes> ActualizarClienteAsync(DAP4.ClienteLibros.ClientesService.Clientes cliente) {
            return base.Channel.ActualizarClienteAsync(cliente);
        }
        
        public bool EliminarCliente(int id_cliente) {
            return base.Channel.EliminarCliente(id_cliente);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarClienteAsync(int id_cliente) {
            return base.Channel.EliminarClienteAsync(id_cliente);
        }
    }
}
