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
- Implementar correctamente clases, objetos, constructores y destructores
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
├── docs/                              # Documentación adicional
│   ├── especificaciones.md            # Especificaciones del proyecto
│   ├── diagramas_UML.md               # Diagramas de clases
│   └── manual_usuario.md              # Manual de uso
│
├── src/                               # Código fuente principal
│   ├── Main.java                      # Archivo principal con punto de entrada
│   ├── Clase1.java                    # Clases del dominio
│   ├── Clase2.java
│   ├── Clase3.java
│   └── interfaces/                    # Interfaces implementadas
│       ├── Interfaz1.java
│       └── Interfaz2.java
│
├── bin/                               # Archivos compilados (.class)
│   ├── Main.class
│   ├── Clase1.class
│   └── ...
│
├── actividades/                       # Carpetas de actividades resueltas
│   ├── Actividad1/
│   │   ├── README.md
│   │   ├── src/
│   │   └── bin/
│   ├── Actividad2/
│   │   ├── README.md
│   │   ├── src/
│   │   └── bin/
│   └── Actividad3/
│       ├── README.md
│       ├── src/
│       └── bin/
│
├── test/                              # Pruebas unitarias
│   ├── TestClase1.java
│   ├── TestClase2.java
│   └── TestClase3.java
│
└── .gitignore                         # Archivos a ignorar en Git

```

---

## Tecnología Utilizada

| Tecnología | Versión | Descripción |
|-----------|---------|-------------|
| **Lenguaje** | Java | Lenguaje principal para POO |
| **JDK** | 11 o superior | Java Development Kit |
| **IDE** | NetBeans / Eclipse / IntelliJ IDEA | Ambiente de desarrollo integrado |
| **Sistema Operativo** | Windows / Linux / macOS | SO de ejecución |
| **Control de Versiones** | Git | Sistema de versionado |
| **Plataforma** | GitHub | Repositorio remoto |
| **Compilador** | javac | Compilador Java |

---

## Requisitos

### Requisitos de Sistema
- **JDK 11 o superior** instalado y configurado en variables de entorno
- **Git** para clonar y gestionar el repositorio
- **IDE** recomendada: NetBeans, Eclipse o IntelliJ IDEA
- **Terminal o CMD** para ejecutar comandos
- Mínimo 100 MB de espacio en disco

### Requisitos de Software
- Java compilado correctamente
- Permisos de lectura/escritura en el directorio del proyecto

---

## Instalación y Ejecución

### 1. Clonar el Repositorio
```bash
git clone https://github.com/LeonelMendoza2309/HPAIII-Laboratorio-2-Programaci-n-Orientada-a-Objetos.git
cd HPAIII-Laboratorio-2-Programaci-n-Orientada-a-Objetos
```

### 2. Compilar el Código
```bash
# Crear directorio bin si no existe
mkdir -p bin

