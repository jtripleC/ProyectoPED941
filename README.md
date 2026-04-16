# Sistema de Inventario - Papelería (PED941)

Proyecto desarrollado para la materia de Programación con Estructuras de Datos (PED941).

# Objetivo
Desarrollar un sistema de inventario para una tienda pequeña o papelería que permita gestionar productos, controlar existencias y optimizar procesos mediante el uso de estructuras de datos.

---

## Alcance del prototipo (30%)

El sistema incluye:

- Dashboard principal
- Registro de productos
- Consulta de productos
- Entradas de inventario
- Salidas de inventario
- Búsqueda de productos por código
- Historial de movimientos
- Deshacer última operación
- Alertas de productos con bajo stock

---

## Tecnologías utilizadas

- Lenguaje: C#
- Framework: .NET 8
- Interfaz: Windows Forms + Guna UI 2
- Base de datos: SQL Server
- Control de versiones: GitHub

---

## Estructuras de datos utilizadas

El sistema implementa estructuras de datos fundamentales:

- Tabla hash → Búsqueda rápida de productos por código
- Lista enlazada → Historial de movimientos
- Pila → Deshacer última operación
- Cola de prioridad → Gestión de productos críticos
- Heap → Implementación eficiente de la cola de prioridad

---

## Estructura del proyecto

Forms/
Models/
Data/
Data/Repositories/
Structures/
Services/
Utils/
database/


---

## Integrantes

- Melissa Jomeissy Sanchez Castro 
- Carlos Ernesto Contreras Bonilla
- Jorge Steven Moreno Hernandez 
- Oswaldo Alexander Henriquez Miranda 
- Estuardo Alejandro Henriquez Mejia 
- Juan Carlos Constanza Campos 


---

##  Flujo de trabajo

- `main` → versión estable
- `develop` → integración del proyecto
- `feature/...` → desarrollo por módulos

---

##  Estado actual

 En desarrollo (Fase 1 - Prototipo 30%)

---

## 📬 Notas

- Cada integrante debe trabajar en su rama (`feature/...`)
- Los cambios deben integrarse a `develop`
- No trabajar directamente en `main`
