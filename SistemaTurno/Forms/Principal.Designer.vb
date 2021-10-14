<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.menu_vertical = New System.Windows.Forms.Panel()
        Me.Btn_Paciente = New System.Windows.Forms.Button()
        Me.Btn_Turno = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.hora = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.segundos = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.menu_vertical.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_vertical
        '
        Me.menu_vertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.menu_vertical.Controls.Add(Me.Panel2)
        Me.menu_vertical.Controls.Add(Me.Panel1)
        Me.menu_vertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.menu_vertical.ForeColor = System.Drawing.Color.White
        Me.menu_vertical.Location = New System.Drawing.Point(0, 0)
        Me.menu_vertical.Name = "menu_vertical"
        Me.menu_vertical.Size = New System.Drawing.Size(250, 608)
        Me.menu_vertical.TabIndex = 13
        '
        'Btn_Paciente
        '
        Me.Btn_Paciente.FlatAppearance.BorderSize = 0
        Me.Btn_Paciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Btn_Paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Paciente.ForeColor = System.Drawing.Color.White
        Me.Btn_Paciente.Image = CType(resources.GetObject("Btn_Paciente.Image"), System.Drawing.Image)
        Me.Btn_Paciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Paciente.Location = New System.Drawing.Point(0, 3)
        Me.Btn_Paciente.Name = "Btn_Paciente"
        Me.Btn_Paciente.Size = New System.Drawing.Size(255, 50)
        Me.Btn_Paciente.TabIndex = 0
        Me.Btn_Paciente.Text = "Paciente"
        Me.Btn_Paciente.UseVisualStyleBackColor = True
        '
        'Btn_Turno
        '
        Me.Btn_Turno.FlatAppearance.BorderSize = 0
        Me.Btn_Turno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Btn_Turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Turno.ForeColor = System.Drawing.Color.White
        Me.Btn_Turno.Image = CType(resources.GetObject("Btn_Turno.Image"), System.Drawing.Image)
        Me.Btn_Turno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Turno.Location = New System.Drawing.Point(0, 59)
        Me.Btn_Turno.Name = "Btn_Turno"
        Me.Btn_Turno.Size = New System.Drawing.Size(255, 50)
        Me.Btn_Turno.TabIndex = 1
        Me.Btn_Turno.Text = "Turno"
        Me.Btn_Turno.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_Paciente)
        Me.Panel1.Controls.Add(Me.Btn_Turno)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 112)
        Me.Panel1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_Salir)
        Me.Panel2.Controls.Add(Me.hora)
        Me.Panel2.Controls.Add(Me.fecha)
        Me.Panel2.Controls.Add(Me.segundos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 478)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 130)
        Me.Panel2.TabIndex = 15
        '
        'Btn_Salir
        '
        Me.Btn_Salir.FlatAppearance.BorderSize = 0
        Me.Btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.ForeColor = System.Drawing.Color.White
        Me.Btn_Salir.Image = CType(resources.GetObject("Btn_Salir.Image"), System.Drawing.Image)
        Me.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.Location = New System.Drawing.Point(-3, 3)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(263, 50)
        Me.Btn_Salir.TabIndex = 11
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'hora
        '
        Me.hora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.hora.AutoSize = True
        Me.hora.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hora.Location = New System.Drawing.Point(3, 69)
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(164, 65)
        Me.hora.TabIndex = 14
        Me.hora.Text = "00:00"
        '
        'fecha
        '
        Me.fecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(0, 51)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(245, 21)
        Me.fecha.TabIndex = 13
        Me.fecha.Text = "Miercoles, 20 de Sepiembre"
        Me.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'segundos
        '
        Me.segundos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.segundos.AutoSize = True
        Me.segundos.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundos.Location = New System.Drawing.Point(162, 98)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(39, 29)
        Me.segundos.TabIndex = 15
        Me.segundos.Text = "00"
        '
        'Timer
        '
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 608)
        Me.Controls.Add(Me.menu_vertical)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(1188, 608)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.menu_vertical.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menu_vertical As Panel
    Friend WithEvents Btn_Paciente As Button
    Friend WithEvents Btn_Turno As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents hora As Label
    Friend WithEvents fecha As Label
    Friend WithEvents segundos As Label
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Timer As Timer
End Class
