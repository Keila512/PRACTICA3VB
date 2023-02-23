Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace My
    Friend Class Contacto
        Inherits Persona

        Private telefono As String

        Public Property TelefonoP As String
            Get
                Return telefono
            End Get
            Set(ByVal value As String)
                telefono = value.Replace(" ", "").Replace("-", "")
            End Set
        End Property

        Public correo As String

        Public Property CorreoP As String
            Get
                Return correo
            End Get
            Set(ByVal value As String)
                correo = value
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            telefono = String.Empty
            correo = String.Empty
        End Sub

        Public Sub New(ByVal nombre As String, ByVal fechaN As DateTime?, ByVal telefono As String, ByVal correo As String)
            MyBase.New(nombre, fechaN)
            Me.telefono = telefono
            Me.correo = correo
        End Sub

        Public Overrides Function ToString() As String
            Return MyBase.ToString() & " " & telefono & " " & correo
        End Function
    End Class
End Namespace
