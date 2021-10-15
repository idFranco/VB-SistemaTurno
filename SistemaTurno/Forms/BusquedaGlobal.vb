Public Class BusquedaGlobal

    Private ReadOnly ClsCG As ClsConsultaGlobal

    Private ReadOnly FRM As Form
    Private DNISelect As String
    Private cError As String

    Public Sub New(ByVal frm As Form, ByVal ClsDA As ClsDataAccess)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.FRM = frm
        Me.ClsCG = New ClsConsultaGlobal(Me, ClsDA)
    End Sub

    Private Sub BusquedaGlobal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClsCG.LoadData(1, "", cError)

        If Not cError = "" Then
            MessageBox.Show("Se produjo un error inesperado al momento de realizar la consulta en la base de datos")
            Cerrar()
        End If

        LimpiarBoton()

    End Sub

    Private Sub TBox_ape_TextChanged(sender As Object, e As EventArgs) Handles TBox_ape.TextChanged

        If Me.TBox_nom.Text <> "" Then
            Me.TBox_nom.Text = ""
        End If

        If Me.TBox_ape.Text <> "" Then
            For i = 1 To Len(Me.TBox_ape.Text)
                If Mid(Me.TBox_ape.Text, i, 1) Like "[0-9]" Then
                    MsgBox("Solo se debe ingresar valores alfanumerico en el campo Apellido del Paciente", vbInformation + vbOKOnly)
                    Me.TBox_ape.Select()
                    Return
                End If
            Next

            ClsCG.LoadData(2, Me.TBox_ape.Text, cError)
        Else
            ClsCG.LoadData(1, "", cError)
        End If

    End Sub

    Private Sub TBox_nom_TextChanged(sender As Object, e As EventArgs) Handles TBox_nom.TextChanged

        If Me.TBox_ape.Text <> "" Then
            Me.TBox_ape.Text = ""
        End If

        If Me.TBox_nom.Text <> "" Then
            For i = 1 To Len(Me.TBox_nom.Text)
                If Mid(Me.TBox_nom.Text, i, 1) Like "[0-9]" Then
                    MsgBox("Solo se debe ingresar valores alfanumerico en el campo Nombre del Paciente", vbInformation + vbOKOnly)
                    Me.TBox_nom.Select()
                    Exit Sub
                End If
            Next

            ClsCG.LoadData(3, Me.TBox_nom.Text, cError)
        Else
            ClsCG.LoadData(1, "", cError)
        End If

    End Sub

    Private Sub DGV_listado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_listado.CellContentClick

        DNISelect = Trim(DGV_listado.Item(0, DGV_listado.CurrentRow.Index).Value)

        Bot_Cargar.Enabled = True
        Bot_Cargar.BackColor = Color.LightSteelBlue
    End Sub
    Private Sub DGV_listado_DoubleClick(sender As Object, e As EventArgs) Handles DGV_listado.DoubleClick
        If Not IsDBNull(DGV_listado.Item(0, DGV_listado.CurrentRow.Index).Value) Then
            DNISelect = Trim(DGV_listado.Item(0, DGV_listado.CurrentRow.Index).Value)
            Bot_Cargar.PerformClick()
        End If
    End Sub

    Private Sub DGV_listado_MouseClick(sender As Object, e As MouseEventArgs) Handles DGV_listado.MouseClick
        If IsDBNull(DGV_listado.Item(0, DGV_listado.CurrentRow.Index).Value) Then
            Me.LimpiarBoton()
        End If
    End Sub

    Private Sub Bot_Cargar_Click(sender As Object, e As EventArgs) Handles Bot_Cargar.Click
        If DNISelect = "" Then
            MsgBox("Debe seleccionar una fila para poder continuar la carga...")
            Me.LimpiarBoton()
            Exit Sub
        End If

        Me.Cerrar()
    End Sub

    Private Sub Bot_volver_Click(sender As Object, e As EventArgs) Handles Bot_volver.Click
        Me.Cerrar()
    End Sub

    Private Sub LimpiarBoton()
        Bot_Cargar.Enabled = False
        Bot_Cargar.BackColor = Color.White
    End Sub

    Private Sub Cerrar()

        If FRM.Text = "Paciente" Then
            Dim PAC As Paciente = FRM
            If Not DNISelect = "" Then PAC.CBox_dni.Text = DNISelect
        Else
            Dim TUR As Turno = FRM
            If Not DNISelect = "" Then TUR.CBox_dni.Text = DNISelect
        End If

        Me.Hide()
        Me.Close()

    End Sub

End Class