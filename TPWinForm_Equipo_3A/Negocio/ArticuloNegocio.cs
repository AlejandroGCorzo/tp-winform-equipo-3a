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
                    aux.Descripcion = datos.Lector["Descripcion"] is DBNull ? "" : (string)datos.Lector["Descripcion"];
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
    }
}