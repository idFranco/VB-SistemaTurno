
Public Class ClsTurno

    Private ReadOnly Frm As Turno
    Private ReadOnly ClsC As New TCheck
    Private ReadOnly clsG As ClassGeneral

    Private ReadOnly ModelObj As DataAccess.ListaHorario
    Private ReadOnly ClsDA As ClsDataAccess

    Private cError As String

    Public Sub New(ByVal Frm As Turno, ByVal ClsDA As ClsDataAccess, ByVal ModObj As DataAccess.ListaHorario, ByVal clsG As ClassGeneral)
        Me.Frm = Frm
        Me.ClsDA = ClsDA
        Me.clsG = clsG
        Me.ModelObj = ModObj
    End Sub

    Public Function Load() As String

        Frm.TBox_fturno.Text = clsG.Fecha_calendario(Frm.MonthCalendar.SelectionStart.ToString)
        CargaritemdoHorario()
        Return LoadListView()

    End Function

    Public Sub CargaritemdoHorario()

        Frm.ListView.Items.Clear()

        For index = 0 To ModelObj.ListHorario.Count - 1
            Frm.ListView.Items.Add(ModelObj.ListHorario(index).Hora.ToString)
            Frm.ListView.Items.Item(index).SubItems.Add(" ")
        Next index

    End Sub

    Public Function LoadListView() As String

        Dim TurnoPac As New List(Of DataAccess.Turno)
        Dim TurnoPacTemp As New List(Of DataAccess.Turno)

        cError = ClsDA.GetTurnopacientes(Frm.TBox_fturno.Text, TurnoPac, TurnoPacTemp)

        If cError = "" Then

            CargaritemdoHorario()

            If TurnoPac.Count > 0 Then
                For index = 0 To TurnoPac.Count - 1
                    Frm.ListView.Items.Item(TurnoPac(index).IdTurno - 1).SubItems.Item(1).Text = TurnoPac(index).DNI.ToString
                    Frm.ListView.Items.Item(TurnoPac(index).IdTurno - 1).SubItems.Add(TurnoPac(index).Nombre.ToString)
                Next
            End If

            If TurnoPacTemp.Count > 0 Then
                For index = 0 To TurnoPacTemp.Count - 1
                    Frm.ListView.Items.Item(TurnoPacTemp(index).IdTurno - 1).SubItems.Item(1).Text = TurnoPacTemp(index).DNI.ToString
                    Frm.ListView.Items.Item(TurnoPacTemp(index).IdTurno - 1).SubItems.Add(TurnoPacTemp(index).Nombre.ToString)
                Next
            End If

        End If

        Return cError

    End Function

    Public Function GetName() As String

        If Not ClsC.CheckItems(Frm) Then Return Nothing

        If Len(Frm.CBox_dni.Text) > 6 Then

            cError = ClsDA.GetDataPaciente(Frm.CBox_dni.Text, Frm.TBox_apenom.Text)

        Else
            Frm.TBox_apenom.Text = ""
        End If

        Return cError
    End Function

    Public Sub GetListTurno()

        Dim fecha As String = clsG.Fecha_calendario(Frm.MonthCalendar.SelectionStart.ToString)
        If Frm.TBox_fturno.Text <> fecha Then

            Frm.TBox_fturno.Text = fecha
            LoadListView()

        End If

    End Sub

    Public Function VerificarSeleccion() As Boolean

        Return ClsC.CheckSelectionDate(Frm)

    End Function

    Public Function SetDate(ByVal Data As List(Of DataAccess.Turno),
                            ByVal OldDate As List(Of DataAccess.HoraFecha),
                            ByVal NewDate As List(Of DataAccess.HoraFecha)) As String

        Dim b As Integer = 0
        For Each item In Frm.ListView.SelectedItems

            If item.SubItems(0).Text <> "" Then

                If item.SubItems(1).Text = " " Then
                    b = 1
                    If Frm.CBox_dni.Text = "" Or Frm.TBox_apenom.Text = "" Then

                        If Not IsNothing(OldDate) Then
                            'Se actualiza la información

                            If Not Data(0).DNI = "Sin datos" Then If Not ClsC.CheckSelectionItem(Frm.ListView, Data(0).Nombre, Data(0).DNI) Then GoTo salir

                            Dim Fecha As New DataAccess.HoraFecha With {
                                    .IdHora = item.Index + 1,
                                    .Fecha = Frm.TBox_fturno.Text
                                }
                            NewDate.Add(Fecha)

                            Return UpdateDate(Data, OldDate, NewDate)

                        End If


                        Dim resultado = MsgBox("¡Se ingresará un paciente sin datos en sistema! ¿Desea Continuar?", vbOK, "Información")
                        If resultado = vbOK Then

                            'seccción de carga paciente temporal - no se encuentra cargado en el sistemas
                            Dim nombre As String = InputBox("Nombre del Paciente: ", Title:="Ingreso de información")
                            If Trim(nombre) = "" Then GoTo salir

                            'seccción de carga de turno del paciente temporal
                            cError = ClsDA.SetDataTurno(Nothing, Frm.TBox_fturno.Text, item.Index + 1, nombre)

                            If Not cError = "" Then Return cError

                            Frm.ListView.SelectedItems.Item(0).SubItems(1).Text = "Sin datos"
                            Frm.ListView.Items.Item(Frm.ListView.SelectedIndices.Item(0)).SubItems.Add(nombre)
                            ClearSelection()

                        Else
                            'MsgBox("¡Ingrese el número de DNI del paciente o diríjase a Consulta Global!", MsgBoxStyle.Information, vbOK)
                            Frm.CBox_dni.Select()
                            ClearSelection()
                            GoTo salir
                        End If

                    Else

                        If Not ClsC.CheckSelectionItem(Frm.ListView, Frm.TBox_apenom.Text, Frm.CBox_dni.Text) Then GoTo salir

                        'seccción de carga de turno del paciente
                        cError = ClsDA.SetDataTurno(Frm.CBox_dni.Text, Frm.TBox_fturno.Text, item.Index + 1)

                        If Not cError = "" Then Return cError

                        Frm.ListView.SelectedItems.Item(0).SubItems(1).Text = Frm.CBox_dni.Text
                        Frm.ListView.Items.Item(Frm.ListView.SelectedIndices.Item(0)).SubItems.Add(Trim(Frm.TBox_apenom.Text))

                        ClearSelection()

                    End If
                Else
                    MsgBox("¡Seleccione un horario que se encuentre disponible!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
                    ClearSelection()
                    GoTo salir

                End If

            End If

        Next

        If b = 1 Then
            MsgBox("¡Se asignó correctamente la fecha y horario!", MsgBoxStyle.OkOnly)
        Else
            MsgBox("¡Se debe seleccionar un horario para continuar!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
        End If
salir:
        Return ""
    End Function

    Public Function UpdateDate(ByRef OldDate As List(Of DataAccess.HoraFecha),
                               ByRef Data As List(Of DataAccess.Turno)) As String

        If Frm.Bot_editar_fecha.Text = "EDITAR FECHA" Then

            For Each item In Frm.ListView.SelectedItems

                If Not ClsC.CheckItemSelect(Frm) Then GoTo salir


                Dim resultado = MsgBox("¡Se editará la información seleccionada!" & vbNewLine & "¡A continuación, seleccione la nueva fecha y horario de turno y presione el botón ASIGNAR TURNO!", vbOK, "Información")
                If resultado <> vbOK Then GoTo salir

                Dim Fecha As New DataAccess.HoraFecha With {
                                    .IdHora = item.Index + 1,
                                    .Fecha = Frm.TBox_fturno.Text
                                }
                OldDate.Add(Fecha)

                Dim Turno As New DataAccess.Turno With {
                                    .DNI = item.SubItems(1).Text,
                                    .Nombre = item.SubItems(2).Text
                                }
                Data.Add(Turno)

                item.SubItems(1).Text = " "
                item.SubItems(2).Text = ""
                Frm.ListView.SelectedItems.Clear()

                Frm.Bot_editar_fecha.Text = "CANCELAR EDITADO"
                DesactivarBot()

            Next

        Else
            'Cancelación de la edición de fecha
            Frm.Bot_editar_fecha.Text = "EDITAR FECHA"

            If OldDate(0).Fecha = Frm.TBox_fturno.Text Then
                CargaritemdoHorario()
                Return LoadListView()
            End If
            Me.ActivarBot()

        End If
salir:
        Return ""
    End Function

    Private Function UpdateDate(ByVal Data As List(Of DataAccess.Turno),
                                ByVal OldDate As List(Of DataAccess.HoraFecha),
                                ByVal NewDate As List(Of DataAccess.HoraFecha)) As String

        cError = ClsDA.UpdateDate(Data, OldDate, NewDate)

        If cError = "" Then

            Frm.ListView.SelectedItems.Item(0).SubItems(1).Text = Data(0).DNI
            Frm.ListView.Items.Item(Frm.ListView.SelectedIndices.Item(0)).SubItems.Add(Data(0).Nombre)
            MsgBox("¡Se actualizó correctamente la fecha y hora!")

        End If
        Frm.Bot_editar_fecha.Text = "EDITAR FECHA"
        ActivarBot()
        Return cError

    End Function

    Public Function DeleteDate() As String

        For Each item In Frm.ListView.SelectedItems

            If Not ClsC.CheckItemSelect(Frm) Then GoTo salir

            Dim resultado = MsgBox("¡Se eliminará el turno seleccionado!" & vbNewLine & "¿Desea continuar?", vbOK, "Información")
            If resultado <> vbOK Then GoTo salir

            Dim LDate = New List(Of DataAccess.HoraFecha)
            Dim Fecha As New DataAccess.HoraFecha With {
                                    .IdHora = item.Index + 1,
                                    .Fecha = Frm.TBox_fturno.Text
                                }
            LDate.Add(Fecha)

            Dim Data = New List(Of DataAccess.Turno)
            Dim Turno As New DataAccess.Turno With {
                .DNI = item.SubItems(1).Text,
                .Nombre = item.SubItems(2).Text
            }
            Data.Add(Turno)

            cError = ClsDA.DeleteShift(Data, LDate)

            If cError = "" Then

                item.SubItems(1).Text = " "
                item.SubItems(2).Text = ""
                Frm.ListView.SelectedItems.Clear()
                MsgBox("¡Se eliminó correctamente la fecha y hora seleccionada!")

            End If

        Next
salir:
        Return cError
    End Function

    Private Sub ClearSelection()
        Frm.ListView.SelectedItems.Clear()
        If Not Frm.CBox_dni.Text = "" Then Frm.CBox_dni.Text = ""
    End Sub

    Private Sub ActivarBot()
        Frm.CBox_dni.Enabled = True
        Frm.CBox_dni.Text = ""
        Frm.TBox_apenom.Text = ""
        Frm.Bot_eliminar.Enabled = True
        Frm.Bot_consulta_global.Enabled = True
        Frm.Bot_cerrar.Enabled = True
    End Sub
    Private Sub DesactivarBot()
        Frm.Bot_eliminar.Enabled = False
        Frm.Bot_consulta_global.Enabled = False
        Frm.Bot_cerrar.Enabled = False
        Frm.CBox_dni.Enabled = False
    End Sub

    Public Sub ConsultaGlobal(frm As Form)

        Dim ClsG As New ClassGeneral
        ClsG.ConsultaGlobal(frm, ClsDA)

    End Sub


End Class


Public Class TCheck

    ''' <summary>
    ''' Verifica si se ingresó dato en el campo Número de Documento
    ''' </summary>
    Public Function CheckItems(ByVal Frm As Turno) As Boolean

        If Len(Frm.CBox_dni.Text) > 0 And IsNumeric(Frm.CBox_dni.Text) = False Then
            MsgBox("Solo se debe ingresar valores numericos en el campo Número de Documento", vbInformation + vbOKOnly)
            Frm.CBox_dni.Select()
            Return False
        End If

        Return True

    End Function

    ''' <summary>
    ''' Verifica si el campo seleccionado contiene datos
    ''' </summary>
    Public Function CheckItemSelect(ByVal Frm As Turno) As Boolean

        If Frm.ListView.SelectedItems.Item(0).SubItems(1).Text = " " Then
            MsgBox("¡Seleccione un campo con datos!", MsgBoxStyle.Information, vbOK)
            Return False
        End If

        Return True

    End Function

    ''' <summary>
    ''' Verifica que la fecha seleccionada sea mayor o igual que la del día actua
    ''' </summary>
    Public Function CheckSelectionDate(ByVal Frm As Turno) As Boolean

        If DateTime.Compare(Format(CDate(Frm.TBox_fturno.Text)), Format(CDate(Date.Now().ToShortDateString))) < 0 Then
            MsgBox("Seleccione una fecha mayor o igual a la del día de hoy --> " & Date.Now().ToShortDateString, Title:="Información")
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Verifica si se encuentra el paciente con turno en el itemdo de horario
    ''' </summary>
    Public Function CheckSelectionItem(ByVal LV As ListView,
                                       ByVal Name As String,
                                       ByVal DNI As String) As Boolean
        Dim itmx As ListViewItem
        If Name <> "" Then
            itmx = LV.FindItemWithText(DNI)
            If itmx IsNot Nothing Then
                itmx.Selected = True
                itmx.ForeColor = Color.Red
                itmx.EnsureVisible()
                MsgBox("¡El paciente ya tiene fecha de turno asignada! Se resaltó en color Rojo al mismo")
                Return False
            End If
        End If

        Return True

    End Function

End Class
