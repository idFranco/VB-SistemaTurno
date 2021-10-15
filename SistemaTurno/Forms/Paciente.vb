Public Class Paciente

    Private ReadOnly clsG As ClassGeneral
    Private ReadOnly ClsPac As ClsPaciente

    Private Check As Boolean

    Public Sub New(ByVal ClsDA As ClsDataAccess, ByVal clsG As ClassGeneral)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.clsG = clsG
        Me.ClsPac = New ClsPaciente(Me, ClsDA, clsG)
    End Sub
    Private Sub CBox_dni_TextChanged(sender As Object, e As EventArgs) Handles CBox_dni.TextChanged

        If Len(Me.CBox_dni.Text) > 0 And IsNumeric(Me.CBox_dni.Text) = False Then
            MsgBox("Solo se debe ingresar valores numericos en el campo Número de Documento", vbInformation + vbOKOnly)
            Me.CBox_dni.Select()
            Return
        End If

        If ClsPac.dni_anterior <> "" Then Return

        If Len(Me.CBox_dni.Text) > 6 Then

            Dim LPersona As New List(Of DataAccess.Persona)
            Check = False
            LoadError(ClsPac.ObtenerDatos(LPersona, Check))

            If Check Then

                ClsPac.LoadData(LPersona)
                ClsPac.DESACTIVAR()
                ClsPac.dni_anterior = ""
            Else
                Me.Bot_modificar.Enabled = False
                ClsPac.BORRAR()
                ClsPac.ACTIVAR()

            End If

        Else

            ClsPac.BORRAR()
            ClsPac.ACTIVAR()

        End If

    End Sub


    Private Sub LoadError(ByVal cError As String)

        If clsG.LoadError(cError) Then UnLoadForm()

    End Sub

    Private Sub Bot_consulta_global_Click(sender As Object, e As EventArgs) Handles Bot_consulta_global.Click

        ClsPac.ConsultaGlobal(Me)

    End Sub

    Private Sub Bot_guardar_Click(sender As Object, e As EventArgs) Handles Bot_guardar.Click

        If ClsPac.CheckData() Then

            Dim Persona = ClsPac.ModelData()

            If ClsPac.dni_anterior = "" Then
                LoadError(ClsPac.InsertarDatos(Persona))
                MessageBox.Show("¡Información guardada correctamente!")
            Else
                LoadError(ClsPac.ActualizarDatos(Persona, ClsPac.dni_anterior))
                ClsPac.dni_anterior = ""
                MessageBox.Show("¡Información editada correctamente!")
            End If

            Dim dni = Me.CBox_dni.Text
            Me.CBox_dni.Text = ""
            Me.CBox_dni.Text = dni

        End If

    End Sub

    Private Sub Bot_modificar_Click(sender As Object, e As EventArgs) Handles Bot_modificar.Click

        If Bot_modificar.Text = "EDITAR INFORMACION" Then

            Dim resultado = MsgBox("¡Proceda a modificar los datos y luego presiones el botón Guardar Informacion! ¿Desea Continuar?", vbOK, "Información")
            If resultado <> vbOK Then
                MsgBox("¡Cancelado!", vbOK, "Información")
                Return
            End If

            ClsPac.dni_anterior = Me.CBox_dni.Text
            ClsPac.ACTIVAREDITADO()

        Else

            ClsPac.dni_anterior = ""
            ClsPac.DESACTIVAREDITADO()

        End If

    End Sub

    Private Sub Bot_limpiar_Click(sender As Object, e As EventArgs) Handles Bot_limpiar.Click
        ClsPac.ClearElements()
    End Sub

    Private Sub Bot_cerrar_Click(sender As Object, e As EventArgs) Handles Bot_cerrar.Click
        UnLoadForm()
    End Sub

    Private Sub UnLoadForm()
        Me.Hide()
        Me.Close()
    End Sub

End Class