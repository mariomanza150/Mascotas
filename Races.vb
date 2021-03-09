Imports System.Data.OleDb
Public Class Races
    Dim strFileName As String
    Private Sub bttn_return_Click(sender As Object, e As EventArgs) Handles bttn_return.Click
        Landing.Show()
        Me.Close()
    End Sub

    Private Sub bttn_clean_Click(sender As Object, e As EventArgs) Handles bttn_clean.Click
        txt_id.Clear()
        txt_name.Clear()
        txt_size.Clear()
        nd_weight.Value = 0
        txt_origin.Clear()
        txt_temper.Clear()
        pic_holder = Nothing
    End Sub

    Private Sub bttn_find_Click(sender As Object, e As EventArgs) Handles bttn_find.Click
        Dim BUSCAR = "SELECT * FROM Razas WHERE Id=@Id"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@Id", txt_id.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            txt_name.Text = Lectura(1)
            txt_size.Text = Lectura(2)
            nd_weight.Value = Lectura(3)
            txt_origin.Text = Lectura(4)
            txt_temper.Text = Lectura(5)
            pic_holder.ImageLocation = Lectura(6)
        Else
            MsgBox("Los Datos a Buscar No Estan Registrados", MsgBoxStyle.Information, "Agenda")
            txt_id.Clear()
            txt_id.Focus()
        End If
        Cnx.Close()
    End Sub

    Private Sub bttn_add_Click(sender As Object, e As EventArgs) Handles bttn_add.Click
        Try
            Dim Insertar = "Insert Into Perros Values (@Id, @Nombre, @Peso, @Fecha, @Raza, @Tamaño, @Imagen)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.Parameters.AddWithValue("@Id", txt_id.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txt_name.Text)
            Cmd.Parameters.AddWithValue("@Peso", nd_weight.Value)
            Cmd.Parameters.AddWithValue("@Tamaño", txt_size.Text)
            Cmd.Parameters.AddWithValue("@Origen", txt_origin.Text)
            Cmd.Parameters.AddWithValue("@Temperamento", txt_temper.Text)
            pic_holder.ImageLocation = strFileName
            Cmd.Parameters.AddWithValue("@Imagen", pic_holder.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Perro Fue Registrado")
        Catch ex As Exception
            MsgBox("La Perro a Registrar Ya Existe")
        End Try
    End Sub

    Private Sub bttn_modify_Click(sender As Object, e As EventArgs) Handles bttn_modify.Click
        Try
            Dim Actualizar = "UPDATE Perros SET Id=@Id, Nombre=@Nombre, Peso=@Peso, Tamaño=@Tamaño, Origen=@Origen, Temperamento=@Temperamento, Imagen=@Imagen WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txt_id.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txt_name.Text)
            Cmd.Parameters.AddWithValue("@Peso", nd_weight.Value)
            Cmd.Parameters.AddWithValue("@Tamaño", txt_size.Text)
            Cmd.Parameters.AddWithValue("@Origen", txt_origin.Text)
            Cmd.Parameters.AddWithValue("@Temperamento", txt_temper.Text)
            Cmd.Parameters.AddWithValue("@Imagen", pic_holder.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos De la Raza Fueron Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bttn_delete_Click(sender As Object, e As EventArgs) Handles bttn_delete.Click
        Try
            Dim Eliminar = "DELETE FROM Razas WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txt_id.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("La Raza Fue Eliminado....")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        txt_id.Clear()
        txt_name.Clear()
        txt_size.Clear()
        nd_weight.Value = 0
        txt_origin.Clear()
        txt_temper.Clear()
        pic_holder = Nothing
        txt_id.Focus()
    End Sub

    Private Sub bttn_image_Click(sender As Object, e As EventArgs) Handles bttn_image.Click
        Dim dialog As New OpenFileDialog
        With dialog
            .Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
            .FilterIndex = 1
            .Title = "Abrir un archivo de imagen"
        End With
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                strFileName = dialog.FileName
                pic_holder.Image = Image.FromFile(strFileName)
                dialog.Reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class