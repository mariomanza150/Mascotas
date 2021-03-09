Imports System.Data.OleDb
Public Class Pets
    Dim strFileName As String
    Private Sub Pets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BUSCAR = "SELECT * FROM Razas"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        Cnx.Open()
        Dim Lectura As OleDbDataReader = CmdBuscar.ExecuteReader
        Dim tb_race As New DataTable
        Dim tb_size As New DataTable
        tb_race.Columns.Add("Text", GetType(String))
        tb_race.Columns.Add("Value", GetType(String))
        tb_size.Columns.Add("Text", GetType(String))
        tb_size.Columns.Add("Value", GetType(String))
        tb_race.Rows.Add("", "")
        tb_size.Rows.Add("", "")
        While Lectura.Read
            tb_race.Rows.Add(Lectura(1), Lectura(1))
            tb_size.Rows.Add(Lectura(2), Lectura(2))
        End While
        cb_race.DisplayMember = "Text"
        cb_race.ValueMember = "Value"
        cb_race.DataSource = tb_race
        cb_size.DisplayMember = "Text"
        cb_size.ValueMember = "Value"
        cb_size.DataSource = tb_size
        Cnx.Close()
    End Sub
    Private Sub bttn_return_Click(sender As Object, e As EventArgs) Handles bttn_return.Click
        Landing.Show()
        Me.Close()
    End Sub

    Private Sub bttn_clean_Click(sender As Object, e As EventArgs) Handles bttn_clean.Click
        txt_id.Clear()
        txt_name.Clear()
        nd_weight.Value = 0
        cb_race.SelectedValue = ""
        cb_size.SelectedValue = ""
        dt_birthday.Value = DateTime.Now()
        pic_holder.Image = Nothing
    End Sub

    Private Sub bttn_find_Click(sender As Object, e As EventArgs) Handles bttn_find.Click
        Dim BUSCAR = "SELECT * FROM Perros WHERE Id=@Id"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@Id", txt_id.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            txt_name.Text = Lectura(1)
            nd_weight.Value = Lectura(2)
            dt_birthday.Value = Lectura(3)
            cb_race.SelectedValue = Lectura(4)
            cb_size.SelectedValue = Lectura(5)
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
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txt_id.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txt_name.Text)
            Cmd.Parameters.AddWithValue("@Peso", nd_weight.Value)
            Cmd.Parameters.AddWithValue("@Fecha", dt_birthday.Value)
            Cmd.Parameters.AddWithValue("@Raza", cb_race.SelectedValue)
            Cmd.Parameters.AddWithValue("@Tamaño", cb_size.SelectedValue)
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
            Dim Actualizar = "UPDATE Perros SET Id=@Id, Nombre=@Nombre, Peso=@Peso, Fecha=@Fecha, Raza=@Raza, Tamaño=@Tamaño, Imagen=@Imagen WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txt_id.Text)
            Cmd.Parameters.AddWithValue("@Nombre", txt_name.Text)
            Cmd.Parameters.AddWithValue("@Peso", nd_weight.Value)
            Cmd.Parameters.AddWithValue("@Fecha", dt_birthday.Value)
            Cmd.Parameters.AddWithValue("@Raza", cb_race.SelectedValue)
            Cmd.Parameters.AddWithValue("@Tamaño", cb_size.SelectedValue)
            Cmd.Parameters.AddWithValue("@Imagen", pic_holder.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos Del Perro Fueron Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bttn_delete_Click(sender As Object, e As EventArgs) Handles bttn_delete.Click
        Try
            Dim Eliminar = "DELETE FROM Perros WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", txt_id.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Perro Fue Eliminado....")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        txt_id.Clear()
        txt_name.Clear()
        nd_weight.Value = 0
        dt_birthday.Value = Now()
        cb_race.SelectedItem = ""
        cb_size.SelectedItem = ""
        pic_holder.Image = Nothing
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