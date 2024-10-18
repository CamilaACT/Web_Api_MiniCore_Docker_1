# Web API MiniCore Docker

Este proyecto es una API desarrollada en ASP.NET Core y está configurada para ejecutarse dentro de un contenedor Docker. Proporciona un backend funcional para manejar solicitudes HTTP y exponer servicios RESTful.

## Tabla de Contenidos

1. [Requisitos previos](#requisitos-previos)
2. [Configuración del entorno](#configuración-del-entorno)
3. [Uso con Docker](#uso-con-docker)
4. [Compilación](#compilación)
5. [Pruebas](#pruebas)
6. [Contribuciones](#contribuciones)
7. [Licencia](#licencia)

## 1. Requisitos previos

Para ejecutar este proyecto necesitarás tener instalados:

- [.NET SDK 8.0 o superior](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)

## 2. Configuración del entorno

Configura el archivo `appsettings.json` con los parámetros correctos, incluyendo la cadena de conexión a la base de datos y cualquier otra configuración necesaria.

Ejemplo de `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=db-server;Database=nombreBD;User Id=usuario;Password=contraseña;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
