using System;
using System.Collections.Generic;
using TPWinForm_Equipo_3A.Dominio;

namespace TPWinForm_Equipo_3A.Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(@"
                    SELECT
                        A.Id,
                        A.Codigo,
                        A.Nombre,
                        A.Descripcion,
                        M.Nombre AS Marca,
                        C.Nombre AS Categoria,
                        A.Precio,
                        ISNULL(I.UrlImagen, '') AS ImagenUrl
                    FROM Articulos A
                    INNER JOIN Marcas M ON A.IdMarca = M.Id
                    INNER JOIN Categorias C ON A.IdCategoria = C.Id
                    LEFT JOIN ImagenesArticulo I ON I.IdArticulo = A.Id
                ");

                datos.EjecutarLectura();

                while (datos.Lector != null && datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = datos.Lector["Descripcion"] is DBNull
                        ? ""
                        : (string)datos.Lector["Descripcion"];

                    aux.Marca.Nombre = (string)datos.Lector["Marca"];
                    aux.Categoria.Nombre = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }

                return lista;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Agregar(
            string codigo,
            string nombre,
            string descripcion,
            decimal precio,
            string marca,
            string categoria,
            List<string> imagenes)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(@"
                    INSERT INTO Articulos
                        (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)
                    VALUES
                        (
                            @codigo,
                            @nombre,
                            @descripcion,
                            (SELECT Id FROM Marcas WHERE Nombre=@marca),
                            (SELECT Id FROM Categorias WHERE Nombre=@categoria),
                            @precio
                        )
                ");

                datos.SetearParametro("@codigo", codigo);
                datos.SetearParametro("@nombre", nombre);
                datos.SetearParametro("@descripcion", descripcion);
                datos.SetearParametro("@marca", marca);
                datos.SetearParametro("@categoria", categoria);
                datos.SetearParametro("@precio", precio);

                datos.EjecutarAccion();
                datos.CerrarConexion();

                foreach (string url in imagenes)
                {
                    AccesoDatos img = new AccesoDatos();

                    img.SetearConsulta(@"
                        INSERT INTO ImagenesArticulo
                            (IdArticulo, UrlImagen)
                        VALUES
                            ((SELECT MAX(Id) FROM Articulos), @url)
                    ");

                    img.SetearParametro("@url", url);
                    img.EjecutarAccion();
                    img.CerrarConexion();
                }
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Modificar(
            int id,
            string codigo,
            string nombre,
            string descripcion,
            decimal precio,
            string marca,
            string categoria,
            List<string> imagenes)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(@"
                    UPDATE Articulos
                    SET
                        Codigo = @codigo,
                        Nombre = @nombre,
                        Descripcion = @descripcion,
                        IdMarca = (SELECT Id FROM Marcas WHERE Nombre=@marca),
                        IdCategoria = (SELECT Id FROM Categorias WHERE Nombre=@categoria),
                        Precio = @precio
                    WHERE Id = @id
                ");

                datos.SetearParametro("@codigo", codigo);
                datos.SetearParametro("@nombre", nombre);
                datos.SetearParametro("@descripcion", descripcion);
                datos.SetearParametro("@marca", marca);
                datos.SetearParametro("@categoria", categoria);
                datos.SetearParametro("@precio", precio);
                datos.SetearParametro("@id", id);

                datos.EjecutarAccion();
                datos.CerrarConexion();

                AccesoDatos borrar = new AccesoDatos();

                borrar.SetearConsulta(
                    "DELETE FROM ImagenesArticulo WHERE IdArticulo=@id");

                borrar.SetearParametro("@id", id);
                borrar.EjecutarAccion();
                borrar.CerrarConexion();

                foreach (string url in imagenes)
                {
                    AccesoDatos img = new AccesoDatos();

                    img.SetearConsulta(@"
                        INSERT INTO ImagenesArticulo
                            (IdArticulo, UrlImagen)
                        VALUES (@id, @url)
                    ");

                    img.SetearParametro("@id", id);
                    img.SetearParametro("@url", url);

                    img.EjecutarAccion();
                    img.CerrarConexion();
                }
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}