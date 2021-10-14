# Sistema Turno

Permite la gestión de turno de personas que fueron registradas, como los que no se cuenta con información al respecto.

Secciones:
* **Loguin**
	* Permite el logueo del usuario. cuya información a brindar es: Usuario:admin - Contraseña:1234.
	
* **Paciente**
	* Realiza el **alta** y **modificación** de los datos de una persona. Se puede realizar la búsqueda por medio de su número de documento en el campo con el mismo nombre o ingresando a la Sección Busqueda Global.
	* Limpieza de los campos que contienen información.
	
* **Turno**
	* Se puede realizar la búsqueda de los datos por medio de su número de documento en el campo con el mismo nombre o ingresando a la Sección Busqueda Global.
	* Selección de una fecha y hora a ser asignado.
	* Realiza eventos de **alta**, **modificación** y **baja** de un turno determinado.

* **Busqueda Global**
	* Muestra un listado con número de documento y nombre completo de las personas que fueron cargado en el sistema. Puede realizar el filtrado de datos por medio del Nombre o Apellido. El listado acepta el evento click y doble click **sobre el nombre de la persona** para la carga de los datos en el Formulario Principal.

## Archivo .dll
* **System.Data.SQLite**
	* Se encuentra en la sección de SistemaTurno/DataAccess/Resource. El mismo debe ser referenciado en DataAccess para poder realizar los eventos de CRUD

## Desarrollo del sistema
* **Aplicación**
  * Visual Studio 2019
  * VB.NET
  * SQLite
  * .NET Framework 4.7.2
  
## Información destacada
* **Base de Datos:**
  * Como se mencionó anteriormente, se debe realizar la referencia al archivo System.Data.SQLite.dll que se encuentra en SistemaTurno/DataAccess/Resource.
  * Se crea, en tiempo de ejecución, el archivo Turno.db en (archivo raíz donde se encuentra el código)/bin/Debug/Data.
  
## Acerca de

El mismo fue desarrollado con la finalidad de brindar información sobre la programación en VB.NET. Se dejó varias cuestiones que mejorarían el rendimiento de la app y de lo cual me encuentro disponible a conversar sobre las mismas.

## Contacto Autor
https://www.linkedin.com/in/maldonado-franco-rodolfo/