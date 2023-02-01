Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Cliente
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim mensaje, sentencia As String
    Sub EjecutarSQL(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim da As New SqlDataAdapter("select * from ingreso where usuario = '" + txt_usuario.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        sentencia = "Update Ingreso set Usuario = '" + txt_usuario.Text + "', Contraseña = '" + txt_contraseña.Text + "', Rol: '" + txt_rol.Text + "'"
        mensaje = "Datos actualizados Correctamente"
        EjecutarSQL(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * From Ingreso", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class