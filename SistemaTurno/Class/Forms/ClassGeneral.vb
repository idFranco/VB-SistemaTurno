Public Class ClassGeneral

    Public Sub ConsultaGlobal(frm As Form)

        frm.MdiParent.Enabled = False
        Dim FRM_BG As New BusquedaGlobal(frm)
        FRM_BG.ShowDialog()
        frm.MdiParent.Enabled = True

    End Sub

    Public Function GetMdiContainer(ByVal frm As Form) As MdiClient

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

    Public Function Fecha_calendario(fecha As String) As String

        Dim dia As String
        Dim mes As String
        Dim año As String

        dia = Mid(fecha, 1, 1)
        Dim i As Integer = 2

        While Mid(fecha, i, 1) <> "/"
            dia &= Mid(fecha, i, 1)
            i += 1
        End While
        If Len(dia) = 1 Then
            dia = "0" & dia
        End If

        mes = Mid(fecha, i + 1, 1)
        i += 2
        While Mid(fecha, i, 1) <> "/"
            mes &= Mid(fecha, i, 1)
            i += 1
        End While
        If Len(mes) = 1 Then
            mes = "0" & mes
        End If

        i += 1
        año = Mid(fecha, i, 4)

        Return dia & "/" & mes & "/" & año

    End Function

End Class
