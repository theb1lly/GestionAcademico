<img width="960" height="540" alt="{79245136-6E1A-407F-A3EB-1961881DC430}" src="https://github.com/user-attachments/assets/8052e1ef-b223-4a0a-94a7-de01163cd35c" /># Sistema de Gestión Académica (SGA)

Sistema de escritorio para la gestión académica de una institución educativa, desarrollado en **C# (Windows Forms)** con conexión a **SQL Server** mediante **ADO.NET**.

## 📋 Descripción

GestionAcademico permite administrar usuarios, roles, estudiantes, docentes, asignaturas, inscripciones y calificaciones, con control de acceso diferenciado según el rol del usuario (Administrador, Docente, Estudiante).

## ⚙️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Interfaz:** Windows Forms
- **Acceso a datos:** ADO.NET (SqlConnection / SqlCommand)
- **Base de datos:** SQL Server
- **Seguridad:** Contraseñas cifradas con hash SHA-256

## 🗂️ Estructura del proyecto<img width="960" height="540" alt="11" src="https://github.com/user-attachments/assets/fdd32a42-5a4a-4d80-ba68-bc6bd99d19b4" />
<img width="960" height="540" alt="10" src="https://github.com/user-attachments/assets/b5527825-c2f9-4ec0-9b2a-1e465e133f14" />
<img width="960" height="540" alt="9" src="https://github.com/user-attachments/assets/691f12a5-1e43-4bd5-b5bb-7cc42e6fc3e3" />
<img width="960" height="540" alt="8" src="https://github.com/user-attachments/assets/c0966be9-4e13-4d3d-8dd4-ba2dd643a214" />
<img width="960" height="540" alt="7" src="https://github.com/user-attachments/assets/a42920f7-beeb-4596-81b1-1c957f5374af" />
<img width="960" height="540" alt="6" src="https://github.com/user-attachments/assets/6655b586-6610-40e8-9ef6-9c3f77b0fe12" />
<img width="960" height="540" alt="5" src="https://github.com/user-attachments/assets/224b2987-7d08-4a64-a561-999732e9dd2b" />
<img width="960" height="540" alt="4" src="https://github.com/user-attachments/assets/ddff1f37-f79f-4b1e-a067-135c89c10cc0" />
<img width="960" height="540" alt="3" src="https://github.com/user-attachments/assets/1cd82f25-995c-40a9-99cb-344c79716a24" />
<img width="960" height="540" alt="2" src="https://github.com/user-attachments/assets/ecfccc80-3e2f-40b3-aaaf-6f48b702fefd" />
<img width="960" height="540" alt="1" src="https://github.com/user-attachments/assets/5a896789-a147-4f12-8c2c-9b6268a8032a" />


GestionAcademico/
├── Datos/ # Clases de acceso a datos (ADO.NET)
├── Modelos/ # Clases que representan las tablas (entidades)
├── Utilidades/ # Helpers (generación de hash, etc.)
├── FormLogin.cs # Pantalla de inicio de sesión
├── Home.cs # Pantalla principal con menú según rol
└── Form*.cs # Formularios de cada módulo (usuarios, asignaturas, etc.)


## 🔑 Módulos principales

1. **Gestión de usuarios** — creación de cuentas y asignación de roles.
2. **Gestión de asignaturas** — alta y consulta de materias.
3. **Inscripciones** — matriculación de estudiantes en asignaturas por período.
4. **Calificaciones** — registro de notas asociadas a inscripciones.
5. **Reportes** — resumen estadístico del sistema.
6. **Consultas** — visualización de usuarios, estudiantes, docentes, asignaturas, inscripciones y calificaciones.

## 👥 Roles del sistema

| Rol | Permisos |
|---|---|
| **Administrador** | Acceso completo a todos los módulos |
| **Docente** | Registrar calificaciones y consultar información relacionada |
| **Estudiante** | Inscribirse en asignaturas y consultar su información académica |

## 🚀 Cómo ejecutar el proyecto

1. Clona este repositorio:
```bash
   git clone <url-del-repositorio>
```
2. Abre el archivo `.sln` con **Visual Studio**.
3. Ajusta la cadena de conexión en `Datos/Conexion.cs` según tu servidor SQL Server.
4. Ejecuta el script SQL incluido para crear las tablas y el usuario administrador inicial.
5. Presiona **F5** para ejecutar el proyecto.

## 🔐 Usuario de prueba

Usuario: admin
Contraseña: Admin123*


## 📄 Licencia

Proyecto académico desarrollado con fines educativos.
