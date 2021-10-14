Imports DataAccess

Public Class ClsDataAccess : Inherits DataBase

    Private ReadOnly Obj As ListaHorario
    Private ReadOnly ConnDB As New Conexion_DB
    Private ReadOnly Path = Application.StartupPath & "\Data\"
    Private cError As String

    Public Sub New(ByVal obj As ListaHorario)
        Me.Obj = obj
    End Sub

    Public Function CreateDataBase() As String
        Return CreateDB(Path, cError)
    End Function

    Public Function LoadHorario() As String
        Return ConnDB.GetHorario(Obj)
    End Function

    Public Function CheckUserPass(ByVal User As String, ByVal Pass As String, ByRef Check As Boolean) As String
        Return ConnDB.CheckUserPass(User, Pass, Check)
    End Function

    '**************************** Get ****************************'
    Public Function GetDataPaciente(ByVal DNI As String, ByRef LPersona As List(Of Persona), ByRef Check As Boolean) As String
        Return ConnDB.GetDataPerson(DNI, LPersona, Check)
    End Function

    Public Function GetDataPaciente(ByVal DNI As String, ByRef Name As String) As String
        Return ConnDB.GetDataPerson(DNI, Name)
    End Function

    Public Function GetDataPacientes(ByVal op As Integer, ByVal text As String, ByRef dt As DataTable) As String
        Return ConnDB.GetDataPersons(op, text, dt)
    End Function

    Public Function GetTurnopacientes(ByVal Fecha As String, ByRef TurnoP As List(Of DataAccess.Turno), ByRef TurnoPT As List(Of DataAccess.Turno)) As String
        Return ConnDB.GetTurnoPersonas(Fecha, TurnoP, TurnoPT)
    End Function

    '**************************** Set ****************************'
    Public Function SetDataPaciente(ByVal Persona As List(Of Persona)) As String
        Return ConnDB.SetDataPerson(Persona)
    End Function

    Public Function SetDataTurno(ByVal DNI As String, ByVal Fecha As String, ByVal idHS As Integer, ByVal Optional NamePacTem As String = "") As String
        Return ConnDB.SetDataTurno(DNI, Fecha, idHS, NamePacTem)
    End Function

    '**************************** UpDate ****************************'

    Public Function UpdateDataPaciente(ByVal Persona As List(Of Persona), ByVal DNI_anterior As String) As String
        Return ConnDB.UpDateDataPerson(Persona, DNI_anterior)
    End Function

    Public Function UpdateDate(ByVal Data As List(Of DataAccess.Turno), ByVal OldDate As List(Of HoraFecha), ByVal NewDate As List(Of HoraFecha)) As String
        Return ConnDB.UpdateDate(Data, OldDate, NewDate)
    End Function


    '**************************** Delete ****************************'

    Public Function DeleteShift(ByVal Data As List(Of DataAccess.Turno), ByVal LDate As List(Of HoraFecha)) As String
        Return ConnDB.DeleteShift(Data, LDate)
    End Function

End Class
