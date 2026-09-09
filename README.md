<div align="center">

# UNIVERSIDAD TECNOLOGICA DE PANAMÁ 
Facultad de Ingeniería en Sistemas Y Computación 
Lic. en Ing. de Sistemas Computacionales

</div>

---

# HPAIII-Laboratorio-2-Programación-Orientada-a-Objetos

**Autor:** Leonel Mendoza 1IL133

---

## Tabla de Contenidos
- [Objetivo del Laboratorio](#objetivo-del-laboratorio)
- [Estructura del Repositorio](#estructura-del-repositorio)
- [Tecnología principal](#tecnología-principal)
- [Requisitos](#requisitos)
- [Instalación y ejecución](#instalación-y-ejecución)
- [Fecha de Ejecución](#fecha-de-ejecución)
- [Problemas y soluciones](#problemas-y-soluciones)
- [Resultados](#resultados)
- [Conclusiones](#conclusiones)

---

## Objetivo del Laboratorio

El objetivo principal de este laboratorio es:
- Comprender y aplicar los conceptos fundamentales de Programación Orientada a Objetos (POO)
- Implementar correctamente clases, objetos, constructores y propiedades
- Dominar conceptos avanzados como herencia, polimorfismo, encapsulamiento e interfaces
- Desarrollar soluciones prácticas mediante la aplicación de principios SOLID
- Resolver problemas del mundo real utilizando paradigmas orientados a objetos
- Mejorar habilidades de diseño y arquitectura de software

---

## Estructura del Repositorio

A continuación una versión simplificada de la estructura del proyecto con una breve descripción de cada carpeta relevante:

```
HPAIII-Laboratorio-2-Programación-Orientada-a-Objetos/
├── Actividad1                         # Proyecto C#: Ejemplo básico (Libro de calificaciones)
├── Actividad2                         # Proyecto C#: Entrada por consola y parámetros
├── Actividad3                         # Proyecto C#: Uso de propiedades y constructores
├── README.md                          # Documentación del repositorio
└── .gitignore                         # Reglas de archivos ignorados

```
en esta sección se redactan los proyectos/actividades realizadas

---

## Tecnología principal

- Lenguaje: C# (uso en los proyectos de ejemplo)
- Plataforma / Runtime: .NET 10.0 (TargetFramework: `net10.0`)
- Entorno de desarrollo sugerido: Visual Studio Community 2022 (puede usarse también VS Code con la extensión C#)
- Compilador: Roslyn (csc)
- Control de versiones y alojamiento: Git / GitHub

---

## Requisitos

Requisitos mínimos para compilar y ejecutar los proyectos:

- .NET 10.0 SDK instalado (`dotnet --version` → 10.x)
- Visual Studio 2022 (recomendado) o Visual Studio Code + extensión C#
- Git para clonar el repositorio
- Sistema operativo: Windows 10 o superior (los proyectos .NET pueden ejecutarse en Linux/macOS con dotnet CLI)

---

## Instalación y ejecución

Pasos rápidos desde una máquina con .NET instalado.

Clonar el repositorio:

```bash
git clone https://github.com/LeonelMendoza2309/HPAIII-Laboratorio-2-Programaci-n-Orientada-a-Objetos.git
cd HPAIII-Laboratorio-2-Programaci-n-Orientada-a-Objetos
```

Ejecutar con Visual Studio (GUI):
1. Abrir Visual Studio 2022.
2. Abrir la carpeta del repositorio o cada `.slnx`/`.csproj` desde Archivo → Abrir.
3. En el Explorador de soluciones, seleccionar el proyecto que desea ejecutar y marcarlo como "Startup Project".
4. Ejecutar con F5 (depuración) o Ctrl+F5 (sin depuración).

Ejecutar con dotnet CLI (línea de comandos):

```bash
# Actividad1
cd Actividad1
dotnet run

# Actividad2
cd ../Actividad2
dotnet run

# Actividad3
cd ../Actividad3_Variables_de_Instancia_y_Propiedades
dotnet run
```

Notas adicionales:
- Algunos programas leen entrada desde consola (Console.ReadLine). Introduzca los datos cuando se le solicite.
- Si desea ejecutar el binario compilado directamente, busque el ejecutable en `./bin/Debug/net10.0/` tras compilar.
- Para limpiar artefactos de compilación: `dotnet clean` dentro del proyecto o desde la raíz para todos.

---

## Fecha de Ejecución

- Inicio del Laboratorio: 01/09/2026
- Finalización del Laboratorio: 08/09/2026
- Entrega: 08/09/2026
- Fecha de última actualización: 08/09/2026

---

## Problemas y soluciones

Lista de problemas relevantes detectados durante el desarrollo y cómo se resolvieron. Si quieres añadir evidencia visual, coloca la imagen en `docs/result.png` y referencia la ruta más abajo.

| # | Problema | Descripción | Acción tomada |
|---:|---------|-------------|---------------|
| 1 | NullReferenceException | Objetos o variables no inicializadas producían fallos en tiempo de ejecución | Inicializar en constructores y añadir validaciones antes de usar referencias nulas |
| 2 | Campos públicos vs propiedades | Uso de campos públicos exponía estado interno | Cambiar campos a privados y exponer mediante propiedades (`get`/`set`) con validaciones cuando aplica |
| 3 | Namespaces duplicados | Clases con el mismo nombre en diferentes proyectos | Definir namespaces por actividad para evitar choques al usar varios proyectos juntos |
| 4 | TargetFramework inconsistente | Proyectos apuntaban a versiones distintas de .NET en algunos equipos | Unificar `TargetFramework` a `net10.0` en los `.csproj` |
| 5 | Mensajes de entrada poco claros | Usuarios no sabían cuándo ingresar datos en consola | Añadir mensajes informativos antes de `Console.ReadLine()` y documentar la entrada requerida |

Evidencia visual (agrega tu captura en `docs/result.png`):

```markdown
### Resultado del sistema
![Ejecución del programa](docs/result.png)
```

---

## Resultados

Funcionalidades implementadas destacadas:
- Actividad1: Proyecto introductorio con clase `LibroCalificacion` y método para mostrar un mensaje en consola.
- Actividad2: Lectura de entrada por consola y uso de parámetros para personalizar la salida.
- Actividad3: Implementación de propiedades, encapsulamiento y constructores parametrizados.

Salida esperada (ejemplo):

```
========== RESULTADOS DEL LABORATORIO ==========
Bienvenido al libro de calificaciones para 
 [Nombre del Curso]

Compilación sin errores
Ejecución correcta del programa
Validaciones implementadas
Propiedades funcionando correctamente
============================================
```

---

## Conclusiones

- Se afianzaron los conceptos fundamentales de POO aplicados en C#.
- La separación por proyectos facilita experimentar con cada concepto de forma aislada.
- Se recomienda añadir pruebas unitarias y mayor validación de entrada para robustecer los ejercicios.

---

**Última actualización:** 08/09/2026  
**Versión:** 2.0  
**Estado:** Completado
