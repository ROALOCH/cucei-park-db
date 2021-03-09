using System;
using System.Configuration;
using System.Data.Common;

namespace parkDB
{


    // CLASE PARA EL MANEJO DE LA BASE DE DATOS
    // ABRIR Y CERRAR CONEXIÓN PARA CADA PETICIÓN CON LOS MÉTODOS Open() y Close()
    // REALIZAR PETICIONES A LA BASE DE DATOS CON EL MÉTODO Query()
    // LAS OPERACIONES EN LA BASE DE DATOS SON BLOQUES TRY-CATCH
    // NO ES NECESARIO LLAMAR EL MÉTODO DENTRO DE OTRO BLOQUE TRY-CATCH


    public class ConexionBD
    {
        private string proveedorSQL = ConfigurationManager.AppSettings["proveedorSQL"];
        private string cadenaConexion = ConfigurationManager.AppSettings["cadenaConexion"];

        DbProviderFactory factory = null;
        DbConnection conexion = null;
        DbCommand comandoSQL = null;

        public ConexionBD()
        {
            factory = DbProviderFactories.GetFactory(proveedorSQL);
            conexion = factory.CreateConnection();
            comandoSQL = factory.CreateCommand();

            if (conexion == null || comandoSQL == null)
            {
                return;
            }

            conexion.ConnectionString = cadenaConexion;
            comandoSQL.Connection = conexion;
        }
        public void Open()
        {
            try { conexion.Open(); } catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Close()
        {
            try { conexion.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public DbDataReader Query(string query)
        {
            try
            {
                comandoSQL.CommandText = query;
                return comandoSQL.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // MÉTODO PARA COMPROBAR EL FUNCIONAMIENTO DE LA CONEXIÓN
        public bool Test()
        {
            Open();
            Query("SELECT COUNT(usuario) FROM usuarios;");
            Close();
            return true;
        }
    }
}
