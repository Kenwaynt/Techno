Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Form1
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim da As New SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_usuario.Text = "Melvin" And txt_contraseña.Text = "123A" Then
            Me.Hide()
            Administrador.ShowDialog()
        ElseIf txt_usuario.Text = "Anthony" And txt_contraseña.Text = "123B" Then
            Me.Hide()
            Secretario.ShowDialog()
        ElseIf txt_usuario.Text = "Henrry" And txt_contraseña.Text = "123C" Then
            Me.Hide()
            Cliente.ShowDialog()
        End If
    End Sub

End Class
