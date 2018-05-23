Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace RemoveNewButtonInLookups.Module
    <DefaultClassOptions, ImageName("BO_Person"), DefaultProperty("FullName")> _
    Public Class Employee
        Inherits BaseObject
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Private firstName_Renamed As String
        Public Property FirstName() As String
            Get
                Return firstName_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("FirstName", firstName_Renamed, value)
            End Set
        End Property
        Private lastName_Renamed As String
        Public Property LastName() As String
            Get
                Return lastName_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("LastName", lastName_Renamed, value)
            End Set
        End Property
        Public ReadOnly Property FullName() As String
            Get
                Return String.Format("{0} {1}", FirstName, LastName)
            End Get
        End Property
        Private department_Renamed As Department
        <Association("Department-Employees")> _
        Public Property Department() As Department
            Get
                Return department_Renamed
            End Get
            Set(ByVal value As Department)
                SetPropertyValue("Department", department_Renamed, value)
            End Set
        End Property
    End Class
End Namespace
