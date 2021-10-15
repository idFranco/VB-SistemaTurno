# Sistema Turno

Permite la gestión de turno de personas. Tanto de las que se encuentran registradas, como así también, de las que no se cuenta con información al respecto.

Secciones:
* **Loguin**
	* Permite el logueo del usuario. Cuya información a brindar es: Usuario: admin - Contraseña: 1234.
	
* **Paciente**
	* Realiza el **alta** y **modificación** de los datos de una persona. 
	* Permite realizar la búsqueda de los datos de un paciente por medio de su número de documento en el campo con el mismo nombre, o ingresando a la Sección Busqueda Global.
	* Limpieza de los campos que contienen información.
	
* **Turno**
	* Realiza eventos de **alta**, **modificación** y **baja** de un turno determinado.
	* Permite realizar la búsqueda de los datos de un paciente por medio de su número de documento en el campo con el mismo nombre, o ingresando a la Sección Busqueda Global.
	* Selección de una fecha y hora a ser asignado.
	* Si no se seleccionó los datos de ningún paciente, solo realice la acción de seleccionar fecha, hora y presionar el botón Asignar Turno. Seguidamente, le permitirá el ingreso del nombre del paciente para asignar dicho turno. 

* **Busqueda Global**
	* Muestra un listado completo que contiene Número de Documento y Nombre Completo de las personas que fueron registradas en el sistema. 
    * Filtrado de datos por medio de Nombre o Apellido. 
    * El listado acepta el evento click y doble click **sobre el nombre de la persona** para la carga de los datos en el Formulario Principal.

## Archivo .dll
* **System.Data.SQLite**
	* Se encuentra en la sección de SistemaTurno/DataAccess/Resource. El mismo debe ser referenciado en DataAccess para poder realizar los eventos de CRUD

## Desarrollo del sistema
* **Aplicación**
  * Visual Studio 2019
  * VB.NET Windows Forms
  * SQLite
  * .NET Framework 4.7.2
  
## Información destacada
* **Base de Datos:**
  * Como se mencionó anteriormente, se debe realizar la referencia al archivo System.Data.SQLite.dll que se encuentra en SistemaTurno/DataAccess/Resource.
  * Se crea, en tiempo de ejecución, el archivo Turno.db en (archivo raíz donde se encuentra el código)/bin/Debug/Data.
  
## Acerca de

El mismo fue desarrollado con la finalidad educativa sobre la programación en VB.NET. Se dejó varias cuestiones que mejorarían el rendimiento de la app y de lo cual me encuentro disponible a conversar sobre las mismas.