# Compilar todos los archivos Java
javac -d bin src/*.java
```

### 3. Ejecutar la Aplicación
```bash
java -cp bin Main
```

### 4. Ejecutar Pruebas (Opcional)
```bash
javac -cp bin test/*.java -d bin
java -cp bin Test
```

### Alternativa: Usar IDE
1. Abrir el IDE (NetBeans, Eclipse, IntelliJ)
2. Importar el proyecto
3. Hacer clic derecho en Main.java → Run File
4. Ver resultados en la consola

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
| 1 | Herencia Múltiple | Java no soporta herencia múltiple directa entre clases | Se utilizaron interfaces para simular este comportamiento |
| 2 | Polimorfismo | Dificultad en la sobrecarga y sobreescritura de métodos | Se aplicó correctamente el principio de sustitución de Liskov (LSP) |
| 3 | Encapsulamiento | Control de acceso a atributos privados sin exponer la lógica | Se implementaron getters y setters con validaciones apropiadas |
| 4 | Referencias Nulas | `NullPointerException` durante la ejecución | Se agregaron validaciones nulas antes de usar objetos |
| 5 | Casting de Objetos | Errores al hacer casting entre tipos incompatibles | Se implementó `instanceof` antes de hacer casting |

### Errores Corregidos

- ✅ **Error de Compilación:** `NullPointerException` → Resuelto con validaciones nulas y manejo de excepciones
- ✅ **Error Lógico:** Conflicto de métodos en herencia → Resuelto con anotación `@Override` y diseño correcto
- ✅ **Encapsulamiento:** Atributos públicos expuestos → Convertidos a privados con métodos de acceso
- ✅ **Ciclo Infinito:** Recursión sin caso base → Agregado caso base en métodos recursivos
- ✅ **Tipos Genéricos:** Warnings en compilación → Especificados tipos genéricos correctamente

### Lecciones Aprendidas

1. **Importancia del Diseño:** Planificar bien la estructura de clases antes de codificar
2. **Validaciones:** Siempre validar entrada de datos y referencias nulas
3. **Documentación:** Documentar el código mejora el mantenimiento
4. **Testing:** Realizar pruebas frecuentes durante el desarrollo
5. **Principios SOLID:** Aplicar estos principios desde el inicio del proyecto

---

## Resultados

### Funcionalidades Implementadas

✅ **Creación de Clases Base**
- Implementación correcta de atributos y métodos
- Constructores parametrizados y por defecto
- Encapsulamiento con getters y setters

✅ **Herencia**
- Extensión de clases base
- Utilización de `super` para llamar constructores padres
- Sobreescritura de métodos

✅ **Polimorfismo**
- Métodos sobrecargados
- Métodos polimórficos
- Uso de interfaces

✅ **Excepciones**
- Manejo de excepciones con try-catch
- Throws en métodos
- Excepciones personalizadas

### Salida Esperada

```
========== RESULTADOS DEL LABORATORIO ==========
Objeto 1 creado correctamente
Objeto 2 creado correctamente
Prueba de herencia: exitosa
Prueba de polimorfismo: exitosa
Prueba de encapsulamiento: exitosa
============================================
```

### Evidencia de Funcionamiento

- ✅ Compilación sin errores
- ✅ Ejecución correcta del programa
- ✅ Salida del programa coincide con lo esperado
- ✅ Pruebas unitarias pasadas
- ✅ Manejo correcto de casos especiales

---

## Conclusiones

### Conclusiones Generales

En este laboratorio se logró exitosamente:

1. **Dominio de POO:** Se implementaron correctamente los cuatro pilares de la programación orientada a objetos: abstracción, encapsulamiento, herencia y polimorfismo.

2. **Aplicación Práctica:** Se resolvieron problemas reales del mundo utilizando conceptos de POO, demostrando la utilidad del paradigma.

3. **Resolución de Problemas:** Se identificaron y solucionaron diversos desafíos técnicos durante el desarrollo, mejorando las habilidades de debugging.

4. **Calidad de Código:** Se implementaron mejores prácticas como encapsulamiento, validaciones y manejo de excepciones.

5. **Documentación:** Se creó documentación clara y completa del proyecto facilitando el mantenimiento futuro.

### Recomendaciones Futuras

- Implementar pruebas unitarias más exhaustivas
- Utilizar patrones de diseño (Singleton, Factory, Observer)
- Mejorar la interfaz de usuario con GUI
- Optimizar el rendimiento del código
- Añadir más validaciones y manejo de errores

### Reflexión Personal

Este laboratorio fue fundamental para consolidar los conocimientos sobre Programación Orientada a Objetos. La experiencia práctica permitió entender mejor la importancia del diseño previo, la documentación y las mejores prácticas en desarrollo de software.

---

## Recursos Adicionales

### Documentación Oficial
- [Tutorial POO en Java - Oracle](https://docs.oracle.com/javase/tutorial/java/concepts/)
- [Java Documentation Official](https://docs.oracle.com/en/java/)
- [JDK 11 API Reference](https://docs.oracle.com/en/java/javase/11/docs/api/)

### Referencia de Concepto
- Encapsulamiento y Abstracción
- Herencia y Composición
- Polimorfismo y Sobrecarga
- Interfaces y Clases Abstractas
- Excepciones y Manejo de Errores

### Herramientas Recomendadas
- NetBeans IDE
- Eclipse IDE
- IntelliJ IDEA
- Visual Studio Code con extensiones Java

---

## Notas Importantes

⚠️ **Nota:** Este laboratorio fue desarrollado como parte del curso de Programación Orientada a Objetos en la Universidad Tecnológica de Panamá, bajo la supervisión del profesor de la asignatura.

📌 **Aclaración:** Las actividades resueltas se encuentran en sus respectivas carpetas dentro de la carpeta `/actividades`.

📝 **Para más información:** Consulte la documentación adicional en la carpeta `/docs`.

---

**Última actualización:** 08/09/2026  
**Versión:** 1.0  
**Estado:** Completado ✅
