# Blazor Server Authentication Demo

## Descripción
Aplicación web desarrollada en Blazor Server que implementa un sistema de autenticación básico utilizando sesiones del servidor. Este proyecto sirve como ejemplo práctico de cómo implementar autenticación en aplicaciones Blazor Server sin depender de Identity o JWT.

## Características Principales
- Sistema de Login/Logout
- Manejo de sesiones del servidor
- Protección de rutas
- Componente AuthorizeView personalizado
- Redirección automática a login
- Interfaz de usuario responsive con Bootstrap

## Tecnologías Utilizadas
- .NET 9
- Blazor Server
- Bootstrap 5
- Servicio de Sesiones ASP.NET Core

## Arquitectura
El proyecto implementa una arquitectura limpia con:
- Separación de servicios (AuthenticationService, SessionService)
- Componentes reutilizables
- Gestión de estado mediante sesiones del servidor
- Manejo de dependencias mediante inyección de dependencias

## Credenciales de Prueba
- Email: admin@ejemplo.com
- Contraseña: 123456

## Prerrequisitos
- Visual Studio 2022 o superior
- .NET 9 SDK
- Navegador web moderno

## Instalación
1. Clonar el repositorio
2. Abrir la solución en Visual Studio
3. Restaurar paquetes NuGet
4. Compilar y ejecutar el proyecto

## Estructura del Proyecto
- `/Components`: Componentes Blazor
- `/Services`: Servicios de autenticación y sesión
- `/Shared`: Componentes compartidos
- `/Pages`: Páginas de la aplicación