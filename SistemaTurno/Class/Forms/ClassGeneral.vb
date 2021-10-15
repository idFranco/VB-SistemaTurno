Public Class ClassGeneral

    Public Sub ConsultaGlobal(frm As Form, ByVal ClsDA As ClsDataAccess)

        frm.MdiParent.Enabled = False
        Dim FRM_BG As New BusquedaGlobal(frm, ClsDA)
        FRM_BG.ShowDialog()
        frm.MdiParent.Enabled = True

    End Sub

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

    Public Function LoadError(ByVal cError As String) As Boolean

        If Not IsNothing(cError) And Not cError = "" Then
            MessageBox.Show(cError)
            Return True
        End If
        Return False

    End Function

End Class
