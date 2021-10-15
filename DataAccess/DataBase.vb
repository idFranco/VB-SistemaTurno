Imports System.Data.SQLite
Imports System.IO

Public Class DataBase : Inherits ClsDataBase

    ''' <summary>
    ''' En caso de no existir, crea en el archivo raiz una carpeta contenedora y la base de datos
    ''' </summary>
    Public Function CreateDB(ByVal pathDB As String, ByRef cError As String) As String

        If Not Directory.Exists(pathDB) Then
            'se crear la carpeta temporal raiz
            Directory.CreateDirectory(pathDB)
        End If

        pathDB &= "Turno.db"
        Dim dbConn As String = "Data Source=" & pathDB & "; Version=3"
        Dim conn As SQLiteConnection
        Dim command As SQLiteCommand

        If Not File.Exists(pathDB) Then
            'se crea la base de datos en caso de que no exista
            SQLiteConnection.CreateFile(pathDB)

            conn = New SQLiteConnection(dbConn)
            Try
                conn.Open()

                command = New SQLiteCommand(DDBB.TableCuenta, conn)
                command.ExecuteNonQuery()

                command = New SQLiteCommand(DDBB.TablePacientes, conn)
                command.ExecuteNonQuery()

                command = New SQLiteCommand(DDBB.TablePacientesTemporales, conn)
                command.ExecuteNonQuery()

                command = New SQLiteCommand(DDBB.TableHorarios, conn)
                command.ExecuteNonQuery()

                command = New SQLiteCommand(DDBB.TableCitasFechas, conn)
                command.ExecuteNonQuery()

                command = New SQLiteCommand(DDBB.TableFechaHorario, conn)
                command.ExecuteNonQuery()

                command = New SQLiteCommand(DDBB.InsertCuenta, conn)
                command.ExecuteNonQuery()

                command = New SQLiteCommand(DDBB.InsertHorario, conn)
                command.ExecuteNonQuery()

                Dim sConection As String = dbConn

                If sConection = "" Or sConection <> My.Settings.sConnection Then
                    My.Settings.sConnection = sConection
                    My.Settings.Save()
                End If

            Catch ex As Exception
                cError = $"Error al momento de la creación de la Base de Datos - Diríjase a {Application.StartupPath}\Data\ y elimine la Base de Datos creada {ex}"
            Finally
                conn.Close()
            End Try

        End If

        Return cError

    End Function

End Class


Public Class Conexion_DB

    Private ReadOnly Conn As SQLiteConnection
    Private cError As String

    Public Sub New()
        Conn = New SQLiteConnection(My.Settings.sConnection)
    End Sub

    ''' <summary>
    ''' Obtiene el listado del horario cargado
    ''' </summary>
    Public Function GetHorario(ByRef Obj As ListaHorario) As String

        Obj.ListHorario = New List(Of Horario)
        cError = ""
        Try
            Conn.Open()

            Dim query As String = "SELECT * FROM Horarios"

            Using command = New SQLiteCommand(query, Conn)

                Using reader = command.ExecuteReader()

                    While reader.Read()
                        Dim Horario As New Horario With {
                                .Id = reader($"{TuplaId.idHorario}").ToString(),
                                .Hora = reader($"{Tupla.Hora}").ToString()
                            }
                        Obj.ListHorario.Add(Horario)
                    End While
                End Using
            End Using

        Catch ex As Exception
            cError = $"Error al momento de obtener el listado de horario {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function

    ''' <summary>
    ''' Verifica si el Usuario y Contraseña son correctos
    ''' </summary>
    Public Function CheckUserPass(ByVal User As String,
                                  ByVal Pass As String,
                                  ByRef Check As Boolean) As String
        cError = ""
        Try
            Conn.Open()

            Dim query As String = $"SELECT * FROM {TableName.Cuenta} {Condition.WHERE} {Tupla.Usuario} = '{User}' AND {Tupla.Contraseña} = '{Pass}'"

            Using command = New SQLiteCommand(query, Conn)

                Using reader = command.ExecuteReader()

                    Check = reader.HasRows

                End Using
            End Using

        Catch ex As Exception
            cError = $"Error al momento de la verificación de datos de Usuario y Contraseña {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function


    ''' <summary>
    ''' Obtiene los datos personales de un paciente
    ''' </summary>
    Public Function GetDataPerson(ByVal DNI As String,
                                  ByRef LPersona As List(Of Persona),
                                  ByRef Check As Boolean) As String
        cError = ""
        Try
            Conn.Open()

            Dim query As String = $"SELECT * FROM {TableName.Pacientes} {Condition.WHERE} {TuplaId.idDNI} = '{DNI}'"

            Using command = New SQLiteCommand(query, Conn)

                Using reader = command.ExecuteReader()

                    If reader.HasRows Then

                        While reader.Read()
                            Dim Persona As New Persona With {
                                    .ApellidoNombre = reader($"{Tupla.ApeNom}").ToString(),
                                    .FechaNacimiento = reader($"{Tupla.FNac}").ToString(),
                                    .Domicilio = reader($"{Tupla.Domicilio}").ToString(),
                                    .Barrio = reader($"{Tupla.Barrio}").ToString(),
                                    .Ciudad = reader($"{Tupla.Ciudad}").ToString()
                                }
                            LPersona.Add(Persona)
                        End While
                        Check = True
                    End If

                End Using
            End Using

        Catch ex As Exception
            cError = $"Error al momento de tomar los datos de la persona {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function

    ''' <summary>
    ''' Obtiene el nombre completo de un paciente
    ''' </summary>
    Public Function GetDataPerson(ByVal DNI As String,
                                  ByRef Name As String) As String
        cError = ""
        Try
            Conn.Open()

            Dim query As String = $"SELECT {Tupla.ApeNom} FROM {TableName.Pacientes} {Condition.WHERE} {TuplaId.idDNI} = '{DNI}'"

            Using command = New SQLiteCommand(query, Conn)

                Using reader = command.ExecuteReader()

                    If reader.HasRows Then

                        Name = reader($"{Tupla.ApeNom}").ToString()

                    End If

                End Using
            End Using

        Catch ex As Exception
            cError = $"Error al momento de tomar los datos de la persona {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function

    ''' <summary>
    ''' Obtiene los datos de todos los pacientes
    ''' </summary>
    Public Function GetDataPersons(ByVal op As Integer,
                                   ByVal text As String,
                                   ByRef dt As DataTable) As String
        cError = ""
        Try
            Conn.Open()

            Dim da As New SQLiteDataAdapter

            da = New SQLiteDataAdapter(QueryPacientes(op, text), Conn)

            da.Fill(dt)

        Catch ex As Exception
            cError = $"Error al momento de tomar todos los datos de los pacientes {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function

    Private Function QueryPacientes(ByVal op As Integer,
                                    ByVal text As String) As String
        Dim query As String = ""
        Select Case op
            Case 1
                query = $"SELECT {TuplaId.idDNI}, {Tupla.ApeNom} FROM {TableName.Pacientes}"
            Case 2
                query = $"SELECT {TuplaId.idDNI}, {Tupla.ApeNom} FROM {TableName.Pacientes} WHERE {Tupla.ApeNom} Like '" & text & "%'"
            Case 3
                query = $"SELECT {TuplaId.idDNI}, {Tupla.ApeNom} FROM {TableName.Pacientes} WHERE {Tupla.ApeNom} Like '%" & text & "%'"
        End Select

        Return query
    End Function

    ''' <summary>
    ''' Obtiene el siguiente ID de la tabla Fechas
    ''' </summary>
    Private Function GetIdTableFechas(ByRef cant As Integer) As String
        cError = ""
        Try
            Conn.Open()

            Dim query As String = $"SELECT {TuplaId.idFecha} FROM {TableName.Fechas} {Condition.ORDER} {Condition.BY} {TuplaId.idFecha} {Condition.DESC} {Condition.LIMIT} 1"

            Using command = New SQLiteCommand(query, Conn)

                Using reader = command.ExecuteReader()

                    If reader.HasRows Then

                        cant = reader($"{TuplaId.idFecha}") + 1

                    End If

                End Using
            End Using

        Catch ex As Exception
            cError = $"Error al momento de tomar datos de la tabla Fechas {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function

    ''' <summary>
    ''' Obtiene el ID de la tabla Fechas
    ''' </summary>
    Private Function GetIdTableFechas(ByVal DNI As String,
                                      ByVal Fecha As String,
                                      ByRef id As Integer) As String
        cError = ""
        Try
            Conn.Open()

            Dim query As String = ""
            query = $"SELECT {TuplaId.idFecha} FROM {TableName.Fechas} {Condition.WHERE} {TuplaFk.fk_idDNI} = '{DNI}' AND {Tupla.Fecha} = '{Fecha}'"

            Using command = New SQLiteCommand(query, Conn)

                Using reader = command.ExecuteReader()

                    If reader.HasRows Then

                        id = reader($"{TuplaId.idFecha}")

                    End If

                End Using
            End Using

        Catch ex As Exception
            cError = $"Error al momento de tomar datos de la tabla Fechas {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function

    ''' <summary>
    ''' Obtiene el siguiente ID de la tabla Pacientes Temporales
    ''' </summary>
    Private Function GetIdTablePacientesTemporales(ByRef cant As Integer) As String
        cError = ""
        Try
            Conn.Open()

            Dim query As String = $"SELECT {TuplaId.idTemp} FROM {TableName.PacientesTemporales} {Condition.ORDER} {Condition.BY} {TuplaId.idTemp} {Condition.DESC} {Condition.LIMIT} 1"

            Using command = New SQLiteCommand(query, Conn)

                Using reader = command.ExecuteReader()

                    If reader.HasRows Then

                        cant = reader($"{TuplaId.idTemp}") + 1

                    End If

                End Using
            End Using

        Catch ex As Exception
            cError = $"Error al momento de tomar datos de la tabla Pacientes Temporales {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function

    ''' <summary>
    ''' Obtiene el ID del paciente temporal y de la Fecha de la tabla Pacientes Temporales. Realizando un Join con la tabla Fechas y FechaHorario
    ''' </summary>
    Private Function GetIdTablePacientesTemporales(ByRef idF As Integer,
                                                   ByRef idPT As Integer,
                                                   ByVal Name As String,
                                                   ByVal Fecha As String,
                                                   ByVal IdHorario As Integer) As String
        cError = ""
        Try
            Conn.Open()

            Dim query As String = $"SELECT F.{TuplaId.idFecha}, PT.{TuplaId.idTemp} FROM {TableName.PacientesTemporales} PT 
                                    JOIN {TableName.Fechas} F ON F.{TuplaFk.fk_idTemp} = PT.{TuplaId.idTemp}
                                    JOIN {TableName.FechaHorario} FH ON FH.{TuplaId.idFecha} = F.{TuplaId.idFecha}
                                    {Condition.WHERE} PT.{Tupla.ApeNom} = '{Name}' AND F.{Tupla.Fecha} = '{Fecha}' AND FH.{TuplaId.idHorario} = {IdHorario}"

            Using command = New SQLiteCommand(query, Conn)

                Using reader = command.ExecuteReader()

                    If reader.HasRows Then
                        idF = reader($"{TuplaId.idFecha}")
                        idPT = reader($"{TuplaId.idTemp}")
                    End If

                End Using
            End Using

        Catch ex As Exception
            cError = $"Error al momento de tomar datos de la tabla Pacientes Temporales {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function

    ''' <summary>
    ''' Obtiene el listado de turnos de pacientes de una fecha determinada
    ''' </summary>
    Public Function GetTurnoPersonas(ByVal Fecha As String,
                                     ByRef TurnoP As List(Of Turno),
                                     ByRef TurnoPT As List(Of Turno)) As String
        cError = ""
        Try
            Conn.Open()

            Using command = New SQLiteCommand(QueryTurnos(1, Fecha), Conn)

                Using reader = command.ExecuteReader()

                    If reader.HasRows Then

                        While reader.Read()
                            Dim Turno As New Turno With {
                                    .IdTurno = reader($"{TuplaId.idHorario}").ToString(),
                                    .DNI = reader($"{TuplaId.idDNI}").ToString(),
                                    .Nombre = reader($"{Tupla.ApeNom}").ToString()
                                }
                            TurnoP.Add(Turno)
                        End While

                    End If

                End Using
            End Using

            Using command = New SQLiteCommand(QueryTurnos(2, Fecha), Conn)

                Using reader = command.ExecuteReader()

                    If reader.HasRows Then

                        While reader.Read()
                            Dim Turno As New Turno With {
                                    .IdTurno = reader($"{TuplaId.idHorario}").ToString(),
                                    .DNI = "Sin datos",
                                    .Nombre = reader($"{Tupla.ApeNom}").ToString()
                                }
                            TurnoPT.Add(Turno)
                        End While

                    End If

                End Using
            End Using

        Catch ex As Exception
            cError = $"Error al momento al tomar los datos de los turnos {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function

    Private Function QueryTurnos(ByVal op As Integer,
                                 ByVal fecha As String) As String
        Dim query As String = ""
        Select Case op
            Case 1
                query = $"SELECT H.{TuplaId.idHorario}, P.{TuplaId.idDNI}, P.{Tupla.ApeNom} FROM {TableName.Horarios} H
                            JOIN {TableName.FechaHorario} FH ON H.{TuplaId.idHorario} = FH.{TuplaId.idHorario}
                            JOIN {TableName.Fechas} F ON FH.{TuplaId.idFecha} = F.{TuplaId.idFecha}
                            JOIN {TableName.Pacientes} P ON F.{TuplaFk.fk_idDNI} = P.{TuplaId.idDNI}
                            WHERE F.{Tupla.Fecha} = '{fecha}'"
            Case 2
                query = $"SELECT H.{TuplaId.idHorario}, PT.{Tupla.ApeNom} FROM {TableName.Horarios} H
                            JOIN {TableName.FechaHorario} FH ON H.{TuplaId.idHorario} = FH.{TuplaId.idHorario}
                            JOIN {TableName.Fechas} F ON FH.{TuplaId.idFecha} = F.{TuplaId.idFecha}
                            JOIN {TableName.PacientesTemporales} PT ON F.{TuplaFk.fk_idTemp} = PT.{TuplaId.idTemp}
                            WHERE F.{Tupla.Fecha} = '{fecha}'"
        End Select

        Return query
    End Function





    ''' <summary>
    ''' Se ingresa los datos ingresados del paciente
    ''' </summary>
    Public Function SetDataPerson(ByVal Persona As List(Of Persona)) As String
        cError = ""
        Try
            Conn.Open()

            Dim query As String = $"INSERT {Condition.INTO} {TableName.Pacientes} ({TuplaId.idDNI}, {Tupla.ApeNom}, {Tupla.FNac}, {Tupla.Domicilio}, {Tupla.Barrio}, {Tupla.Ciudad})
                VALUES ('{Persona(0).DNI}', '{Persona(0).ApellidoNombre}', '{Persona(0).FechaNacimiento}', '{Persona(0).Domicilio}', '{Persona(0).Barrio}', '{Persona(0).Ciudad}')"

            Using command = New SQLiteCommand(query, Conn)
                command.ExecuteReader()
            End Using

        Catch ex As Exception
            cError = $"Error al momento de guardar la información de la persona {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function

    ''' <summary>
    ''' Se ingresa los datos del turno seleccionado
    ''' </summary>
    Public Function SetDataTurno(ByVal DNI As String,
                                 ByVal Fecha As String,
                                 ByVal idHS As Integer,
                                 ByVal Optional NamePacTem As String = "") As String

        Dim idF As Integer = 1
        cError = GetIdTableFechas(idF)
        Dim idPacTem As Integer = 1
        If DNI = "" Then cError = GetIdTablePacientesTemporales(idPacTem)

        If cError = "" Then
            Try
                Conn.Open()

                Dim query As String = ""
                If Not DNI = "" Then
                    query = $"INSERT {Condition.INTO} {TableName.Fechas} ({Tupla.Fecha}, {TuplaFk.fk_idDNI}) VALUES ('{Fecha}', '{DNI}');"
                Else
                    query = $"INSERT {Condition.INTO} {TableName.PacientesTemporales} ({Tupla.ApeNom}) VALUES ('{NamePacTem}');
                              INSERT {Condition.INTO} {TableName.Fechas} ({Tupla.Fecha}, {TuplaFk.fk_idTemp}) VALUES ('{Fecha}', '{idPacTem}');"
                End If

                query &= $"INSERT {Condition.INTO} {TableName.FechaHorario} ({TuplaId.idFecha}, {TuplaId.idHorario}) VALUES ({idF}, {idHS});"

                Using command = New SQLiteCommand(query, Conn)
                    command.ExecuteReader()
                End Using

            Catch ex As Exception
                cError = $"Error al momento de guardar la información del turno asignado al paciente {ex}"
            Finally
                Conn.Close()
            End Try
        End If

        Return cError

    End Function





    ''' <summary>
    ''' Se actualiza la información de la persona
    ''' </summary>
    Public Function UpdateDataPerson(ByVal Persona As List(Of Persona), ByVal DNI_anterior As String) As String
        cError = ""
        Try
            Conn.Open()

            Dim query As String = $"UPDATE {TableName.Pacientes} SET 
                                    {TuplaId.idDNI} = '{Persona(0).DNI}', 
                                    {Tupla.ApeNom} = '{Persona(0).ApellidoNombre}', 
                                    {Tupla.FNac} = '{Persona(0).FechaNacimiento}', 
                                    {Tupla.Domicilio} = '{Persona(0).Domicilio}',
                                    {Tupla.Barrio} = '{Persona(0).Barrio}', 
                                    {Tupla.Ciudad} = '{Persona(0).Ciudad}'
                                    {Condition.WHERE} {TuplaId.idDNI} = '{DNI_anterior}'"

            Using command = New SQLiteCommand(query, Conn)
                command.ExecuteReader()
            End Using

        Catch ex As Exception
            cError = $"Error al momento de editar la información de la persona {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function

    ''' <summary>
    ''' Se actualiza la información del turno
    ''' </summary>
    Public Function UpdateDate(ByVal Data As List(Of DataAccess.Turno), ByVal OldDate As List(Of HoraFecha), ByVal NewDate As List(Of HoraFecha)) As String

        Dim IdFecha As Integer
        Dim IdPacTemp As Integer
        Dim query As String

        If Not Data(0).DNI = "Sin datos" Then

            cError = GetIdTableFechas(Data(0).DNI, OldDate(0).Fecha, IdFecha)
            query = $"UPDATE {TableName.Fechas} Set {Tupla.Fecha} = '{NewDate(0).Fecha}' {Condition.WHERE} 
                    {TuplaFk.fk_idDNI} = '{Data(0).DNI}' AND {Tupla.Fecha} = '{OldDate(0).Fecha}';"
        Else

            cError = GetIdTablePacientesTemporales(IdFecha, IdPacTemp, Data(0).Nombre, OldDate(0).Fecha, OldDate(0).IdHora)
            query = $"UPDATE {TableName.Fechas} Set {Tupla.Fecha} = '{NewDate(0).Fecha}' {Condition.WHERE} 
                    {TuplaFk.fk_idTemp} = {IdPacTemp} AND {Tupla.Fecha} = '{OldDate(0).Fecha}';"

        End If
        If Not cError = "" Then Return cError

        Try
            Conn.Open()

            query &= $"UPDATE {TableName.FechaHorario} Set {TuplaId.idHorario} = {NewDate(0).IdHora} {Condition.WHERE} 
                        {TuplaId.idFecha} = {IdFecha} AND {TuplaId.idHorario} = {OldDate(0).IdHora}"

            Using command = New SQLiteCommand(query, Conn)
                command.ExecuteReader()
            End Using

        Catch ex As Exception
            cError = $"Error al momento de editar la información del turno {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function




    ''' <summary>
    ''' Se borra la información del turno
    ''' </summary>
    Public Function DeleteShift(ByVal Data As List(Of DataAccess.Turno), ByVal LDate As List(Of HoraFecha)) As String

        Dim IdFecha As Integer
        Dim IdPacTemp As Integer
        Dim query As String

        If Not Data(0).DNI = "Sin datos" Then

            cError = GetIdTableFechas(Data(0).DNI, LDate(0).Fecha, IdFecha)
            query = $"DELETE {Condition.FROM} {TableName.FechaHorario} {Condition.WHERE} 
                    {TuplaId.idFecha} = {IdFecha} AND {TuplaId.idHorario} = {LDate(0).IdHora};
                    DELETE {Condition.FROM} {TableName.Fechas} {Condition.WHERE} 
                    {TuplaId.idFecha} = {IdFecha} AND {TuplaFk.fk_idDNI} = '{Data(0).DNI}';"
        Else

            cError = GetIdTablePacientesTemporales(IdFecha, IdPacTemp, Data(0).Nombre, LDate(0).Fecha, LDate(0).IdHora)
            query = $"DELETE {Condition.FROM} {TableName.FechaHorario} {Condition.WHERE} 
                    {TuplaId.idFecha} = {IdFecha} AND {TuplaId.idHorario} = {LDate(0).IdHora};
                    DELETE {Condition.FROM} {TableName.Fechas} {Condition.WHERE} 
                    {TuplaId.idFecha} = {IdFecha} AND {TuplaFk.fk_idTemp} = {IdPacTemp};
                    DELETE {Condition.FROM} {TableName.PacientesTemporales} {Condition.WHERE} 
                    {TuplaId.idTemp} = {IdPacTemp};"

        End If
        If Not cError = "" Then Return cError

        Try
            Conn.Open()

            Using command = New SQLiteCommand(query, Conn)
                command.ExecuteReader()
            End Using

        Catch ex As Exception
            cError = $"Error al momento de borrar la información de del turno {ex}"
        Finally
            Conn.Close()
        End Try

        Return cError

    End Function
End Class