﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAP4.ClienteLibros.PrestamosService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Prestamos", Namespace="http://schemas.datacontract.org/2004/07/DAP4.Biblioteca.Dominio")]
    [System.SerializableAttribute()]
    public partial class Prestamos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cliente_apellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cliente_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_empleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_prestamoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string libro_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string prestamo_codigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime prestamo_devolucionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool prestamo_devueltoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime prestamo_fechaField;
        
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
        public int id_empleado {
            get {
                return this.id_empleadoField;
            }
            set {
                if ((this.id_empleadoField.Equals(value) != true)) {
                    this.id_empleadoField = value;
                    this.RaisePropertyChanged("id_empleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_prestamo {
            get {
                return this.id_prestamoField;
            }
            set {
                if ((this.id_prestamoField.Equals(value) != true)) {
                    this.id_prestamoField = value;
                    this.RaisePropertyChanged("id_prestamo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string libro_nombre {
            get {
                return this.libro_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.libro_nombreField, value) != true)) {
                    this.libro_nombreField = value;
                    this.RaisePropertyChanged("libro_nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string prestamo_codigo {
            get {
                return this.prestamo_codigoField;
            }
            set {
                if ((object.ReferenceEquals(this.prestamo_codigoField, value) != true)) {
                    this.prestamo_codigoField = value;
                    this.RaisePropertyChanged("prestamo_codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime prestamo_devolucion {
            get {
                return this.prestamo_devolucionField;
            }
            set {
                if ((this.prestamo_devolucionField.Equals(value) != true)) {
                    this.prestamo_devolucionField = value;
                    this.RaisePropertyChanged("prestamo_devolucion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool prestamo_devuelto {
            get {
                return this.prestamo_devueltoField;
            }
            set {
                if ((this.prestamo_devueltoField.Equals(value) != true)) {
                    this.prestamo_devueltoField = value;
                    this.RaisePropertyChanged("prestamo_devuelto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime prestamo_fecha {
            get {
                return this.prestamo_fechaField;
            }
            set {
                if ((this.prestamo_fechaField.Equals(value) != true)) {
                    this.prestamo_fechaField = value;
                    this.RaisePropertyChanged("prestamo_fecha");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PrestamosService.IPrestamosService")]
    public interface IPrestamosService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ObtenerPrestamoPorCodigo", ReplyAction="http://tempuri.org/IPrestamosService/ObtenerPrestamoPorCodigoResponse")]
        DAP4.ClienteLibros.PrestamosService.Prestamos ObtenerPrestamoPorCodigo(string codigo_prestamo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ObtenerPrestamoPorCodigo", ReplyAction="http://tempuri.org/IPrestamosService/ObtenerPrestamoPorCodigoResponse")]
        System.Threading.Tasks.Task<DAP4.ClienteLibros.PrestamosService.Prestamos> ObtenerPrestamoPorCodigoAsync(string codigo_prestamo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ListarPrestamos", ReplyAction="http://tempuri.org/IPrestamosService/ListarPrestamosResponse")]
        DAP4.ClienteLibros.PrestamosService.Prestamos[] ListarPrestamos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ListarPrestamos", ReplyAction="http://tempuri.org/IPrestamosService/ListarPrestamosResponse")]
        System.Threading.Tasks.Task<DAP4.ClienteLibros.PrestamosService.Prestamos[]> ListarPrestamosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/InsertarPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/InsertarPrestamoResponse")]
        DAP4.ClienteLibros.PrestamosService.Prestamos InsertarPrestamo(DAP4.ClienteLibros.PrestamosService.Prestamos prestamo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/InsertarPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/InsertarPrestamoResponse")]
        System.Threading.Tasks.Task<DAP4.ClienteLibros.PrestamosService.Prestamos> InsertarPrestamoAsync(DAP4.ClienteLibros.PrestamosService.Prestamos prestamo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ActualizarPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/ActualizarPrestamoResponse")]
        DAP4.ClienteLibros.PrestamosService.Prestamos ActualizarPrestamo(DAP4.ClienteLibros.PrestamosService.Prestamos prestamo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ActualizarPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/ActualizarPrestamoResponse")]
        System.Threading.Tasks.Task<DAP4.ClienteLibros.PrestamosService.Prestamos> ActualizarPrestamoAsync(DAP4.ClienteLibros.PrestamosService.Prestamos prestamo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/DevolverPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/DevolverPrestamoResponse")]
        bool DevolverPrestamo(string id_prestamo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/DevolverPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/DevolverPrestamoResponse")]
        System.Threading.Tasks.Task<bool> DevolverPrestamoAsync(string id_prestamo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPrestamosServiceChannel : DAP4.ClienteLibros.PrestamosService.IPrestamosService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PrestamosServiceClient : System.ServiceModel.ClientBase<DAP4.ClienteLibros.PrestamosService.IPrestamosService>, DAP4.ClienteLibros.PrestamosService.IPrestamosService {
        
        public PrestamosServiceClient() {
        }
        
        public PrestamosServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PrestamosServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrestamosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrestamosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DAP4.ClienteLibros.PrestamosService.Prestamos ObtenerPrestamoPorCodigo(string codigo_prestamo) {
            return base.Channel.ObtenerPrestamoPorCodigo(codigo_prestamo);
        }
        
        public System.Threading.Tasks.Task<DAP4.ClienteLibros.PrestamosService.Prestamos> ObtenerPrestamoPorCodigoAsync(string codigo_prestamo) {
            return base.Channel.ObtenerPrestamoPorCodigoAsync(codigo_prestamo);
        }
        
        public DAP4.ClienteLibros.PrestamosService.Prestamos[] ListarPrestamos() {
            return base.Channel.ListarPrestamos();
        }
        
        public System.Threading.Tasks.Task<DAP4.ClienteLibros.PrestamosService.Prestamos[]> ListarPrestamosAsync() {
            return base.Channel.ListarPrestamosAsync();
        }
        
        public DAP4.ClienteLibros.PrestamosService.Prestamos InsertarPrestamo(DAP4.ClienteLibros.PrestamosService.Prestamos prestamo) {
            return base.Channel.InsertarPrestamo(prestamo);
        }
        
        public System.Threading.Tasks.Task<DAP4.ClienteLibros.PrestamosService.Prestamos> InsertarPrestamoAsync(DAP4.ClienteLibros.PrestamosService.Prestamos prestamo) {
            return base.Channel.InsertarPrestamoAsync(prestamo);
        }
        
        public DAP4.ClienteLibros.PrestamosService.Prestamos ActualizarPrestamo(DAP4.ClienteLibros.PrestamosService.Prestamos prestamo) {
            return base.Channel.ActualizarPrestamo(prestamo);
        }
        
        public System.Threading.Tasks.Task<DAP4.ClienteLibros.PrestamosService.Prestamos> ActualizarPrestamoAsync(DAP4.ClienteLibros.PrestamosService.Prestamos prestamo) {
            return base.Channel.ActualizarPrestamoAsync(prestamo);
        }
        
        public bool DevolverPrestamo(string id_prestamo) {
            return base.Channel.DevolverPrestamo(id_prestamo);
        }
        
        public System.Threading.Tasks.Task<bool> DevolverPrestamoAsync(string id_prestamo) {
            return base.Channel.DevolverPrestamoAsync(id_prestamo);
        }
    }
}
