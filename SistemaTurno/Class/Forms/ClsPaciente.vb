Public Class ClsPaciente

    Private ReadOnly Frm As Paciente
    Private ReadOnly ClsC As New PCheck
    Private ReadOnly ClsDA As ClsDataAccess

    Public dni_anterior As String
    Public Sub New(ByVal Frm As Paciente, ByVal ClsDA As ClsDataAccess)
        Me.Frm = Frm
        Me.ClsDA = ClsDA
    End Sub

    Public Sub LoadData(ByVal Persona As List(Of DataAccess.Persona))

        FRM.DTime_fechanac.Visible = False
        FRM.TBox_fnacimiento.Visible = True

        'APELLIDO Y NOMMBRE
        Dim i As Integer
        Dim var As String
        Dim texto As String = Persona(0).ApellidoNombre

        var = Mid(texto, 1, 1)
        i = 2
        While Mid(texto, i, 1) <> ","
            var &= Mid(texto, i, 1)
            i += 1
        End While
        FRM.TBox_ape.Text = Trim(var)

        i += 1
        var = Mid(texto, i, 1)
        While Mid(Trim(texto), i, 1) <> ""
            var &= Mid(texto, i, 1)
            i += 1
        End While

        FRM.TBox_nom.Text = Trim(var)

        'FECHA DE NACIMIENTO
        FRM.TBox_fnacimiento.Text = Persona(0).FechaNacimiento

        'DOMICILIO
        var = Persona(0).Domicilio

        Dim calle As String
        calle = Mid(var, 1, 1)
        i = 2
        Dim b As Integer = 0
        'calle
        While b = 0
            If Mid(var, i, 1) <> "|" Then
                calle &= Mid(var, i, 1)
            Else
                b = 1
                FRM.TBox_calle.Text = Trim(calle)
                calle = ""
            End If
            i += 1
        End While
        'numero
        b = 0
        While b = 0
            If Mid(var, i, 1) <> "|" Then
                calle &= Mid(var, i, 1)
            Else
                b = 1
                FRM.TBox_numero.Text = Trim(calle)
                calle = ""
            End If
            i += 1
        End While

        If Mid(var, i, 1) <> "" Then
            'piso
            b = 0
            calle = ""
            While b = 0
                If Mid(var, i, 1) <> "|" Then
                    calle &= Mid(var, i, 1)
                Else
                    b = 1
                    FRM.TBox_piso.Text = Trim(calle)
                    calle = ""
                End If
                i += 1
            End While
        End If

        If Mid(var, i, 1) <> "" Then
            'dpto
            b = 0
            calle = ""
            While b = 0
                If Mid(var, i, 1) <> "|" Then
                    calle &= Mid(var, i, 1)
                Else
                    b = 1
                    FRM.TBox_dpto.Text = Trim(calle)
                    calle = ""
                End If
                i += 1
            End While
        End If

        If Mid(var, i, 1) <> "" Then
            'torre
            b = 0
            calle = ""
            While b = 0
                If Mid(var, i, 1) <> "|" Then
                    calle &= Mid(var, i, 1)
                Else
                    b = 1
                    FRM.TBox_torre.Text = Trim(calle)
                    calle = ""
                End If
                i += 1
            End While
        End If

        'BARRIO
        FRM.TBox_barrio.Text = Persona(0).Barrio

        'CIUDAD
        FRM.TBox_ciudad.Text = Persona(0).Ciudad

        FRM.Bot_guardar.Enabled = False

    End Sub

    Public Function CheckData() As Boolean

        Return ClsC.CheckItems(Frm)

    End Function

    Public Function ModelData() As List(Of DataAccess.Persona)

        '****************************************   NOMBRE
        Dim variable As String
        Frm.TBox_ape.Text = LTrim(Frm.TBox_ape.Text)
        Frm.TBox_nom.Text = LTrim(Frm.TBox_nom.Text)

        variable = UCase(Mid(Frm.TBox_ape.Text, 1, 1))
        variable = variable & LCase(Mid(Frm.TBox_ape.Text, 2, Len(Frm.TBox_ape.Text))) & ", "

        variable &= UCase(Mid(Frm.TBox_nom.Text, 1, 1))

        For i = 2 To Len(Frm.TBox_nom.Text)
            If Mid(Frm.TBox_nom.Text, i, 1) <> " " Then
                variable &= LCase(Mid(Frm.TBox_nom.Text, i, 1))
            Else
                i += 1
                variable = variable & " " & UCase(Mid(Frm.TBox_nom.Text, i, 1))
            End If
        Next

        Dim ApeNom As String = variable

        '****************************************   FECHA DE NACIMIENTO
        If Frm.DTime_fechanac.Visible = True Then
            Dim clsG As New ClassGeneral
            variable = clsG.Fecha_calendario(Frm.DTime_fechanac.Value.ToString)
        Else
            variable = Frm.TBox_fnacimiento.Text
        End If

        Dim FechaNac As String = variable

        '****************************************   DOMICILIO
        variable = UCase(Mid(Frm.TBox_calle.Text, 1, 1))
        variable = variable & Mid(LCase(Frm.TBox_calle.Text), 2, Len(Frm.TBox_calle.Text)) & "|" & Frm.TBox_numero.Text

        If Frm.TBox_piso.Text <> "" Then
            Frm.TBox_piso.Text = LTrim(Frm.TBox_piso.Text)
            variable &= "|" & Frm.TBox_piso.Text
        End If
        If Frm.TBox_dpto.Text <> "" Then
            Frm.TBox_dpto.Text = LTrim(Frm.TBox_dpto.Text)
            variable &= "|" & Frm.TBox_dpto.Text
        End If
        If Frm.TBox_torre.Text <> "" Then
            Frm.TBox_torre.Text = LTrim(Frm.TBox_torre.Text)
            variable &= "|" & Frm.TBox_torre.Text
        End If

        variable &= "|"

        Dim Domicilio As String = variable

        '****************************************   BARRIO
        variable = UCase(Mid(Frm.TBox_barrio.Text, 1, 1))
        variable &= LCase(Mid(Frm.TBox_barrio.Text, 2, Len(Frm.TBox_barrio.Text)))

        Dim Barrio As String = variable

        '****************************************   CIUDAD
        variable = UCase(Mid(Frm.TBox_ciudad.Text, 1, 1))
        variable &= LCase(Mid(Frm.TBox_ciudad.Text, 2, Len(Frm.TBox_ciudad.Text)))

        Dim Ciudad As String = variable

        Dim Persona As New List(Of DataAccess.Persona)
        Dim Datos As New DataAccess.Persona With {
                                   .DNI = Frm.CBox_dni.Text,
                                   .ApellidoNombre = ApeNom,
                                   .FechaNacimiento = FechaNac,
                                   .Domicilio = Domicilio,
                                   .Barrio = Barrio,
                                   .Ciudad = Ciudad
                               }
        Persona.Add(Datos)
        Return Persona

    End Function

    Public Sub ACTIVAR()

        Me.ESCRIBIR()

        Frm.TBox_fnacimiento.Visible = False
        Frm.DTime_fechanac.Visible = True

        Frm.Bot_modificar.Enabled = False
        Frm.Bot_guardar.Enabled = True

    End Sub

    Public Sub DESACTIVAR()

        If Frm.CBox_dni.Enabled = False Then
            Frm.Bot_modificar.Enabled = True
            Frm.Bot_guardar.Enabled = False
        Else
            Frm.Bot_modificar.Enabled = True
            Frm.Bot_guardar.Enabled = False

            Frm.TBox_fnacimiento.ReadOnly = True
            Frm.TBox_ape.ReadOnly = True
            Frm.TBox_nom.ReadOnly = True
            Frm.TBox_calle.ReadOnly = True
            Frm.TBox_numero.ReadOnly = True
            Frm.TBox_piso.ReadOnly = True
            Frm.TBox_dpto.ReadOnly = True
            Frm.TBox_torre.ReadOnly = True
            Frm.TBox_barrio.ReadOnly = True
            Frm.TBox_ciudad.ReadOnly = True

            Frm.TBox_fnacimiento.Visible = True
            Frm.DTime_fechanac.Visible = False
        End If

    End Sub

    Public Sub ESCRIBIR()

        Frm.TBox_fnacimiento.ReadOnly = False
        Frm.TBox_ape.ReadOnly = False
        Frm.TBox_nom.ReadOnly = False
        Frm.TBox_calle.ReadOnly = False
        Frm.TBox_numero.ReadOnly = False
        Frm.TBox_piso.ReadOnly = False
        Frm.TBox_dpto.ReadOnly = False
        Frm.TBox_torre.ReadOnly = False
        Frm.TBox_barrio.ReadOnly = False
        Frm.TBox_ciudad.ReadOnly = False

    End Sub

    Public Sub BORRAR()

        If Frm.TBox_ape.Text <> "" Then
            Frm.TBox_ape.Text = ""
            Frm.TBox_nom.Text = ""
            Frm.TBox_fnacimiento.Text = ""
            Frm.TBox_calle.Text = ""
            Frm.TBox_numero.Text = ""
            Frm.TBox_piso.Text = ""
            Frm.TBox_dpto.Text = ""
            Frm.TBox_torre.Text = ""
            Frm.TBox_barrio.Text = ""
            Frm.TBox_ciudad.Text = ""
        End If

    End Sub

    Public Sub ClearElements()

        If Frm.CBox_dni.Text <> "" Then
            Frm.CBox_dni.Text = ""

            DESACTIVAR()

            Frm.Bot_modificar.Enabled = False
            Frm.TBox_fnacimiento.Visible = False
            Frm.DTime_fechanac.Visible = True
            Frm.CBox_dni.Select()
        End If

    End Sub

    Public Sub ACTIVAREDITADO()

        Frm.CBox_dni.Enabled = True
        Frm.Bot_guardar.Enabled = True

        Frm.DTime_fechanac.Visible = True
        Frm.DTime_fechanac.Value = Format(CDate(Frm.TBox_fnacimiento.Text), "dd/MM/yyyy")

        Frm.TBox_fnacimiento.Text = ""
        Frm.TBox_fnacimiento.Visible = False

        ESCRIBIR()
        Frm.Bot_modificar.Text = "CANCELAR EDITADO"
        Frm.Bot_consulta_global.Enabled = False
        Frm.Bot_limpiar.Enabled = False

    End Sub

    Public Sub DESACTIVAREDITADO()

        Frm.Bot_modificar.Text = "EDITAR INFORMACION"
        Frm.Bot_consulta_global.Enabled = True
        Frm.Bot_limpiar.Enabled = True
        Frm.Bot_limpiar.PerformClick()

    End Sub

    Public Function InsertarDatos(ByVal Persona As List(Of DataAccess.Persona)) As String

        Return ClsDA.SetDataPaciente(Persona)

    End Function
    Public Function ObtenerDatos(ByVal LPersona As List(Of DataAccess.Persona), ByRef Check As Boolean) As String

        Return ClsDA.GetDataPaciente(Frm.CBox_dni.Text, LPersona, Check)

    End Function

    Public Function ActualizarDatos(ByVal Persona As List(Of DataAccess.Persona), ByVal dniAnterior As String) As String

        Return ClsDA.UpdateDataPaciente(Persona, dniAnterior)

    End Function
    Public Sub ConsultaGlobal(frm As Form)

        Dim ClsG As New ClassGeneral
        ClsG.ConsultaGlobal(frm)

    End Sub


