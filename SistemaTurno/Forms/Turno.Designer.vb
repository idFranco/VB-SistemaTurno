<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turno
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
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Bot_cerrar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Bot_eliminar = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Bot_editar_fecha = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Bot_consulta_global = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Bot_asignar_fecha = New System.Windows.Forms.Button()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CBox_dni = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBox_apenom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBox_fturno = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.GroupBox10)
        Me.GroupBox11.Location = New System.Drawing.Point(578, 450)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(287, 77)
        Me.GroupBox11.TabIndex = 158
        Me.GroupBox11.TabStop = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Bot_cerrar)
        Me.GroupBox10.Location = New System.Drawing.Point(35, 15)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(227, 48)
        Me.GroupBox10.TabIndex = 10
        Me.GroupBox10.TabStop = False
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
        Me.Bot_cerrar.Location = New System.Drawing.Point(0, 16)
        Me.Bot_cerrar.Name = "Bot_cerrar"
        Me.Bot_cerrar.Size = New System.Drawing.Size(227, 21)
        Me.Bot_cerrar.TabIndex = 9
        Me.Bot_cerrar.Text = "CERRAR FORMULARIO"
        Me.Bot_cerrar.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Location = New System.Drawing.Point(578, 283)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(287, 113)
        Me.GroupBox5.TabIndex = 157
        Me.GroupBox5.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Bot_eliminar)
        Me.GroupBox7.Location = New System.Drawing.Point(35, 60)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(227, 35)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        '
        'Bot_eliminar
        '
        Me.Bot_eliminar.BackColor = System.Drawing.Color.White
        Me.Bot_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Bot_eliminar.FlatAppearance.BorderSize = 0
        Me.Bot_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.Bot_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_eliminar.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_eliminar.Location = New System.Drawing.Point(0, 10)
        Me.Bot_eliminar.Name = "Bot_eliminar"
        Me.Bot_eliminar.Size = New System.Drawing.Size(227, 21)
        Me.Bot_eliminar.TabIndex = 6
        Me.Bot_eliminar.Text = "ELIMINAR FECHA"
        Me.Bot_eliminar.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Bot_editar_fecha)
        Me.GroupBox6.Location = New System.Drawing.Point(35, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(227, 35)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        '
        'Bot_editar_fecha
        '
        Me.Bot_editar_fecha.BackColor = System.Drawing.Color.White
        Me.Bot_editar_fecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_editar_fecha.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Bot_editar_fecha.FlatAppearance.BorderSize = 0
        Me.Bot_editar_fecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.Bot_editar_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_editar_fecha.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_editar_fecha.Location = New System.Drawing.Point(0, 10)
        Me.Bot_editar_fecha.Name = "Bot_editar_fecha"
        Me.Bot_editar_fecha.Size = New System.Drawing.Size(227, 21)
        Me.Bot_editar_fecha.TabIndex = 5
        Me.Bot_editar_fecha.Text = "EDITAR FECHA"
        Me.Bot_editar_fecha.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Bot_consulta_global)
        Me.GroupBox4.Location = New System.Drawing.Point(578, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(287, 41)
        Me.GroupBox4.TabIndex = 155
        Me.GroupBox4.TabStop = False
        '
        'Bot_consulta_global
        '
        Me.Bot_consulta_global.BackColor = System.Drawing.Color.White
        Me.Bot_consulta_global.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_consulta_global.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Bot_consulta_global.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bot_consulta_global.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_consulta_global.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_consulta_global.Location = New System.Drawing.Point(35, 11)
        Me.Bot_consulta_global.Name = "Bot_consulta_global"
        Me.Bot_consulta_global.Size = New System.Drawing.Size(227, 23)
        Me.Bot_consulta_global.TabIndex = 3
        Me.Bot_consulta_global.Text = "BUSQUEDA GLOBAL"
        Me.Bot_consulta_global.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Bot_asignar_fecha)
        Me.GroupBox3.Controls.Add(Me.GroupBox18)
        Me.GroupBox3.Controls.Add(Me.MonthCalendar)
        Me.GroupBox3.Location = New System.Drawing.Point(578, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(287, 202)
        Me.GroupBox3.TabIndex = 156
        Me.GroupBox3.TabStop = False
        '
        'Bot_asignar_fecha
        '
        Me.Bot_asignar_fecha.BackColor = System.Drawing.Color.White
        Me.Bot_asignar_fecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bot_asignar_fecha.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Bot_asignar_fecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bot_asignar_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_asignar_fecha.Font = New System.Drawing.Font("Bell MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bot_asignar_fecha.Location = New System.Drawing.Point(23, 167)
        Me.Bot_asignar_fecha.Name = "Bot_asignar_fecha"
        Me.Bot_asignar_fecha.Size = New System.Drawing.Size(246, 21)
        Me.Bot_asignar_fecha.TabIndex = 6
        Me.Bot_asignar_fecha.Text = "ASIGNAR FECHA"
        Me.Bot_asignar_fecha.UseVisualStyleBackColor = False
        '
        'GroupBox18
        '
        Me.GroupBox18.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox18.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox18.Location = New System.Drawing.Point(23, 147)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(246, 55)
        Me.GroupBox18.TabIndex = 163
        Me.GroupBox18.TabStop = False
        '
        'MonthCalendar
        '
        Me.MonthCalendar.Location = New System.Drawing.Point(22, 9)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.TabIndex = 5
        Me.MonthCalendar.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListView)
        Me.GroupBox2.Location = New System.Drawing.Point(52, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 406)
        Me.GroupBox2.TabIndex = 154
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agenda de turno"
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView.FullRowSelect = True
        Me.ListView.GridLines = True
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(33, 19)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(380, 379)
        Me.ListView.TabIndex = 4
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Hora"
        Me.ColumnHeader1.Width = 45
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DNI"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Apellido y Nombre"
        Me.ColumnHeader3.Width = 240
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.CBox_dni)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBox_apenom)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBox_fturno)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 99)
        Me.GroupBox1.TabIndex = 153
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 14)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Número de Documento"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(6, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 13)
        Me.Label19.TabIndex = 124
        Me.Label19.Text = "_____________________"
        '
        'CBox_dni
        '
        Me.CBox_dni.FormattingEnabled = True
        Me.CBox_dni.Location = New System.Drawing.Point(145, 19)
        Me.CBox_dni.Name = "CBox_dni"
        Me.CBox_dni.Size = New System.Drawing.Size(293, 21)
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
        Me.Label3.Size = New System.Drawing.Size(108, 14)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Apellido y Nombre"
        '
        'TBox_apenom
        '
        Me.TBox_apenom.Enabled = False
        Me.TBox_apenom.Location = New System.Drawing.Point(145, 46)
        Me.TBox_apenom.Name = "TBox_apenom"
        Me.TBox_apenom.Size = New System.Drawing.Size(293, 20)
        Me.TBox_apenom.TabIndex = 2
        Me.TBox_apenom.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 14)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Fecha de Turno"
        '
        'TBox_fturno
        '
        Me.TBox_fturno.Enabled = False
        Me.TBox_fturno.Location = New System.Drawing.Point(145, 72)
        Me.TBox_fturno.Name = "TBox_fturno"
        Me.TBox_fturno.Size = New System.Drawing.Size(293, 20)
        Me.TBox_fturno.TabIndex = 3
        Me.TBox_fturno.TabStop = False
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
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(6, 79)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(133, 13)
        Me.Label24.TabIndex = 126
        Me.Label24.Text = "_____________________"
        '
        'Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(917, 558)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turno"
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Bot_cerrar As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Bot_eliminar As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Bot_editar_fecha As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Bot_consulta_global As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Bot_asignar_fecha As Button
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents MonthCalendar As MonthCalendar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label19 As Label
    Public WithEvents CBox_dni As ComboBox
    Friend WithEvents Label3 As Label
    Public WithEvents TBox_apenom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBox_fturno As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
End Class
