Public Class Loguin

    Private ReadOnly Obj As New DataAccess.ListaHorario
    Private ReadOnly ClsDA As New ClsDataAccess()
    Private ReadOnly clsG As New ClassGeneral

    Private Sub Loguin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadError(ClsDA.CreateDataBase())

    End Sub

    Private Sub Bot_aceptar_Click(sender As Object, e As EventArgs) Handles Bot_aceptar.Click

        Dim Check As Boolean = False
        LoadError(ClsDA.CheckUserPass(Usuario.Text, Contraseña.Text, Check))

        If Check Then

            LoadError(ClsDA.LoadHorario(Obj))

            Dim mdiPrincipal As New Principal(ClsDA, Obj, clsG)
            Me.Visible = False
            mdiPrincipal.ShowDialog()
            UnLoadForm()
        Else
            MsgBox("Usuario y/o Contraseña incorrecta." & vbNewLine & "¡Vuelva a intentarlo!", Title:="Error")
            Me.Contraseña.Text = ""
            Me.Contraseña.Select()
        End If

    End Sub

    Private Sub Bot_cerrar_Click(sender As Object, e As EventArgs) Handles Bot_cerrar.Click
        UnLoadForm()
    End Sub

    Private Sub LoadError(ByVal cError As String)

        If clsG.LoadError(cError) Then UnLoadForm()

    End Sub

    Private Sub UnLoadForm()
        Me.Hide()
        Me.Close()
    End Sub
End Class
