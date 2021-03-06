﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5420
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace MasterGuruServiceReference
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="MasterGuruServiceReference.MasterGuruServiceSoap")>  _
    Public Interface MasterGuruServiceSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/GetAllGuru", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(StructuralObject)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(MasterGuru())),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(EntityKeyMember()))>  _
        Function GetAllGuru() As MasterGuru()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/GetGuru", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(StructuralObject)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(MasterGuru())),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(EntityKeyMember()))>  _
        Function GetGuru(ByVal id As Integer) As MasterGuruServiceReference.MasterGuru
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/InsertGuru", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(StructuralObject)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(MasterGuru())),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(EntityKeyMember()))>  _
        Sub InsertGuru(ByVal mguru As MasterGuruServiceReference.MasterGuru)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/UpdateGuru", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(StructuralObject)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(MasterGuru())),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(EntityKeyMember()))>  _
        Sub UpdateGuru(ByVal mguru As MasterGuruServiceReference.MasterGuru)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/DeleteGuru", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(StructuralObject)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(MasterGuru())),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(EntityKeyMember()))>  _
        Sub DeleteGuru(ByVal recordId As Integer)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/SubmitGuruMataPelajaran", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(StructuralObject)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(MasterGuru())),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(EntityKeyMember()))>  _
        Sub SubmitGuruMataPelajaran(ByVal mguru() As GuruMataPelajaranModel)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/GetGuruByMataPelajaranTahunAjaran", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(StructuralObject)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(MasterGuru())),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(EntityKeyMember()))>  _
        Function GetGuruByMataPelajaranTahunAjaran(ByVal matapelajaranid As Integer, ByVal tahun As Integer) As MasterGuru()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/GetGuruByName", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(StructuralObject)),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(MasterGuru())),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(EntityKeyMember()))>  _
        Function GetGuruByName(ByVal text As String) As MasterGuru()
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class MasterGuru
        Inherits EntityObject
        
        Private idField As Integer
        
        Private nIPField As String
        
        Private guruIDField As String
        
        Private namaField As String
        
        Private jenisKelaminField As String
        
        Private tempatLahirField As String
        
        Private tanggalLahirField As Date
        
        Private agamaField As String
        
        Private emailField As String
        
        Private alamatField As String
        
        Private kotaField As String
        
        Private kodePosField As String
        
        Private noTelephoneField As String
        
        Private noHPField As String
        
        Private photoField() As Byte
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property ID() As Integer
            Get
                Return Me.idField
            End Get
            Set
                Me.idField = value
                Me.RaisePropertyChanged("ID")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>  _
        Public Property NIP() As String
            Get
                Return Me.nIPField
            End Get
            Set
                Me.nIPField = value
                Me.RaisePropertyChanged("NIP")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>  _
        Public Property GuruID() As String
            Get
                Return Me.guruIDField
            End Get
            Set
                Me.guruIDField = value
                Me.RaisePropertyChanged("GuruID")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>  _
        Public Property Nama() As String
            Get
                Return Me.namaField
            End Get
            Set
                Me.namaField = value
                Me.RaisePropertyChanged("Nama")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>  _
        Public Property JenisKelamin() As String
            Get
                Return Me.jenisKelaminField
            End Get
            Set
                Me.jenisKelaminField = value
                Me.RaisePropertyChanged("JenisKelamin")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>  _
        Public Property TempatLahir() As String
            Get
                Return Me.tempatLahirField
            End Get
            Set
                Me.tempatLahirField = value
                Me.RaisePropertyChanged("TempatLahir")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>  _
        Public Property TanggalLahir() As Date
            Get
                Return Me.tanggalLahirField
            End Get
            Set
                Me.tanggalLahirField = value
                Me.RaisePropertyChanged("TanggalLahir")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>  _
        Public Property Agama() As String
            Get
                Return Me.agamaField
            End Get
            Set
                Me.agamaField = value
                Me.RaisePropertyChanged("Agama")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>  _
        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = value
                Me.RaisePropertyChanged("Email")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>  _
        Public Property Alamat() As String
            Get
                Return Me.alamatField
            End Get
            Set
                Me.alamatField = value
                Me.RaisePropertyChanged("Alamat")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>  _
        Public Property Kota() As String
            Get
                Return Me.kotaField
            End Get
            Set
                Me.kotaField = value
                Me.RaisePropertyChanged("Kota")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=11)>  _
        Public Property KodePos() As String
            Get
                Return Me.kodePosField
            End Get
            Set
                Me.kodePosField = value
                Me.RaisePropertyChanged("KodePos")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=12)>  _
        Public Property NoTelephone() As String
            Get
                Return Me.noTelephoneField
            End Get
            Set
                Me.noTelephoneField = value
                Me.RaisePropertyChanged("NoTelephone")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>  _
        Public Property NoHP() As String
            Get
                Return Me.noHPField
            End Get
            Set
                Me.noHPField = value
                Me.RaisePropertyChanged("NoHP")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary", Order:=14)>  _
        Public Property Photo() As Byte()
            Get
                Return Me.photoField
            End Get
            Set
                Me.photoField = value
                Me.RaisePropertyChanged("Photo")
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.Xml.Serialization.XmlIncludeAttribute(GetType(MasterGuru)),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public MustInherit Class EntityObject
        Inherits StructuralObject
        
        Private entityKeyField As EntityKey
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property EntityKey() As EntityKey
            Get
                Return Me.entityKeyField
            End Get
            Set
                Me.entityKeyField = value
                Me.RaisePropertyChanged("EntityKey")
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class EntityKey
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private entitySetNameField As String
        
        Private entityContainerNameField As String
        
        Private entityKeyValuesField() As EntityKeyMember
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property EntitySetName() As String
            Get
                Return Me.entitySetNameField
            End Get
            Set
                Me.entitySetNameField = value
                Me.RaisePropertyChanged("EntitySetName")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>  _
        Public Property EntityContainerName() As String
            Get
                Return Me.entityContainerNameField
            End Get
            Set
                Me.entityContainerNameField = value
                Me.RaisePropertyChanged("EntityContainerName")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(Order:=2)>  _
        Public Property EntityKeyValues() As EntityKeyMember()
            Get
                Return Me.entityKeyValuesField
            End Get
            Set
                Me.entityKeyValuesField = value
                Me.RaisePropertyChanged("EntityKeyValues")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class EntityKeyMember
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private keyField As String
        
        Private valueField As Object
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property Key() As String
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
                Me.RaisePropertyChanged("Key")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>  _
        Public Property Value() As Object
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = value
                Me.RaisePropertyChanged("Value")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class GuruMataPelajaranModel
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private idField As Integer
        
        Private mataPelajaranIdField As Integer
        
        Private guruIdField As Integer
        
        Private crudField As Integer
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property Id() As Integer
            Get
                Return Me.idField
            End Get
            Set
                Me.idField = value
                Me.RaisePropertyChanged("Id")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>  _
        Public Property MataPelajaranId() As Integer
            Get
                Return Me.mataPelajaranIdField
            End Get
            Set
                Me.mataPelajaranIdField = value
                Me.RaisePropertyChanged("MataPelajaranId")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>  _
        Public Property GuruId() As Integer
            Get
                Return Me.guruIdField
            End Get
            Set
                Me.guruIdField = value
                Me.RaisePropertyChanged("GuruId")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>  _
        Public Property Crud() As Integer
            Get
                Return Me.crudField
            End Get
            Set
                Me.crudField = value
                Me.RaisePropertyChanged("Crud")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.Xml.Serialization.XmlIncludeAttribute(GetType(EntityObject)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(MasterGuru)),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public MustInherit Class StructuralObject
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface MasterGuruServiceSoapChannel
        Inherits MasterGuruServiceReference.MasterGuruServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class MasterGuruServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of MasterGuruServiceReference.MasterGuruServiceSoap)
        Implements MasterGuruServiceReference.MasterGuruServiceSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function GetAllGuru() As MasterGuru() Implements MasterGuruServiceReference.MasterGuruServiceSoap.GetAllGuru
            Return MyBase.Channel.GetAllGuru
        End Function
        
        Public Function GetGuru(ByVal id As Integer) As MasterGuruServiceReference.MasterGuru Implements MasterGuruServiceReference.MasterGuruServiceSoap.GetGuru
            Return MyBase.Channel.GetGuru(id)
        End Function
        
        Public Sub InsertGuru(ByVal mguru As MasterGuruServiceReference.MasterGuru) Implements MasterGuruServiceReference.MasterGuruServiceSoap.InsertGuru
            MyBase.Channel.InsertGuru(mguru)
        End Sub
        
        Public Sub UpdateGuru(ByVal mguru As MasterGuruServiceReference.MasterGuru) Implements MasterGuruServiceReference.MasterGuruServiceSoap.UpdateGuru
            MyBase.Channel.UpdateGuru(mguru)
        End Sub
        
        Public Sub DeleteGuru(ByVal recordId As Integer) Implements MasterGuruServiceReference.MasterGuruServiceSoap.DeleteGuru
            MyBase.Channel.DeleteGuru(recordId)
        End Sub
        
        Public Sub SubmitGuruMataPelajaran(ByVal mguru() As GuruMataPelajaranModel) Implements MasterGuruServiceReference.MasterGuruServiceSoap.SubmitGuruMataPelajaran
            MyBase.Channel.SubmitGuruMataPelajaran(mguru)
        End Sub
        
        Public Function GetGuruByMataPelajaranTahunAjaran(ByVal matapelajaranid As Integer, ByVal tahun As Integer) As MasterGuru() Implements MasterGuruServiceReference.MasterGuruServiceSoap.GetGuruByMataPelajaranTahunAjaran
            Return MyBase.Channel.GetGuruByMataPelajaranTahunAjaran(matapelajaranid, tahun)
        End Function
        
        Public Function GetGuruByName(ByVal text As String) As MasterGuru() Implements MasterGuruServiceReference.MasterGuruServiceSoap.GetGuruByName
            Return MyBase.Channel.GetGuruByName(text)
        End Function
    End Class
End Namespace
