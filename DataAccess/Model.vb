Public Class ListaHorario
    Private _listHorario As List(Of Horario)

    Public Property ListHorario As List(Of Horario)
        Get
            Return _listHorario
        End Get
        Set(value As List(Of Horario))
            _listHorario = value
        End Set
    End Property

End Class

Public Class Horario

    Public Property Id As Integer
    Public Property Hora As String

End Class

Public Class HoraFecha

    Public Property IdHora As Integer
    Public Property Fecha As String

End Class

Public Class Turno

    Public Property IdTurno As Integer
    Public Property DNI As String
    Public Property Nombre As String

End Class

Public Class Persona

    Public Property DNI As String
    Public Property ApellidoNombre As String
    Public Property FechaNacimiento As String
    Public Property Domicilio As String
    Public Property Barrio As String
    Public Property Ciudad As String

End Class