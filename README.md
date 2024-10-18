
# API Web en .NET 8

## Descripción

Esta API está desarrollada en .NET 8 y expone el servicio de busqueda de tareas con retraso. Cada controlador maneja una serie de operaciones CRUD, asegurando la interacción con la base de datos SQL server levantado en azure a través de procedimientos almacenados.

### Controladores expuestos:

#### TareaController

1. **POST `/api/Tarea/tareasFecha`**

   Este método permite obtener una lista de tareas filtradas por un rango de fechas. Recibe un objeto de tipo `Tarea_fechas` en el cuerpo de la solicitud y devuelve una respuesta estructurada con el resultado.

   - **Parámetros**:
     - `fechas`: Un objeto que contiene las fechas inicial y final para el filtro de tareas.


### Estructura del Proyecto

El proyecto está dividido en varias capas lógicas:

- **Controllers**: Controladores para manejar las peticiones HTTP.
- **Custom**: Contiene utilidades específicas como la encriptación y validación de tokens JWT.
- **Data**: Encargada de la conexión a la base de datos y procedimientos relacionados.
- **Model**: Define los modelos de datos para los usuarios, roles, menús, y peticiones/respuestas de la API.
- **Util**: Clases de apoyo para la conexión y manejo de utilidades en el sistema.


## Tabla de Contenidos

1. [Requisitos previos](#requisitos-previos)
2. [Instalación](#instalación)
3. [Deployment](#deploy)

## Requisitos previos

- .NET SDK 8.0 o superior.
- SQL Server u otra base de datos compatible.
- Docker
## Deploy

El proyecto se encuentra deployado en:
https://github.com/CamilaACT/Web_Api_MiniCore_Docker_1

## Instalación

Clona el repositorio en tu máquina local:

```bash
git clone https://github.com/CamilaACT/ApiWeb.git


