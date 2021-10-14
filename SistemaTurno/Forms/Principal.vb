Public Class Principal

    Private ReadOnly Obj As New DataAccess.ListaHorario
    Private ReadOnly ClsDA As ClsDataAccess

    Public Sub New(ByVal ClsDA As ClsDataAccess, ByVal Obj As DataAccess.ListaHorario)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.Obj = Obj
        Me.ClsDA = ClsDA

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ctlMdiClient As MdiClient = GetMdiContainer(Me)
        If Not (ctlMdiClient Is Nothing) Then
            ctlMdiClient.BackColor = Color.White
        End If

        Timer.Start()

    End Sub

    Private Shared Function GetMdiContainer(ByVal frm As Form) As MdiClient

        Dim resultado As MdiClient = Nothing
        Dim ctl As Control
        For Each ctl In frm.Controls
            If ctl.GetType = GetType(MdiClient) Then
                resultado = CType(ctl, MdiClient)
                Exit For
            End If
        Next
        Return resultado

    End Function

    Private Sub Btn_Paciente_Click(sender As Object, e As EventArgs) Handles Btn_Paciente.Click

        If Not IsNothing(Me.ActiveMdiChild) Then
            If Me.ActiveMdiChild.Text = "Paciente" Then Return
            Me.ActiveMdiChild.Hide()
        End If

        Dim PAC As New Paciente(ClsDA) With {
            .MdiParent = Me
        }
        PAC.Show()
        PAC.CBox_dni.Select()

    End Sub

    Private Sub Btn_Turno_Click(sender As Object, e As EventArgs) Handles Btn_Turno.Click

        If Not IsNothing(Me.ActiveMdiChild) Then
            If Me.ActiveMdiChild.Text = "Turno" Then Return
            Me.ActiveMdiChild.Hide()
        End If

        Dim TUR As New Turno(ClsDA, Obj) With {
            .MdiParent = Me
        }
        TUR.Show()
        TUR.CBox_dni.Select()

    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Hide()
        Me.Close()
    End Sub


    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        segundos.Text = DateTime.Now.ToString("ss")
        hora.Text = DateTime.Now.ToString("hh:mm")
        fecha.Text = DateTime.Now.ToString("dddd, dd MMMM")
    End Sub


End Class