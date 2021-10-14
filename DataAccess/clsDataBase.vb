Public Class ClsDataBase

    Public ReadOnly DDBB As New CreateDataBase

End Class

Public Class CreateDataBase

    Protected Friend ReadOnly Property TablePacientes As String = $"
                CREATE TABLE IF NOT EXISTS {TableName.Pacientes}(
	                {TuplaId.idDNI} TEXT(10) NOT NULL,
	                {Tupla.ApeNom} TEXT(30) NOT NULL,
                    {Tupla.FNac} TEXT(10) NOT NULL,
                    {Tupla.Domicilio} TEXT(40) NOT NULL,
                    {Tupla.Barrio} TEXT(30) NOT NULL,
                    {Tupla.Ciudad} TEXT(30) NOT NULL,
	                PRIMARY KEY({TuplaId.idDNI})
                );"

    Protected Friend ReadOnly Property TablePacientesTemporales As String = $"
                CREATE TABLE IF NOT EXISTS {TableName.PacientesTemporales}(
	                {TuplaId.idTemp} INTEGER,
                    {Tupla.ApeNom} TEXT(30) NOT NULL,
                    PRIMARY KEY({TuplaId.idTemp})
                );"

    Protected Friend ReadOnly Property TableHorarios As String = $"
                CREATE TABLE IF NOT EXISTS {TableName.Horarios}(
	                {TuplaId.idHorario} INTEGER,
                    {Tupla.Hora} TEXT(5) NOT NULL,
                    PRIMARY KEY({TuplaId.idHorario})
                );"

    Protected Friend ReadOnly Property TableCitasFechas As String = $"
                CREATE TABLE IF NOT EXISTS {TableName.Fechas}(
	                {TuplaId.idFecha} INTEGER,
                    {Tupla.Fecha} TEXT(10) NOT NULL,
                    {TuplaFk.fk_idDNI} TEXT(10),
                    {TuplaFk.fk_idTemp} INTEGER,
                    PRIMARY KEY({TuplaId.idFecha}),
                    FOREIGN KEY({TuplaFk.fk_idDNI}) REFERENCES Pacientes({TuplaId.idDNI}),
                    FOREIGN KEY({TuplaFk.fk_idTemp}) REFERENCES PacientesTemporales({TuplaId.idTemp})
                );"

    Protected Friend ReadOnly Property TableFechaHorario As String = $"
                CREATE TABLE IF NOT EXISTS {TableName.FechaHorario}(
	                {TuplaId.idFecha} INTEGER NOT NULL,
                    {TuplaId.idHorario} INTEGER NOT NULL,
                    FOREIGN KEY({TuplaId.idFecha}) REFERENCES Fechas({TuplaId.idFecha}),
                    FOREIGN KEY({TuplaId.idHorario}) REFERENCES Horarios({TuplaId.idHorario})
                );"

    Protected Friend ReadOnly Property TableCuenta As String = $"
                CREATE TABLE IF NOT EXISTS {TableName.Cuenta}(
	                {TuplaId.idCuenta} INTEGER,
                    {Tupla.Usuario} TEXT(30) NOT NULL,
                    {Tupla.Contraseña} TEXT(30) NOT NULL,
                    PRIMARY KEY({TuplaId.idCuenta})
                );"

    Protected Friend ReadOnly Property InsertHorario As String = $"
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('07:00');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('07:30');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('08:00');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('08:30');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('09:00');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('09:30');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('10:00');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('10:30');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('11:00');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('11:30');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('12:00');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('12:30');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('13:00');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('13:30');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('14:00');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('14:30');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('15:00');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('15:30');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('16:00');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('16:30');
                INSERT {Condition.INTO} {TableName.Horarios}({Tupla.Hora}) {Condition.VALUES} ('17:00');"

    Protected Friend ReadOnly Property InsertCuenta As String = $"
                INSERT {Condition.INTO} {TableName.Cuenta}({Tupla.Usuario}, {Tupla.Contraseña}) {Condition.VALUES} ('admin', '1234');"

End Class