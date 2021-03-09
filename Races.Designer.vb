<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Races
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nd_weight = New System.Windows.Forms.NumericUpDown()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_weight = New System.Windows.Forms.Label()
        Me.lbl_size = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.pic_holder = New System.Windows.Forms.PictureBox()
        Me.bttn_return = New System.Windows.Forms.Button()
        Me.bttn_image = New System.Windows.Forms.Button()
        Me.bttn_find = New System.Windows.Forms.Button()
        Me.bttn_add = New System.Windows.Forms.Button()
        Me.bttn_modify = New System.Windows.Forms.Button()
        Me.bttn_delete = New System.Windows.Forms.Button()
        Me.bttn_clean = New System.Windows.Forms.Button()
        Me.txt_origin = New System.Windows.Forms.TextBox()
        Me.lbl_origin = New System.Windows.Forms.Label()
        Me.txt_temper = New System.Windows.Forms.TextBox()
        Me.lbl_temper = New System.Windows.Forms.Label()
        Me.txt_size = New System.Windows.Forms.TextBox()
        CType(Me.nd_weight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_holder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nd_weight
        '
        Me.nd_weight.Location = New System.Drawing.Point(580, 261)
        Me.nd_weight.Name = "nd_weight"
        Me.nd_weight.Size = New System.Drawing.Size(120, 26)
        Me.nd_weight.TabIndex = 38
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(580, 184)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(246, 26)
        Me.txt_name.TabIndex = 36
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(580, 148)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(72, 26)
        Me.txt_id.TabIndex = 35
        '
        'lbl_weight
        '
        Me.lbl_weight.AutoSize = True
        Me.lbl_weight.Location = New System.Drawing.Point(450, 263)
        Me.lbl_weight.Name = "lbl_weight"
        Me.lbl_weight.Size = New System.Drawing.Size(45, 20)
        Me.lbl_weight.TabIndex = 32
        Me.lbl_weight.Text = "Peso"
        '
        'lbl_size
        '
        Me.lbl_size.AutoSize = True
        Me.lbl_size.Location = New System.Drawing.Point(450, 225)
        Me.lbl_size.Name = "lbl_size"
        Me.lbl_size.Size = New System.Drawing.Size(67, 20)
        Me.lbl_size.TabIndex = 30
        Me.lbl_size.Text = "Tamaño"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(450, 187)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(65, 20)
        Me.lbl_name.TabIndex = 29
        Me.lbl_name.Text = "Nombre"
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Mascotas.mdb"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(454, 151)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(26, 20)
        Me.lbl_id.TabIndex = 28
        Me.lbl_id.Text = "ID"
        '
        'pic_holder
        '
        Me.pic_holder.Location = New System.Drawing.Point(27, 101)
        Me.pic_holder.Name = "pic_holder"
        Me.pic_holder.Size = New System.Drawing.Size(367, 370)
        Me.pic_holder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_holder.TabIndex = 27
        Me.pic_holder.TabStop = False
        '
        'bttn_return
        '
        Me.bttn_return.Location = New System.Drawing.Point(4, 6)
        Me.bttn_return.Name = "bttn_return"
        Me.bttn_return.Size = New System.Drawing.Size(120, 40)
        Me.bttn_return.TabIndex = 26
        Me.bttn_return.Text = "Regresar"
        Me.bttn_return.UseVisualStyleBackColor = True
        '
        'bttn_image
        '
        Me.bttn_image.Location = New System.Drawing.Point(142, 477)
        Me.bttn_image.Name = "bttn_image"
        Me.bttn_image.Size = New System.Drawing.Size(120, 40)
        Me.bttn_image.TabIndex = 25
        Me.bttn_image.Text = "Imagen"
        Me.bttn_image.UseVisualStyleBackColor = True
        '
        'bttn_find
        '
        Me.bttn_find.Location = New System.Drawing.Point(579, 463)
        Me.bttn_find.Name = "bttn_find"
        Me.bttn_find.Size = New System.Drawing.Size(120, 40)
        Me.bttn_find.TabIndex = 24
        Me.bttn_find.Text = "Buscar"
        Me.bttn_find.UseVisualStyleBackColor = True
        '
        'bttn_add
        '
        Me.bttn_add.Location = New System.Drawing.Point(705, 463)
        Me.bttn_add.Name = "bttn_add"
        Me.bttn_add.Size = New System.Drawing.Size(120, 40)
        Me.bttn_add.TabIndex = 23
        Me.bttn_add.Text = "Agregar"
        Me.bttn_add.UseVisualStyleBackColor = True
        '
        'bttn_modify
        '
        Me.bttn_modify.Location = New System.Drawing.Point(831, 463)
        Me.bttn_modify.Name = "bttn_modify"
        Me.bttn_modify.Size = New System.Drawing.Size(120, 40)
        Me.bttn_modify.TabIndex = 22
        Me.bttn_modify.Text = "Cambiar"
        Me.bttn_modify.UseVisualStyleBackColor = True
        '
        'bttn_delete
        '
        Me.bttn_delete.Location = New System.Drawing.Point(957, 463)
        Me.bttn_delete.Name = "bttn_delete"
        Me.bttn_delete.Size = New System.Drawing.Size(120, 40)
        Me.bttn_delete.TabIndex = 21
        Me.bttn_delete.Text = "Borrar"
        Me.bttn_delete.UseVisualStyleBackColor = True
        '
        'bttn_clean
        '
        Me.bttn_clean.Location = New System.Drawing.Point(453, 463)
        Me.bttn_clean.Name = "bttn_clean"
        Me.bttn_clean.Size = New System.Drawing.Size(120, 40)
        Me.bttn_clean.TabIndex = 20
        Me.bttn_clean.Text = "Limpiar"
        Me.bttn_clean.UseVisualStyleBackColor = True
        '
        'txt_origin
        '
        Me.txt_origin.Location = New System.Drawing.Point(580, 302)
        Me.txt_origin.Name = "txt_origin"
        Me.txt_origin.Size = New System.Drawing.Size(246, 26)
        Me.txt_origin.TabIndex = 40
        '
        'lbl_origin
        '
        Me.lbl_origin.AutoSize = True
        Me.lbl_origin.Location = New System.Drawing.Point(450, 305)
        Me.lbl_origin.Name = "lbl_origin"
        Me.lbl_origin.Size = New System.Drawing.Size(56, 20)
        Me.lbl_origin.TabIndex = 39
        Me.lbl_origin.Text = "Origen"
        '
        'txt_temper
        '
        Me.txt_temper.Location = New System.Drawing.Point(580, 344)
        Me.txt_temper.Multiline = True
        Me.txt_temper.Name = "txt_temper"
        Me.txt_temper.Size = New System.Drawing.Size(372, 81)
        Me.txt_temper.TabIndex = 42
        '
        'lbl_temper
        '
        Me.lbl_temper.AutoSize = True
        Me.lbl_temper.Location = New System.Drawing.Point(450, 347)
        Me.lbl_temper.Name = "lbl_temper"
        Me.lbl_temper.Size = New System.Drawing.Size(117, 20)
        Me.lbl_temper.TabIndex = 41
        Me.lbl_temper.Text = "Temperamento"
        '
        'txt_size
        '
        Me.txt_size.Location = New System.Drawing.Point(579, 222)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.Size = New System.Drawing.Size(246, 26)
        Me.txt_size.TabIndex = 43
        '
        'Races
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 533)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.txt_temper)
        Me.Controls.Add(Me.lbl_temper)
        Me.Controls.Add(Me.txt_origin)
        Me.Controls.Add(Me.lbl_origin)
        Me.Controls.Add(Me.nd_weight)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_weight)
        Me.Controls.Add(Me.lbl_size)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.pic_holder)
        Me.Controls.Add(Me.bttn_return)
        Me.Controls.Add(Me.bttn_image)
        Me.Controls.Add(Me.bttn_find)
        Me.Controls.Add(Me.bttn_add)
        Me.Controls.Add(Me.bttn_modify)
        Me.Controls.Add(Me.bttn_delete)
        Me.Controls.Add(Me.bttn_clean)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Races"
        Me.Text = "Busca Mascotas 3000"
        CType(Me.nd_weight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_holder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nd_weight As NumericUpDown
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_weight As Label
    Friend WithEvents lbl_size As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents Cnx As OleDb.OleDbConnection
    Friend WithEvents lbl_id As Label
    Friend WithEvents pic_holder As PictureBox
    Friend WithEvents bttn_return As Button
    Friend WithEvents bttn_image As Button
    Friend WithEvents bttn_find As Button
    Friend WithEvents bttn_add As Button
    Friend WithEvents bttn_modify As Button
    Friend WithEvents bttn_delete As Button
    Friend WithEvents bttn_clean As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_origin As TextBox
    Friend WithEvents lbl_origin As Label
    Friend WithEvents txt_temper As TextBox
    Friend WithEvents lbl_temper As Label
    Friend WithEvents txt_size As TextBox
End Class
