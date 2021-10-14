<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaGlobal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBox_ape = New System.Windows.Forms.TextBox()
        Me.TBox_nom = New System.Windows.Forms.TextBox()
        Me.Bot_Cargar = New System.Windows.Forms.Button()
        Me.DGV_listado = New System.Windows.Forms.DataGridView()
        Me.Bot_volver = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DGV_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "   - Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(205, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "   - Nombre"
        '
        'TBox_ape
        '
        Me.TBox_ape.BackColor = System.Drawing.Color.White
        Me.TBox_ape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBox_ape.Location = New System.Drawing.Point(22, 41)
        Me.TBox_ape.Name = "TBox_ape"
        Me.TBox_ape.Size = New System.Drawing.Size(159, 20)
        Me.TBox_ape.TabIndex = 154
        '
        'TBox_nom
        '
        Me.TBox_nom.BackColor = System.Drawing.Color.White
        Me.TBox_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBox_nom.Location = New System.Drawing.Point(208, 41)
        Me.TBox_nom.Name = "TBox_nom"
        Me.TBox_nom.Size = New System.Drawing.Size(266, 20)
        Me.TBox_nom.TabIndex = 155
        '
        'Bot_Cargar
        '
        Me.Bot_Cargar.BackColor = System.Drawing.Color.White
        Me.Bot_Cargar.Enabled = False
        Me.Bot_Cargar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.Bot_Cargar.Location = New System.Drawing.Point(53, 87)
        Me.Bot_Cargar.Name = "Bot_Cargar"
        Me.Bot_Cargar.Size = New System.Drawing.Size(155, 27)
        Me.Bot_Cargar.TabIndex = 150
        Me.Bot_Cargar.Text = "CARGAR EN FORMULARIO"
        Me.Bot_Cargar.UseVisualStyleBackColor = False
        '
        'DGV_listado
        '
        Me.DGV_listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_listado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_listado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_listado.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_listado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_listado.EnableHeadersVisualStyles = False
        Me.DGV_listado.GridColor = System.Drawing.Color.White
        Me.DGV_listado.Location = New System.Drawing.Point(14, 128)
        Me.DGV_listado.MaximumSize = New System.Drawing.Size(470, 371)
        Me.DGV_listado.MinimumSize = New System.Drawing.Size(470, 371)
        Me.DGV_listado.MultiSelect = False
        Me.DGV_listado.Name = "DGV_listado"
        Me.DGV_listado.ReadOnly = True
        Me.DGV_listado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_listado.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_listado.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Eras Demi ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DGV_listado.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_listado.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_listado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV_listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_listado.Size = New System.Drawing.Size(470, 371)
        Me.DGV_listado.TabIndex = 149
        '
        'Bot_volver
        '
        Me.Bot_volver.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.Bot_volver.Location = New System.Drawing.Point(271, 87)
        Me.Bot_volver.MaximumSize = New System.Drawing.Size(155, 27)
        Me.Bot_volver.MinimumSize = New System.Drawing.Size(155, 27)
        Me.Bot_volver.Name = "Bot_volver"
        Me.Bot_volver.Size = New System.Drawing.Size(155, 27)
        Me.Bot_volver.TabIndex = 151
        Me.Bot_volver.Text = "REGRESAR"
        Me.Bot_volver.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(14, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(470, 58)
        Me.Button1.TabIndex = 152
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatAppearance.BorderSize = 3
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(491, 513)
        Me.Button3.TabIndex = 153
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BusquedaGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 515)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBox_ape)
        Me.Controls.Add(Me.TBox_nom)
        Me.Controls.Add(Me.Bot_Cargar)
        Me.Controls.Add(Me.DGV_listado)
        Me.Controls.Add(Me.Bot_volver)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximumSize = New System.Drawing.Size(513, 558)
        Me.MinimumSize = New System.Drawing.Size(513, 558)
        Me.Name = "BusquedaGlobal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGV_listado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Public WithEvents TBox_ape As TextBox
    Public WithEvents TBox_nom As TextBox
    Friend WithEvents Bot_Cargar As Button
    Friend WithEvents DGV_listado As DataGridView
    Friend WithEvents Bot_volver As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
