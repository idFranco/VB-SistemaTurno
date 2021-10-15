Public Class Turno

    Private ReadOnly ClsTur As ClsTurno
    Private ReadOnly clsG As ClassGeneral

    Private Data As List(Of DataAccess.Turno)
    Private OldDate As List(Of DataAccess.HoraFecha)
    Private NewDate As List(Of DataAccess.HoraFecha)

    Public Sub New(ByVal ClsDA As ClsDataAccess, ByVal ModObj As DataAccess.ListaHorario, ByVal clsG As ClassGeneral)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.clsG = clsG
        ClsTur = New ClsTurno(Me, ClsDA, ModObj, clsG)
    End Sub


    Private Sub Turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadError(ClsTur.Load())

    End Sub


    Private Sub CBox_dni_TextChanged(sender As Object, e As EventArgs) Handles CBox_dni.TextChanged

        LoadError(ClsTur.GetName())

    End Sub

    Private Sub Bot_consulta_global_Click(sender As Object, e As EventArgs) Handles Bot_consulta_global.Click

        ClsTur.ConsultaGlobal(Me)

    End Sub


    Private Sub MonthCalendar_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar.DateSelected

        ClsTur.GetListTurno()

    End Sub


    Private Sub Bot_asignar_fecha_Click(sender As Object, e As EventArgs) Handles Bot_asignar_fecha.Click

        If ClsTur.VerificarSeleccion() Then

            NewDate = New List(Of DataAccess.HoraFecha)
            LoadError(ClsTur.SetDate(Data, OldDate, NewDate))

            ClerObjects()

        End If

    End Sub

    Private Sub Bot_editar_fecha_Click(sender As Object, e As EventArgs) Handles Bot_editar_fecha.Click

        If ClsTur.VerificarSeleccion() Then

            If Me.Bot_editar_fecha.Text = "EDITAR FECHA" Then
                OldDate = New List(Of DataAccess.HoraFecha)
                Data = New List(Of DataAccess.Turno)
            End If

            LoadError(ClsTur.UpdateDate(OldDate, Data))

        End If

    End Sub

    Private Sub Bot_eliminar_Click(sender As Object, e As EventArgs) Handles Bot_eliminar.Click

        LoadError(ClsTur.DeleteDate())

    End Sub


    Private Sub Bot_cerrar_Click(sender As Object, e As EventArgs) Handles Bot_cerrar.Click
        UnLoadForm()
    End Sub

    Private Sub LoadError(ByVal cError As String)

        If clsG.LoadError(cError) Then UnLoadForm()

    End Sub

    Private Sub ClerObjects()
        Data = Nothing
        OldDate = Nothing
        NewDate = Nothing
    End Sub

    Private Sub UnLoadForm()
        Me.Hide()
        Me.Close()
    End Sub

End Class