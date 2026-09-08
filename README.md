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
- [Tecnología Utilizada](#tecnología-utilizada)
- [Requisitos](#requisitos)
- [Instalación y Ejecución](#instalación-y-ejecución)
- [Fecha de Ejecución](#fecha-de-ejecución)
- [Problemas y Dificultades](#problemas-y-dificultades)
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

```
HPAIII-Laboratorio-2-Programación-Orientada-a-Objetos/
│
├── README.md                          # Este archivo - Documentación principal
│
├── Actividad1/                        # Primera actividad de POO
│   ├── Actividad1.slnx                # Solución de Visual Studio
│   ├── Actividad_1.csproj             # Archivo de proyecto C#
│   ├── Class1.cs                      # Clase de la actividad
│   ├── Program.cs                     # Punto de entrada de la aplicación
│   ├── bin/                           # Archivos compilados (Debug/Release)
│   └── obj/                           # Archivos de objeto intermedios
│
├── Actividad2/                        # Segunda actividad de POO
│   ├── Actividad2.slnx                # Solución de Visual Studio
│   ├── Actividad_2.csproj             # Archivo de proyecto C#
│   ├── Class1.cs                      # Clase de la actividad
│   ├── Program.cs                     # Punto de entrada de la aplicación
│   ├── bin/                           # Archivos compilados (Debug/Release)
│   └── obj/                           # Archivos de objeto intermedios
│
├── Actividad3_Variables_de_Instancia_y_Propiedades/  # Tercera actividad
│   ├── Actividad3_Variables_de_Instancia_y_Propiedades.slnx
│   ├── Actividad3_Variables_de_Instancia_y_Propiedades.csproj
│   ├── Class1.cs                      # Clases con propiedades
│   ├── Program.cs                     # Punto de entrada de la aplicación
│   ├── bin/                           # Archivos compilados (Debug/Release)
│   └── obj/                           # Archivos de objeto intermedios
│
├── .gitignore                         # Archivos a ignorar en Git
└── docs/                              # Documentación adicional (si aplica)

```

---

## Tecnología Utilizada

| Tecnología | Versión | Descripción |
|-----------|---------|-------------|
| **Lenguaje** | C# | Lenguaje principal para POO |
| **.NET SDK** | .NET 10.0 | Framework de desarrollo .NET |
| **IDE** | Visual Studio Community 2022 | Ambiente de desarrollo integrado |
| **Sistema Operativo** | Windows | SO de ejecución |
| **Control de Versiones** | Git | Sistema de versionado |
| **Plataforma** | GitHub | Repositorio remoto |
| **Compilador** | Roslyn (csc.exe) | Compilador C# |
| **Formato Proyecto** | .csproj (SDK) | Formato de proyecto moderno |

---

## Requisitos

### Requisitos de Sistema
- **Visual Studio Community 2022 o superior** (o Visual Studio Code con extensión C#)
- **.NET 10.0 SDK** instalado y configurado en variables de entorno
- **Git** para clonar y gestionar el repositorio
- **Terminal o CMD (PowerShell)** para ejecutar comandos
- Mínimo 500 MB de espacio en disco
- Windows 10 o superior (también compatible con Linux y macOS)

### Requisitos de Software
- C# compilado correctamente con .NET 10.0
- Permisos de lectura/escritura en el directorio del proyecto
- Visual Studio con carga de trabajo .NET Desktop Development (para GUI opcional)

---

## Instalación y Ejecución

### 1. Clonar el Repositorio
```bash
git clone https://github.com/LeonelMendoza2309/HPAIII-Laboratorio-2-Programaci-n-Orientada-a-Objetos.git
cd HPAIII-Laboratorio-2-Programaci-n-Orientada-a-Objetos
```

### 2. Compilar el Código (Opción A: Con .NET CLI)
```bash
# Navegar a la carpeta de la actividad
cd Actividad1

# Restaurar dependencias y compilar
dotnet restore
dotnet build

# O compilar y ejecutar en un solo comando
dotnet run
```

### 3. Ejecutar la Aplicación (Opción B: Con Visual Studio)
1. Abrir Visual Studio 2022
2. Archivo → Abrir → Carpeta → Seleccionar la carpeta del repositorio
3. En el Explorador de soluciones, seleccionar una actividad (ej: Actividad1.slnx)
4. Hacer clic derecho en la solución → "Compilar solución"
5. Hacer clic derecho en Program.cs → "Ejecutar como inicio"
6. Ver resultados en la consola integrada

### 4. Ejecutar desde la Línea de Comandos (Opción C: PowerShell)
```bash
# Navegar a la actividad
cd Actividad1

# Ejecutar directamente
dotnet run

# O compilar en Debug
dotnet build -c Debug

# Ejecutar el archivo compilado
./bin/Debug/net10.0/Actividad_1.exe
```

### 5. Limpiar Archivos Compilados
```bash
# Eliminar archivos compilados de una actividad
cd Actividad1
dotnet clean

# Para todas las actividades (desde la raíz)
dotnet clean
```

---

## Fecha de Ejecución

- **Inicio del Laboratorio:** 01/09/2026
- **Finalización del Laboratorio:** 08/09/2026
- **Entrega:** 08/09/2026
- **Duración Total:** 1 semana
- **Fecha de Última Actualización:** 08/09/2026

---

## Problemas y Dificultades

### Problemas Encontrados y Resueltos

| # | Problema | Descripción | Solución |
|---|----------|-------------|----------|
| 1 | Propiedades vs Campos | Diferencia entre variables de instancia y propiedades en C# | Se implementaron propiedades con getters y setters |
| 2 | Namespaces | Conflictos de namespaces entre actividades | Se utilizaron espacios de nombres distintos para cada actividad |
| 3 | Encapsulamiento | Control de acceso a atributos privados | Se implementaron propiedades públicas con acceso controlado |
| 4 | Versión .NET | Compatibilidad con .NET 10.0 | Se configuró el proyecto con TargetFramework net10.0 |
| 5 | Referencias Nulas | NullReferenceException durante la ejecución | Se agregaron validaciones nulas y manejo de excepciones |

### Errores Corregidos

- ✅ **Error de Compilación:** Referencias nulas → Resuelto con validaciones y inicialización adecuada
- ✅ **Error Lógico:** Propiedades sin acceso correcto → Resuelto implementando propiedades C# con get/set
- ✅ **Encapsulamiento:** Campos públicos expuestos → Convertidos a privados con propiedades públicas
- ✅ **Namespaces:** Conflictos entre clases → Organizados correctamente en espacios de nombres distintos
- ✅ **Tipos Nulables:** Warnings en compilación → Se habilitó nullable reference types correctamente

### Lecciones Aprendidas

1. **Propiedades en C#:** Las propiedades son la forma correcta de exponer campos privados en C#
2. **Validaciones:** Siempre validar entrada de datos en setters de propiedades
3. **Documentación:** Documentar el código mejora el mantenimiento y comprensión
4. **Testing:** Realizar pruebas frecuentes durante el desarrollo
5. **Principios SOLID:** Aplicar estos principios desde el inicio del proyecto

---

## Resultados

### Funcionalidades Implementadas

✅ **Actividad 1: Creación de Clases Base**
- Implementación correcta de atributos y métodos
- Constructores parametrizados
- Métodos básicos de demostración
- Namespace organizado

✅ **Actividad 2: Extensión de Conceptos**
- Aplicación de conceptos de herencia
- Métodos parametrizados
- Control de acceso
- Interacción entre clases

✅ **Actividad 3: Variables de Instancia y Propiedades**
- Implementación de propiedades con getters y setters
- Encapsulamiento completo con validaciones
- Constructores con parámetros
- Demostración de propiedades auto-implementadas y manuales

### Salida Esperada

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

### Evidencia de Funcionamiento

- ✅ Compilación sin errores con .NET 10.0
- ✅ Ejecución correcta de los programas
- ✅ Salida del programa coincide con lo esperado
- ✅ Encapsulamiento adecuado de datos
- ✅ Manejo correcto de casos especiales

---

## Conclusiones

### Conclusiones Generales

En este laboratorio se logró exitosamente:

1. **Dominio de POO en C#:** Se implementaron correctamente los cuatro pilares de la programación orientada a objetos: abstracción, encapsulamiento, herencia y polimorfismo.

2. **Aplicación Práctica:** Se resolvieron problemas del mundo real usando conceptos de POO, demostrando la utilidad del paradigma (ejemplo: Sistema de Libro de Calificaciones).

3. **Resolución de Problemas:** Se identificaron y solucionaron diversos desafíos técnicos durante el desarrollo, mejorando las habilidades de debugging.

4. **Calidad de Código:** Se implementaron mejores prácticas como encapsulamiento con propiedades, validaciones y manejo de excepciones.

5. **Herramientas Modernas:** Se utilizó Visual Studio 2022 y .NET 10.0, tecnologías actuales y profesionales.

### Recomendaciones Futuras

- Implementar pruebas unitarias con xUnit o NUnit
- Utilizar patrones de diseño (Singleton, Factory, Observer)
- Mejorar la interfaz de usuario con WinForms o WPF
- Optimizar el rendimiento del código
- Añadir validaciones más exhaustivas en propiedades
- Implementar logging y manejo de excepciones personalizadas

### Reflexión Personal

Este laboratorio fue fundamental para consolidar los conocimientos sobre Programación Orientada a Objetos en C#. La experiencia práctica permitió entender mejor la importancia del diseño previo, las propiedades como mecanismo de encapsulamiento, y cómo Visual Studio facilita el desarrollo. Las actividades progresivas ayudaron a comprender desde conceptos básicos hasta el uso avanzado de propiedades y validaciones.

---

## Recursos Adicionales

### Documentación Oficial
- [Documentación C# - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [.NET 10.0 Documentation](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-10)
- [Visual Studio 2022 Guide](https://learn.microsoft.com/en-us/visualstudio/windows/?view=vs-2022)

### Conceptos de POO en C#
- Clases y Objetos
- Propiedades y Campos
- Herencia y Composición
- Polimorfismo e Interfaces
- Encapsulamiento y Modificadores de Acceso
- Excepciones y Manejo de Errores

### Herramientas Recomendadas
- Visual Studio Community 2022
- Visual Studio Code con C# DevKit
- Postman (para futuras APIs)
- Git/GitHub Desktop

### Enlaces Útiles
- [Fundamentos de C#](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/)
- [Propiedades en C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)
- [Encapsulamiento](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance)

---

## Notas Importantes

⚠️ **Nota:** Este laboratorio fue desarrollado como parte del curso de Programación Orientada a Objetos en la Universidad Tecnológica de Panamá, bajo la supervisión del profesor de la asignatura.

📌 **Aclaración:** Las actividades resueltas se encuentran en sus respectivas carpetas (Actividad1, Actividad2, Actividad3_Variables_de_Instancia_y_Propiedades). Cada una es una solución independiente.

📝 **Para ejecutar:** Utilizar Visual Studio o el comando `dotnet run` desde la carpeta de cada actividad.

🔧 **Requisito de .NET:** Asegurar tener instalado .NET 10.0 SDK antes de intentar compilar o ejecutar los proyectos.

---

**Última actualización:** 08/09/2026  
**Versión:** 2.0 (Actualizado a C# y .NET 10.0)  
**Estado:** Completado ✅  
**Lenguaje:** C# con .NET  
**IDE:** Visual Studio 2022
