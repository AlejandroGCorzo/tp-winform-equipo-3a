# TP WinForms - Gestión de Artículos

Aplicación de escritorio desarrollada en **C# con Windows Forms** y **SQL Server** para la administración de artículos de un catálogo comercial.

## Integrantes

- Alejandro Gabriel Corzo
- Juan Diego Derlis Álvarez Ruiz

## Tecnologías utilizadas

- C#
- .NET / WinForms
- SQL Server
- ADO.NET
- Visual Studio Community
- Git / GitHub

## Funcionalidades implementadas

### Gestión de artículos

- Listado de artículos
- Búsqueda por nombre, código y marca
- Alta de artículos
- Modificación de artículos
- Eliminación de artículos
- Vista detalle

### Datos del artículo

- Código
- Nombre
- Descripción
- Marca
- Categoría
- Precio
- Una o múltiples imágenes

### Gestión adicional

- Administración de Marcas
- Administración de Categorías

### Extras implementados

- Vista previa de imagen en listado
- Navegación entre múltiples imágenes en detalle
- Confirmación al eliminar
- Actualización automática de grilla luego de cambios

## Base de datos

El sistema utiliza SQL Server con tablas:

- Articulos
- Marcas
- Categorias
- ImagenesArticulo

## Validaciones

- Campos obligatorios
- Precio válido
- Control de errores de imágenes
- Eliminación segura de catálogos en uso
- Manejo de errores generales

## Cómo ejecutar

1. Clonar repositorio:

```bash
git clone https://github.com/AlejandroGCorzo/tp-winform-equipo-3a.git
```


2. Abrir la solución en Visual Studio.

3. Restaurar paquetes NuGet.

4. Instalar paquete necesario:

```text
Microsoft.Data.SqlClient
```

Ruta:

```text
Tools > NuGet Package Manager > Manage NuGet Packages for Solution
```

5. Configurar string de conexión en:

```text
Negocio/AccesoDatos.cs
```

Ejemplo:

```text
Server=localhost,50016;Database=TPWinForm_Equipo_3A;Integrated Security=True;TrustServerCertificate=True;
```

6. Crear la base de datos y tablas con el script SQL correspondiente.

7. Ejecutar el proyecto presionando **F5**.

## Estructura del proyecto

```text
TPWinForm_Equipo_3A
├── Dominio
│   ├── Articulo.cs
│   ├── Marca.cs
│   ├── Categoria.cs
│   └── Imagen.cs
├── Negocio
│   ├── AccesoDatos.cs
│   ├── ArticuloNegocio.cs
│   └── CatalogoNegocio.cs
├── Form1.cs
├── FormAltaArticulo.cs
├── FormCatalogos.cs
├── FormDetalleArticulo.cs
```

## Estado actual

Proyecto funcional con ABM completo de artículos, marcas y categorías.

## Observaciones

Trabajo práctico realizado con fines académicos.

## Repositorio

```
https://github.com/AlejandroGCorzo/tp-winform-equipo-3a
```
