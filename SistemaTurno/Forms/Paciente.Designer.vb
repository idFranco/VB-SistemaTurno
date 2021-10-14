<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Paciente))
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Bot_modificar = New System.Windows.Forms.Button()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Bot_cerrar = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Bot_limpiar = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Bot_guardar = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Bot_consulta_global = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTime_fechanac = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CBox_dni = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBox_ape = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBox_nom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBox_fnacimiento = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TBox_ciudad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBox_barrio = New System.Windows.Forms.TextBox()
        Me.TBox_calle = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBox_numero = New System.Windows.Forms.TextBox()
        Me.TBox_piso = New System.Windows.Forms.TextBox()
        Me.TBox_dpto = New System.Windows.Forms.TextBox()
        Me.TBox_torre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox8.Controls.Add(Me.Bot_modificar)
        Me.GroupBox8.Location = New System.Drawing.Point(685, 129)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(191, 48)
        Me.GroupBox8.TabIndex = 24
        Me.GroupBox8.TabStop = False
        '
        'Bot_modificar
        '
        Me.Bot_modificar.BackColor = System.Drawing.Color.White
        Me.Bot_modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_modificar.Enabled = False
        Me.Bot_modificar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bot_modificar.FlatAppearance.BorderSize = 0
        Me.Bot_modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bot_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_modificar.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_modificar.Location = New System.Drawing.Point(0, 6)
        Me.Bot_modificar.Name = "Bot_modificar"
        Me.Bot_modificar.Size = New System.Drawing.Size(191, 36)
        Me.Bot_modificar.TabIndex = 7
        Me.Bot_modificar.Text = "EDITAR INFORMACION"
        Me.Bot_modificar.UseVisualStyleBackColor = False
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox14.Controls.Add(Me.Bot_cerrar)
        Me.GroupBox14.Location = New System.Drawing.Point(703, 499)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(191, 48)
        Me.GroupBox14.TabIndex = 26
        Me.GroupBox14.TabStop = False
        '
        'Bot_cerrar
        '
        Me.Bot_cerrar.BackColor = System.Drawing.Color.White
        Me.Bot_cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_cerrar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Bot_cerrar.FlatAppearance.BorderSize = 0
        Me.Bot_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.Bot_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_cerrar.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_cerrar.Location = New System.Drawing.Point(0, 10)
        Me.Bot_cerrar.Name = "Bot_cerrar"
        Me.Bot_cerrar.Size = New System.Drawing.Size(191, 31)
        Me.Bot_cerrar.TabIndex = 9
        Me.Bot_cerrar.Text = "CERRAR FORMULARIO"
        Me.Bot_cerrar.UseVisualStyleBackColor = False
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox11.Controls.Add(Me.Bot_limpiar)
        Me.GroupBox11.Location = New System.Drawing.Point(685, 222)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(191, 48)
        Me.GroupBox11.TabIndex = 25
        Me.GroupBox11.TabStop = False
        '
        'Bot_limpiar
        '
        Me.Bot_limpiar.BackColor = System.Drawing.Color.White
        Me.Bot_limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bot_limpiar.FlatAppearance.BorderSize = 0
        Me.Bot_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Bot_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_limpiar.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_limpiar.Location = New System.Drawing.Point(0, 7)
        Me.Bot_limpiar.Name = "Bot_limpiar"
        Me.Bot_limpiar.Size = New System.Drawing.Size(191, 33)
        Me.Bot_limpiar.TabIndex = 10
        Me.Bot_limpiar.Text = "LIMPIAR"
        Me.Bot_limpiar.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox9.Controls.Add(Me.Bot_guardar)
        Me.GroupBox9.Location = New System.Drawing.Point(685, 76)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(191, 48)
        Me.GroupBox9.TabIndex = 23
        Me.GroupBox9.TabStop = False
        '
        'Bot_guardar
        '
        Me.Bot_guardar.BackColor = System.Drawing.Color.White
        Me.Bot_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_guardar.Enabled = False
        Me.Bot_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bot_guardar.FlatAppearance.BorderSize = 0
        Me.Bot_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bot_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_guardar.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_guardar.Location = New System.Drawing.Point(0, 6)
        Me.Bot_guardar.Name = "Bot_guardar"
        Me.Bot_guardar.Size = New System.Drawing.Size(191, 36)
        Me.Bot_guardar.TabIndex = 8
        Me.Bot_guardar.Text = "GUARDAR INFORMACION"
        Me.Bot_guardar.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox7.Controls.Add(Me.Bot_consulta_global)
        Me.GroupBox7.Location = New System.Drawing.Point(685, 17)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(191, 48)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
        '
        'Bot_consulta_global
        '
        Me.Bot_consulta_global.BackColor = System.Drawing.Color.White
        Me.Bot_consulta_global.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_consulta_global.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bot_consulta_global.FlatAppearance.BorderSize = 0
        Me.Bot_consulta_global.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bot_consulta_global.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_consulta_global.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_consulta_global.Location = New System.Drawing.Point(0, 8)
        Me.Bot_consulta_global.Name = "Bot_consulta_global"
        Me.Bot_consulta_global.Size = New System.Drawing.Size(191, 32)
        Me.Bot_consulta_global.TabIndex = 6
        Me.Bot_consulta_global.Text = "BUSQUEDA GLOBAL"
        Me.Bot_consulta_global.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTime_fechanac)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.CBox_dni)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBox_ape)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBox_nom)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBox_fnacimiento)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 129)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'DTime_fechanac
        '
        Me.DTime_fechanac.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.DTime_fechanac.Location = New System.Drawing.Point(145, 97)
        Me.DTime_fechanac.Name = "DTime_fechanac"
        Me.DTime_fechanac.Size = New System.Drawing.Size(350, 25)
        Me.DTime_fechanac.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(501, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 123
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 14)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Número de Documento"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(6, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 13)
        Me.Label19.TabIndex = 124
        Me.Label19.Text = "_____________________"
        '
        'CBox_dni
        '
        Me.CBox_dni.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBox_dni.FormattingEnabled = True
        Me.CBox_dni.Location = New System.Drawing.Point(145, 11)
        Me.CBox_dni.MaxLength = 10
        Me.CBox_dni.Name = "CBox_dni"
        Me.CBox_dni.Size = New System.Drawing.Size(350, 27)
        Me.CBox_dni.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Apellido"
        '
        'TBox_ape
        '
        Me.TBox_ape.BackColor = System.Drawing.Color.White
        Me.TBox_ape.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.TBox_ape.Location = New System.Drawing.Point(145, 41)
        Me.TBox_ape.Name = "TBox_ape"
        Me.TBox_ape.ReadOnly = True
        Me.TBox_ape.Size = New System.Drawing.Size(350, 25)
        Me.TBox_ape.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 14)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Nombre"
        '
        'TBox_nom
        '
        Me.TBox_nom.BackColor = System.Drawing.Color.White
        Me.TBox_nom.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.TBox_nom.Location = New System.Drawing.Point(145, 70)
        Me.TBox_nom.Name = "TBox_nom"
        Me.TBox_nom.ReadOnly = True
        Me.TBox_nom.Size = New System.Drawing.Size(350, 25)
        Me.TBox_nom.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 14)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Fecha de Nacimiento"
        '
        'TBox_fnacimiento
        '
        Me.TBox_fnacimiento.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.TBox_fnacimiento.Location = New System.Drawing.Point(145, 98)
        Me.TBox_fnacimiento.Name = "TBox_fnacimiento"
        Me.TBox_fnacimiento.ReadOnly = True
        Me.TBox_fnacimiento.Size = New System.Drawing.Size(350, 25)
        Me.TBox_fnacimiento.TabIndex = 4
        Me.TBox_fnacimiento.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(6, 53)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(133, 13)
        Me.Label22.TabIndex = 125
        Me.Label22.Text = "_____________________"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(6, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(133, 13)
        Me.Label23.TabIndex = 125
        Me.Label23.Text = "_____________________"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(6, 107)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(133, 13)
        Me.Label24.TabIndex = 126
        Me.Label24.Text = "_____________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(132, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 18)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "*"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(132, 44)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(17, 18)
        Me.Label25.TabIndex = 128
        Me.Label25.Text = "*"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(132, 69)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(17, 18)
        Me.Label41.TabIndex = 129
        Me.Label41.Text = "*"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(132, 97)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(17, 18)
        Me.Label42.TabIndex = 130
        Me.Label42.Text = "*"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TBox_ciudad)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TBox_barrio)
        Me.GroupBox3.Controls.Add(Me.TBox_calle)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TBox_numero)
        Me.GroupBox3.Controls.Add(Me.TBox_piso)
        Me.GroupBox3.Controls.Add(Me.TBox_dpto)
        Me.GroupBox3.Controls.Add(Me.TBox_torre)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.Label48)
        Me.GroupBox3.Controls.Add(Me.Label49)
        Me.GroupBox3.Controls.Add(Me.Label50)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 138)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(627, 132)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'TBox_ciudad
        '
        Me.TBox_ciudad.BackColor = System.Drawing.Color.White
        Me.TBox_ciudad.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.TBox_ciudad.Location = New System.Drawing.Point(145, 103)
        Me.TBox_ciudad.Name = "TBox_ciudad"
        Me.TBox_ciudad.ReadOnly = True
        Me.TBox_ciudad.Size = New System.Drawing.Size(476, 25)
        Me.TBox_ciudad.TabIndex = 153
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 14)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Calle"
        '
        'TBox_barrio
        '
        Me.TBox_barrio.BackColor = System.Drawing.Color.White
        Me.TBox_barrio.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.TBox_barrio.Location = New System.Drawing.Point(145, 72)
        Me.TBox_barrio.Name = "TBox_barrio"
        Me.TBox_barrio.ReadOnly = True
        Me.TBox_barrio.Size = New System.Drawing.Size(476, 25)
        Me.TBox_barrio.TabIndex = 152
        '
        'TBox_calle
        '
        Me.TBox_calle.BackColor = System.Drawing.Color.White
        Me.TBox_calle.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.TBox_calle.Location = New System.Drawing.Point(145, 9)
        Me.TBox_calle.Name = "TBox_calle"
        Me.TBox_calle.ReadOnly = True
        Me.TBox_calle.Size = New System.Drawing.Size(240, 25)
        Me.TBox_calle.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(302, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 14)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Dpto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(396, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 14)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Nro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(142, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 14)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Piso"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(462, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 14)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "Torre"
        '
        'TBox_numero
        '
        Me.TBox_numero.BackColor = System.Drawing.Color.White
        Me.TBox_numero.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.TBox_numero.Location = New System.Drawing.Point(431, 9)
        Me.TBox_numero.Name = "TBox_numero"
        Me.TBox_numero.ReadOnly = True
        Me.TBox_numero.Size = New System.Drawing.Size(190, 25)
        Me.TBox_numero.TabIndex = 7
        '
        'TBox_piso
        '
        Me.TBox_piso.BackColor = System.Drawing.Color.White
        Me.TBox_piso.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.TBox_piso.Location = New System.Drawing.Point(178, 38)
        Me.TBox_piso.Name = "TBox_piso"
        Me.TBox_piso.ReadOnly = True
        Me.TBox_piso.Size = New System.Drawing.Size(120, 25)
        Me.TBox_piso.TabIndex = 8
        '
        'TBox_dpto
        '
        Me.TBox_dpto.BackColor = System.Drawing.Color.White
        Me.TBox_dpto.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.TBox_dpto.Location = New System.Drawing.Point(337, 38)
        Me.TBox_dpto.Name = "TBox_dpto"
        Me.TBox_dpto.ReadOnly = True
        Me.TBox_dpto.Size = New System.Drawing.Size(120, 25)
        Me.TBox_dpto.TabIndex = 9
        '
        'TBox_torre
        '
        Me.TBox_torre.BackColor = System.Drawing.Color.White
        Me.TBox_torre.Font = New System.Drawing.Font("Bookman Old Style", 11.25!)
        Me.TBox_torre.Location = New System.Drawing.Point(501, 38)
        Me.TBox_torre.Name = "TBox_torre"
        Me.TBox_torre.ReadOnly = True
        Me.TBox_torre.Size = New System.Drawing.Size(120, 25)
        Me.TBox_torre.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 14)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Barrio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 14)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Ciudad"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(6, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(133, 13)
        Me.Label26.TabIndex = 126
        Me.Label26.Text = "_____________________"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(6, 79)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(133, 13)
        Me.Label27.TabIndex = 127
        Me.Label27.Text = "_____________________"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(6, 110)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(133, 13)
        Me.Label28.TabIndex = 128
        Me.Label28.Text = "_____________________"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(132, 9)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(17, 18)
        Me.Label47.TabIndex = 134
        Me.Label47.Text = "*"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(419, 9)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(17, 18)
        Me.Label48.TabIndex = 135
        Me.Label48.Text = "*"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(132, 65)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(17, 18)
        Me.Label49.TabIndex = 136
        Me.Label49.Text = "*"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(132, 95)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(17, 18)
        Me.Label50.TabIndex = 151
        Me.Label50.Text = "*"
        '
        'Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(917, 558)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Paciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paciente"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Bot_modificar As Button
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents Bot_cerrar As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Bot_limpiar As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Bot_guardar As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Bot_consulta_global As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTime_fechanac As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label19 As Label
    Public WithEvents CBox_dni As ComboBox
    Friend WithEvents Label3 As Label
    Public WithEvents TBox_ape As TextBox
    Friend WithEvents Label4 As Label
    Public WithEvents TBox_nom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBox_fnacimiento As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TBox_ciudad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBox_barrio As TextBox
    Friend WithEvents TBox_calle As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TBox_numero As TextBox
    Friend WithEvents TBox_piso As TextBox
    Friend WithEvents TBox_dpto As TextBox
    Friend WithEvents TBox_torre As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
End Class
