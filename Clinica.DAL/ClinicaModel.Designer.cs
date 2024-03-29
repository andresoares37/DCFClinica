﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Clinica_AndreModel", "FK_tb_Medicamento_tb_Fornecedor", "tb_Fornecedor", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Clinica.DAL.tb_Fornecedor), "tb_Medicamento", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Clinica.DAL.tb_Medicamento), true)]

#endregion

namespace Clinica.DAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Clinica_AndreEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Clinica_AndreEntities object using the connection string found in the 'Clinica_AndreEntities' section of the application configuration file.
        /// </summary>
        public Clinica_AndreEntities() : base("name=Clinica_AndreEntities", "Clinica_AndreEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Clinica_AndreEntities object.
        /// </summary>
        public Clinica_AndreEntities(string connectionString) : base(connectionString, "Clinica_AndreEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Clinica_AndreEntities object.
        /// </summary>
        public Clinica_AndreEntities(EntityConnection connection) : base(connection, "Clinica_AndreEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tb_Fornecedor> tb_Fornecedor
        {
            get
            {
                if ((_tb_Fornecedor == null))
                {
                    _tb_Fornecedor = base.CreateObjectSet<tb_Fornecedor>("tb_Fornecedor");
                }
                return _tb_Fornecedor;
            }
        }
        private ObjectSet<tb_Fornecedor> _tb_Fornecedor;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tb_Login> tb_Login
        {
            get
            {
                if ((_tb_Login == null))
                {
                    _tb_Login = base.CreateObjectSet<tb_Login>("tb_Login");
                }
                return _tb_Login;
            }
        }
        private ObjectSet<tb_Login> _tb_Login;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tb_Medicamento> tb_Medicamento
        {
            get
            {
                if ((_tb_Medicamento == null))
                {
                    _tb_Medicamento = base.CreateObjectSet<tb_Medicamento>("tb_Medicamento");
                }
                return _tb_Medicamento;
            }
        }
        private ObjectSet<tb_Medicamento> _tb_Medicamento;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tb_Fornecedor EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_Fornecedor(tb_Fornecedor tb_Fornecedor)
        {
            base.AddObject("tb_Fornecedor", tb_Fornecedor);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tb_Login EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_Login(tb_Login tb_Login)
        {
            base.AddObject("tb_Login", tb_Login);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tb_Medicamento EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_Medicamento(tb_Medicamento tb_Medicamento)
        {
            base.AddObject("tb_Medicamento", tb_Medicamento);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Clinica_AndreModel", Name="tb_Fornecedor")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tb_Fornecedor : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tb_Fornecedor object.
        /// </summary>
        /// <param name="pK_CODIGO">Initial value of the PK_CODIGO property.</param>
        public static tb_Fornecedor Createtb_Fornecedor(global::System.Int32 pK_CODIGO)
        {
            tb_Fornecedor tb_Fornecedor = new tb_Fornecedor();
            tb_Fornecedor.PK_CODIGO = pK_CODIGO;
            return tb_Fornecedor;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PK_CODIGO
        {
            get
            {
                return _PK_CODIGO;
            }
            set
            {
                if (_PK_CODIGO != value)
                {
                    OnPK_CODIGOChanging(value);
                    ReportPropertyChanging("PK_CODIGO");
                    _PK_CODIGO = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PK_CODIGO");
                    OnPK_CODIGOChanged();
                }
            }
        }
        private global::System.Int32 _PK_CODIGO;
        partial void OnPK_CODIGOChanging(global::System.Int32 value);
        partial void OnPK_CODIGOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AT_NOME
        {
            get
            {
                return _AT_NOME;
            }
            set
            {
                OnAT_NOMEChanging(value);
                ReportPropertyChanging("AT_NOME");
                _AT_NOME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AT_NOME");
                OnAT_NOMEChanged();
            }
        }
        private global::System.String _AT_NOME;
        partial void OnAT_NOMEChanging(global::System.String value);
        partial void OnAT_NOMEChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Clinica_AndreModel", "FK_tb_Medicamento_tb_Fornecedor", "tb_Medicamento")]
        public EntityCollection<tb_Medicamento> tb_Medicamento
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tb_Medicamento>("Clinica_AndreModel.FK_tb_Medicamento_tb_Fornecedor", "tb_Medicamento");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tb_Medicamento>("Clinica_AndreModel.FK_tb_Medicamento_tb_Fornecedor", "tb_Medicamento", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Clinica_AndreModel", Name="tb_Login")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tb_Login : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tb_Login object.
        /// </summary>
        /// <param name="pK_ID">Initial value of the PK_ID property.</param>
        public static tb_Login Createtb_Login(global::System.String pK_ID)
        {
            tb_Login tb_Login = new tb_Login();
            tb_Login.PK_ID = pK_ID;
            return tb_Login;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PK_ID
        {
            get
            {
                return _PK_ID;
            }
            set
            {
                if (_PK_ID != value)
                {
                    OnPK_IDChanging(value);
                    ReportPropertyChanging("PK_ID");
                    _PK_ID = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("PK_ID");
                    OnPK_IDChanged();
                }
            }
        }
        private global::System.String _PK_ID;
        partial void OnPK_IDChanging(global::System.String value);
        partial void OnPK_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AT_Nome
        {
            get
            {
                return _AT_Nome;
            }
            set
            {
                OnAT_NomeChanging(value);
                ReportPropertyChanging("AT_Nome");
                _AT_Nome = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AT_Nome");
                OnAT_NomeChanged();
            }
        }
        private global::System.String _AT_Nome;
        partial void OnAT_NomeChanging(global::System.String value);
        partial void OnAT_NomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AT_Senha
        {
            get
            {
                return _AT_Senha;
            }
            set
            {
                OnAT_SenhaChanging(value);
                ReportPropertyChanging("AT_Senha");
                _AT_Senha = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AT_Senha");
                OnAT_SenhaChanged();
            }
        }
        private global::System.String _AT_Senha;
        partial void OnAT_SenhaChanging(global::System.String value);
        partial void OnAT_SenhaChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Clinica_AndreModel", Name="tb_Medicamento")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tb_Medicamento : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tb_Medicamento object.
        /// </summary>
        /// <param name="pK_CODIGO">Initial value of the PK_CODIGO property.</param>
        public static tb_Medicamento Createtb_Medicamento(global::System.String pK_CODIGO)
        {
            tb_Medicamento tb_Medicamento = new tb_Medicamento();
            tb_Medicamento.PK_CODIGO = pK_CODIGO;
            return tb_Medicamento;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PK_CODIGO
        {
            get
            {
                return _PK_CODIGO;
            }
            set
            {
                if (_PK_CODIGO != value)
                {
                    OnPK_CODIGOChanging(value);
                    ReportPropertyChanging("PK_CODIGO");
                    _PK_CODIGO = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("PK_CODIGO");
                    OnPK_CODIGOChanged();
                }
            }
        }
        private global::System.String _PK_CODIGO;
        partial void OnPK_CODIGOChanging(global::System.String value);
        partial void OnPK_CODIGOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AT_NOME
        {
            get
            {
                return _AT_NOME;
            }
            set
            {
                OnAT_NOMEChanging(value);
                ReportPropertyChanging("AT_NOME");
                _AT_NOME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AT_NOME");
                OnAT_NOMEChanged();
            }
        }
        private global::System.String _AT_NOME;
        partial void OnAT_NOMEChanging(global::System.String value);
        partial void OnAT_NOMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AT_DESCRICAO
        {
            get
            {
                return _AT_DESCRICAO;
            }
            set
            {
                OnAT_DESCRICAOChanging(value);
                ReportPropertyChanging("AT_DESCRICAO");
                _AT_DESCRICAO = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AT_DESCRICAO");
                OnAT_DESCRICAOChanged();
            }
        }
        private global::System.String _AT_DESCRICAO;
        partial void OnAT_DESCRICAOChanging(global::System.String value);
        partial void OnAT_DESCRICAOChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AT_POSOLOGIA
        {
            get
            {
                return _AT_POSOLOGIA;
            }
            set
            {
                OnAT_POSOLOGIAChanging(value);
                ReportPropertyChanging("AT_POSOLOGIA");
                _AT_POSOLOGIA = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AT_POSOLOGIA");
                OnAT_POSOLOGIAChanged();
            }
        }
        private global::System.String _AT_POSOLOGIA;
        partial void OnAT_POSOLOGIAChanging(global::System.String value);
        partial void OnAT_POSOLOGIAChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> FK_FORNECEDOR_ID
        {
            get
            {
                return _FK_FORNECEDOR_ID;
            }
            set
            {
                OnFK_FORNECEDOR_IDChanging(value);
                ReportPropertyChanging("FK_FORNECEDOR_ID");
                _FK_FORNECEDOR_ID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FK_FORNECEDOR_ID");
                OnFK_FORNECEDOR_IDChanged();
            }
        }
        private Nullable<global::System.Int32> _FK_FORNECEDOR_ID;
        partial void OnFK_FORNECEDOR_IDChanging(Nullable<global::System.Int32> value);
        partial void OnFK_FORNECEDOR_IDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Clinica_AndreModel", "FK_tb_Medicamento_tb_Fornecedor", "tb_Fornecedor")]
        public tb_Fornecedor tb_Fornecedor
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_Fornecedor>("Clinica_AndreModel.FK_tb_Medicamento_tb_Fornecedor", "tb_Fornecedor").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_Fornecedor>("Clinica_AndreModel.FK_tb_Medicamento_tb_Fornecedor", "tb_Fornecedor").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tb_Fornecedor> tb_FornecedorReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_Fornecedor>("Clinica_AndreModel.FK_tb_Medicamento_tb_Fornecedor", "tb_Fornecedor");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tb_Fornecedor>("Clinica_AndreModel.FK_tb_Medicamento_tb_Fornecedor", "tb_Fornecedor", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
