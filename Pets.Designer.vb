<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.bttn_clean = New System.Windows.Forms.Button()
        Me.bttn_delete = New System.Windows.Forms.Button()
        Me.bttn_modify = New System.Windows.Forms.Button()
        Me.bttn_add = New System.Windows.Forms.Button()
        Me.bttn_find = New System.Windows.Forms.Button()
        Me.bttn_image = New System.Windows.Forms.Button()
        Me.bttn_return = New System.Windows.Forms.Button()
        Me.pic_holder = New System.Windows.Forms.PictureBox()
        Me.Cnx = New System.Data.OleDb.OleDbConnection()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_race = New System.Windows.Forms.Label()
        Me.lbl_size = New System.Windows.Forms.Label()
        Me.lbl_weight = New System.Windows.Forms.Label()
        Me.lbl_birthday = New System.Windows.Forms.Label()
        Me.cb_race = New System.Windows.Forms.ComboBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cb_size = New System.Windows.Forms.ComboBox()
        Me.nd_weight = New System.Windows.Forms.NumericUpDown()
        Me.dt_birthday = New System.Windows.Forms.DateTimePicker()
        CType(Me.pic_holder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_weight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttn_clean
        '
        Me.bttn_clean.Location = New System.Drawing.Point(462, 437)
        Me.bttn_clean.Name = "bttn_clean"
        Me.bttn_clean.Size = New System.Drawing.Size(120, 40)
        Me.bttn_clean.TabIndex = 0
        Me.bttn_clean.Text = "Limpiar"
        Me.bttn_clean.UseVisualStyleBackColor = True
        '
        'bttn_delete
        '
        Me.bttn_delete.Location = New System.Drawing.Point(966, 437)
        Me.bttn_delete.Name = "bttn_delete"
        Me.bttn_delete.Size = New System.Drawing.Size(120, 40)
        Me.bttn_delete.TabIndex = 1
        Me.bttn_delete.Text = "Borrar"
        Me.bttn_delete.UseVisualStyleBackColor = True
        '
        'bttn_modify
        '
        Me.bttn_modify.Location = New System.Drawing.Point(840, 437)
        Me.bttn_modify.Name = "bttn_modify"
        Me.bttn_modify.Size = New System.Drawing.Size(120, 40)
        Me.bttn_modify.TabIndex = 2
        Me.bttn_modify.Text = "Cambiar"
        Me.bttn_modify.UseVisualStyleBackColor = True
        '
        'bttn_add
        '
        Me.bttn_add.Location = New System.Drawing.Point(714, 437)
        Me.bttn_add.Name = "bttn_add"
        Me.bttn_add.Size = New System.Drawing.Size(120, 40)
        Me.bttn_add.TabIndex = 3
        Me.bttn_add.Text = "Agregar"
        Me.bttn_add.UseVisualStyleBackColor = True
        '
        'bttn_find
        '
        Me.bttn_find.Location = New System.Drawing.Point(588, 437)
        Me.bttn_find.Name = "bttn_find"
        Me.bttn_find.Size = New System.Drawing.Size(120, 40)
        Me.bttn_find.TabIndex = 4
        Me.bttn_find.Text = "Buscar"
        Me.bttn_find.UseVisualStyleBackColor = True
        '
        'bttn_image
        '
        Me.bttn_image.Location = New System.Drawing.Point(150, 483)
        Me.bttn_image.Name = "bttn_image"
        Me.bttn_image.Size = New System.Drawing.Size(120, 40)
        Me.bttn_image.TabIndex = 5
        Me.bttn_image.Text = "Imagen"
        Me.bttn_image.UseVisualStyleBackColor = True
        '
        'bttn_return
        '
        Me.bttn_return.Location = New System.Drawing.Point(12, 12)
        Me.bttn_return.Name = "bttn_return"
        Me.bttn_return.Size = New System.Drawing.Size(120, 40)
        Me.bttn_return.TabIndex = 6
        Me.bttn_return.Text = "Regresar"
        Me.bttn_return.UseVisualStyleBackColor = True
        '
        'pic_holder
        '
        Me.pic_holder.Location = New System.Drawing.Point(35, 107)
        Me.pic_holder.Name = "pic_holder"
        Me.pic_holder.Size = New System.Drawing.Size(367, 370)
        Me.pic_holder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_holder.TabIndex = 7
        Me.pic_holder.TabStop = False
        '
        'Cnx
        '
        Me.Cnx.ConnectionString = Global.Mascotas.My.MySettings.Default.Cnx
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(462, 157)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(26, 20)
        Me.lbl_id.TabIndex = 8
        Me.lbl_id.Text = "ID"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(458, 193)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(65, 20)
        Me.lbl_name.TabIndex = 9
        Me.lbl_name.Text = "Nombre"
        '
        'lbl_race
        '
        Me.lbl_race.AutoSize = True
        Me.lbl_race.Location = New System.Drawing.Point(458, 231)
        Me.lbl_race.Name = "lbl_race"
        Me.lbl_race.Size = New System.Drawing.Size(47, 20)
        Me.lbl_race.TabIndex = 10
        Me.lbl_race.Text = "Raza"
        '
        'lbl_size
        '
        Me.lbl_size.AutoSize = True
        Me.lbl_size.Location = New System.Drawing.Point(458, 265)
        Me.lbl_size.Name = "lbl_size"
        Me.lbl_size.Size = New System.Drawing.Size(67, 20)
        Me.lbl_size.TabIndex = 11
        Me.lbl_size.Text = "Tamaño"
        '
        'lbl_weight
        '
        Me.lbl_weight.AutoSize = True
        Me.lbl_weight.Location = New System.Drawing.Point(458, 301)
        Me.lbl_weight.Name = "lbl_weight"
        Me.lbl_weight.Size = New System.Drawing.Size(45, 20)
        Me.lbl_weight.TabIndex = 12
        Me.lbl_weight.Text = "Peso"
        '
        'lbl_birthday
        '
        Me.lbl_birthday.AutoSize = True
        Me.lbl_birthday.Location = New System.Drawing.Point(458, 337)
        Me.lbl_birthday.Name = "lbl_birthday"
        Me.lbl_birthday.Size = New System.Drawing.Size(98, 20)
        Me.lbl_birthday.TabIndex = 13
        Me.lbl_birthday.Text = "Cumpleaños"
        '
        'cb_race
        '
        Me.cb_race.FormattingEnabled = True
        Me.cb_race.Location = New System.Drawing.Point(588, 228)
        Me.cb_race.Name = "cb_race"
        Me.cb_race.Size = New System.Drawing.Size(192, 28)
        Me.cb_race.TabIndex = 14
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(588, 154)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(72, 26)
        Me.txt_id.TabIndex = 15
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(588, 190)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(246, 26)
        Me.txt_name.TabIndex = 16
        '
        'cb_size
        '
        Me.cb_size.FormattingEnabled = True
        Me.cb_size.Location = New System.Drawing.Point(588, 262)
        Me.cb_size.Name = "cb_size"
        Me.cb_size.Size = New System.Drawing.Size(192, 28)
        Me.cb_size.TabIndex = 17
        '
        'nd_weight
        '
        Me.nd_weight.Location = New System.Drawing.Point(588, 299)
        Me.nd_weight.Name = "nd_weight"
        Me.nd_weight.Size = New System.Drawing.Size(120, 26)
        Me.nd_weight.TabIndex = 18
        '
        'dt_birthday
        '
        Me.dt_birthday.Location = New System.Drawing.Point(588, 332)
        Me.dt_birthday.Name = "dt_birthday"
        Me.dt_birthday.Size = New System.Drawing.Size(372, 26)
        Me.dt_birthday.TabIndex = 19
        '
        'Pets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1121, 566)
        Me.Controls.Add(Me.dt_birthday)
        Me.Controls.Add(Me.nd_weight)
        Me.Controls.Add(Me.cb_size)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.cb_race)
        Me.Controls.Add(Me.lbl_birthday)
        Me.Controls.Add(Me.lbl_weight)
        Me.Controls.Add(Me.lbl_size)
        Me.Controls.Add(Me.lbl_race)
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
        Me.Name = "Pets"
        Me.Text = "Busca Mascotas 3000"
        CType(Me.pic_holder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_weight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttn_clean As Button
    Friend WithEvents bttn_delete As Button
    Friend WithEvents bttn_modify As Button
    Friend WithEvents bttn_add As Button
    Friend WithEvents bttn_find As Button
    Friend WithEvents bttn_image As Button
    Friend WithEvents bttn_return As Button
    Friend WithEvents pic_holder As PictureBox
    Friend WithEvents Cnx As OleDb.OleDbConnection
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_race As Label
    Friend WithEvents lbl_size As Label
    Friend WithEvents lbl_weight As Label
    Friend WithEvents lbl_birthday As Label
    Friend WithEvents cb_race As ComboBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents cb_size As ComboBox
    Friend WithEvents nd_weight As NumericUpDown
    Friend WithEvents dt_birthday As DateTimePicker
End Class
