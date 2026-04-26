using System.Data;
using Microsoft.Data.SqlClient;

namespace TPWinForm_Equipo_3A.Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection(
                "Server=localhost,50016;Database=TPWinForm_Equipo_3A;Integrated Security=True;TrustServerCertificate=True;"
            );

            comando = new SqlCommand();
        }

        public void SetearConsulta(string consulta)
        {
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
        }

        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            conexion.Open();
            lector = comando.ExecuteReader();
        }

        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public void SetearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close();

            conexion.Close();
        }
    }
}