End Class

Public Class PCheck

    ''' <summary>
    ''' Verifica si se ingresó todos los datos requeridos
    ''' </summary>
    Public Function CheckItems(ByVal Frm As Paciente) As Boolean

        If Len(Frm.TBox_ape.Text) = 0 Then
            MsgBox("Se debe ingresar información en el campo Apellido del Paciente", vbInformation + vbOKOnly)
            Frm.TBox_ape.Select()
            Return False
        Else
            For i = 1 To Len(Frm.TBox_ape.Text)
                If Mid(Frm.TBox_ape.Text, i, 1) Like "[0-9]" Then
                    MsgBox("Solo se debe ingresar valores alfanumerico en el campo Apellido del Paciente", vbInformation + vbOKOnly)
                    Frm.TBox_ape.Select()
                    Return False
                End If
            Next

            If Len(Frm.TBox_nom.Text) = 0 Then
                MsgBox("Se debe ingresar información en el campo Nombre del Paciente", vbInformation + vbOKOnly)
                Frm.TBox_nom.Select()
                Return False
            Else
                For i = 1 To Len(Frm.TBox_ape.Text)
                    If Mid(Frm.TBox_nom.Text, i, 1) Like "[0-9]" Then
                        MsgBox("Solo se debe ingresar valores alfanumerico en el campo Nombre del Paciente", vbInformation + vbOKOnly)
                        Frm.TBox_nom.Select()
                        Return False
                    End If
                Next

                If Frm.DTime_fechanac.Value.Year >= Date.Now.Year Then
                    MsgBox("Seleccione fecha menor a la del año actual")
                    Frm.DTime_fechanac.Select()
                    Return False
                Else

                    If Len(Frm.TBox_calle.Text) = 0 Then
                        MsgBox("Se debe ingresar informacion en el campo Calle", vbInformation + vbOKOnly)
                        Frm.TBox_calle.Select()
                        Return False
                    Else

                        If Len(Frm.TBox_numero.Text) = 0 Then
                            MsgBox("Se debe ingresar informacion en el campo Número", vbInformation + vbOKOnly)
                            Frm.TBox_calle.Select()
                            Return False
                        Else

                            If Len(Frm.TBox_numero.Text) > 0 And IsNumeric(Frm.TBox_numero.Text) = False Then
                                MsgBox("Solo se debe ingresar valores numericos en el campo Número", vbInformation + vbOKOnly)
                                Frm.CBox_dni.Select()
                                Return False
                            Else

                                If Len(Frm.TBox_barrio.Text) = 0 Then
                                    MsgBox("Se debe ingresar información o seleccionar un item en el campo Barrio", vbInformation + vbOKOnly)
                                    Frm.TBox_barrio.Select()
                                    Return False
                                Else

                                    If Len(Frm.TBox_ciudad.Text) = 0 Then
                                        MsgBox("Se debe ingresar información o seleccionar un item en el campo Ciudad", vbInformation + vbOKOnly)
                                        Frm.TBox_ciudad.Select()
                                        Return False
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Return True

    End Function

End Class
