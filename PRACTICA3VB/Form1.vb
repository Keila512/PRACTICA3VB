Imports System.Diagnostics.Contracts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Namespace My
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private a As Contacto() = New Contacto(5) {}
        Private i As Integer = 0

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If i < a.Length - 1 Then
                Dim x As Contacto = New Contacto()
                x.NombreP = textBox1.Text
                x.FechaNacimientoP = dateTimePicker1.Value
                x.TelefonoP = textBox2.Text
                x.CorreoP = textBox3.Text
                a(i) = x
                listView1.Items.Add(x.ToString())
                i += 1
            End If
        End Sub
    End Class
End Namespace
