Public Class ClsConsultaGlobal

    Private ReadOnly ClsDA As ClsDataAccess

    Private ReadOnly Frm As BusquedaGlobal

    Public Sub New(ByVal Frm As BusquedaGlobal, ByVal ClsDA As ClsDataAccess)
        Me.Frm = Frm
        Me.ClsDA = ClsDA
    End Sub


    Public Sub LoadData(ByVal op As Integer, ByVal text As String, ByRef cError As String)

        Dim dt As New DataTable
        cError = ClsDA.GetDataPacientes(op, text, dt)

        If Not cError = "" Then Return

        Frm.DGV_listado.DataSource = dt

        Frm.DGV_listado.Columns("idDNI").HeaderText = "DNI"
        Frm.DGV_listado.Columns("ApeNom").HeaderText = "Apellido y Nombre"
        Frm.DGV_listado.Columns("idDNI").MinimumWidth = 180
        Frm.DGV_listado.Columns("Apenom").MinimumWidth = 250

        If Frm.DGV_listado.Rows.Count = 1 Then
            MessageBox.Show("¡No se encontraron datos del Apellido y/o Nombre ingresado!")
            Frm.DGV_listado.Enabled = False
            Return
        End If
        'ordeno de manera descendente la columna de apellido y nombre
        Frm.DGV_listado.Enabled = True
        Frm.DGV_listado.Sort(Frm.DGV_listado.Columns(1), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

End Class
