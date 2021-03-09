<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Landing
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
        Me.pic_pet = New System.Windows.Forms.PictureBox()
        Me.pic_race = New System.Windows.Forms.PictureBox()
        Me.bttn_exit = New System.Windows.Forms.Button()
        Me.lbl_welcome = New System.Windows.Forms.Label()
        Me.lbl_pet = New System.Windows.Forms.Label()
        Me.lbl_race = New System.Windows.Forms.Label()
        CType(Me.pic_pet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_race, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_pet
        '
        Me.pic_pet.Image = Global.Mascotas.My.Resources.Resources.Mascotas
        Me.pic_pet.Location = New System.Drawing.Point(125, 197)
        Me.pic_pet.Name = "pic_pet"
        Me.pic_pet.Size = New System.Drawing.Size(386, 331)
        Me.pic_pet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_pet.TabIndex = 0
        Me.pic_pet.TabStop = False
        '
        'pic_race
        '
        Me.pic_race.Image = Global.Mascotas.My.Resources.Resources.raza
        Me.pic_race.Location = New System.Drawing.Point(712, 197)
        Me.pic_race.Name = "pic_race"
        Me.pic_race.Size = New System.Drawing.Size(386, 331)
        Me.pic_race.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_race.TabIndex = 1
        Me.pic_race.TabStop = False
        '
        'bttn_exit
        '
        Me.bttn_exit.Location = New System.Drawing.Point(544, 574)
        Me.bttn_exit.Name = "bttn_exit"
        Me.bttn_exit.Size = New System.Drawing.Size(140, 60)
        Me.bttn_exit.TabIndex = 2
        Me.bttn_exit.Text = "Salir"
        Me.bttn_exit.UseVisualStyleBackColor = True
        '
        'lbl_welcome
        '
        Me.lbl_welcome.AutoSize = True
        Me.lbl_welcome.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.lbl_welcome.Location = New System.Drawing.Point(436, 64)
        Me.lbl_welcome.Name = "lbl_welcome"
        Me.lbl_welcome.Size = New System.Drawing.Size(328, 33)
        Me.lbl_welcome.TabIndex = 3
        Me.lbl_welcome.Text = "Buscador de Mascotas 3000"
        '
        'lbl_pet
        '
        Me.lbl_pet.AutoSize = True
        Me.lbl_pet.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.lbl_pet.Location = New System.Drawing.Point(266, 150)
        Me.lbl_pet.Name = "lbl_pet"
        Me.lbl_pet.Size = New System.Drawing.Size(109, 30)
        Me.lbl_pet.TabIndex = 4
        Me.lbl_pet.Text = "Mascotas"
        '
        'lbl_race
        '
        Me.lbl_race.AutoSize = True
        Me.lbl_race.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.lbl_race.Location = New System.Drawing.Point(876, 150)
        Me.lbl_race.Name = "lbl_race"
        Me.lbl_race.Size = New System.Drawing.Size(72, 30)
        Me.lbl_race.TabIndex = 5
        Me.lbl_race.Text = "Razas"
        '
        'Landing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.lbl_race)
        Me.Controls.Add(Me.lbl_pet)
        Me.Controls.Add(Me.lbl_welcome)
        Me.Controls.Add(Me.bttn_exit)
        Me.Controls.Add(Me.pic_race)
        Me.Controls.Add(Me.pic_pet)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Landing"
        Me.Text = "Busca Perros 3000"
        CType(Me.pic_pet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_race, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_pet As PictureBox
    Friend WithEvents pic_race As PictureBox
    Friend WithEvents bttn_exit As Button
    Friend WithEvents lbl_welcome As Label
    Friend WithEvents lbl_pet As Label
    Friend WithEvents lbl_race As Label
End Class
