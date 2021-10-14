<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loguin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loguin))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bot_cerrar = New System.Windows.Forms.Button()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Bot_aceptar = New System.Windows.Forms.Button()
        Me.Usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Contraseña = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.Bot_cerrar)
        Me.GroupBox4.Controls.Add(Me.PictureBox11)
        Me.GroupBox4.Controls.Add(Me.Bot_aceptar)
        Me.GroupBox4.Controls.Add(Me.Usuario)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Contraseña)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(359, 144)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Bot_cerrar
        '
        Me.Bot_cerrar.BackColor = System.Drawing.Color.White
        Me.Bot_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Bot_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bot_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_cerrar.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_cerrar.Image = CType(resources.GetObject("Bot_cerrar.Image"), System.Drawing.Image)
        Me.Bot_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_cerrar.Location = New System.Drawing.Point(42, 104)
        Me.Bot_cerrar.Name = "Bot_cerrar"
        Me.Bot_cerrar.Size = New System.Drawing.Size(108, 34)
        Me.Bot_cerrar.TabIndex = 2
        Me.Bot_cerrar.Text = "CERRAR"
        Me.Bot_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bot_cerrar.UseVisualStyleBackColor = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(6, 62)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 1
        Me.PictureBox11.TabStop = False
        '
        'Bot_aceptar
        '
        Me.Bot_aceptar.BackColor = System.Drawing.Color.White
        Me.Bot_aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Bot_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bot_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_aceptar.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_aceptar.Image = CType(resources.GetObject("Bot_aceptar.Image"), System.Drawing.Image)
        Me.Bot_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bot_aceptar.Location = New System.Drawing.Point(224, 104)
        Me.Bot_aceptar.Name = "Bot_aceptar"
        Me.Bot_aceptar.Size = New System.Drawing.Size(108, 34)
        Me.Bot_aceptar.TabIndex = 1
        Me.Bot_aceptar.Text = "ACEPTAR"
        Me.Bot_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bot_aceptar.UseVisualStyleBackColor = False
        '
        'Usuario
        '
        Me.Usuario.BackColor = System.Drawing.Color.White
        Me.Usuario.Location = New System.Drawing.Point(42, 26)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Size = New System.Drawing.Size(311, 20)
        Me.Usuario.TabIndex = 3
        Me.Usuario.Text = "admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario"
        '
        'Contraseña
        '
        Me.Contraseña.Location = New System.Drawing.Point(42, 72)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.Contraseña.Size = New System.Drawing.Size(311, 20)
        Me.Contraseña.TabIndex = 0
        '
        'Loguin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(383, 169)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loguin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Bot_cerrar As Button
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Bot_aceptar As Button
    Friend WithEvents Usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Contraseña As TextBox
End Class
