# ApiMinimalista
Una API minimalista en .NET Core es un enfoque simplificado y ligero para construir servicios web y endpoints HTTP en aplicaciones .NET Core, introducido a partir de .NET 6. Está diseñada para reducir la complejidad de los proyectos al eliminar la necesidad de configuraciones extensas y boilerplate (como controladores y configuraciones adicionales).

## ¿Para qué se utiliza una API minimalista?
Proyectos pequeños o prototipos:
Ideal para casos en los que necesitas crear rápidamente un servicio web, como un prototipo, una prueba de concepto o una aplicación con funcionalidades básicas.

## Microservicios:
Se adapta perfectamente a microservicios, donde cada servicio tiene un conjunto pequeño de responsabilidades y no requiere una arquitectura compleja.

## Reducir la complejidad:
Permite implementar endpoints con menos código, facilitando su desarrollo y mantenimiento, sin necesidad de controladores, acciones ni configuraciones de rutas explícitas.

## Aplicaciones de bajo consumo de recursos:
Es ideal para soluciones que necesitan un rendimiento óptimo y bajo consumo de memoria.

## Integración con frontend o aplicaciones móviles:
Perfecto para servir datos a aplicaciones frontend (Angular, React, Blazor, etc.) o móviles que consumen APIs.

# Características principales:
## Simplicidad
Utiliza una sola clase Program.cs para definir endpoints y configuraciones.
## Menor curva de aprendizaje
Es más fácil de aprender para desarrolladores nuevos en .NET Core.
## Integración completa
Aprovecha características como Dependency Injection, validación de modelos y middleware de ASP.NET Core.
## Menos dependencias
Menos necesidad de configuraciones como controladores y archivos extra.

## Ejemplo de API minimalista
____________________________________________________________________________
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/hello", () => "¡Hola, mundo!");

app.MapPost("/sumar", (int a, int b) => Results.Ok(a + b));

app.Run();

____________________________________________________________________________
En este ejemplo:

MapGet define un endpoint GET.

MapPost define un endpoint POST que recibe parámetros y devuelve un resultado.

En resumen, una API minimalista en .NET Core se utiliza para crear servicios web de manera rápida, eficiente y con menos complejidad, ideal para escenarios donde la simplicidad es clave.


