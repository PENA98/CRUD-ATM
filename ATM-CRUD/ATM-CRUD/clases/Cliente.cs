using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace ATM_CRUD.clases
{
    class Cliente
    {
        // Propiedades
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string identidad { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }

        // Métodos
        /// <summary>
        /// Obtiene un cliente desde la tabla ATM.Cliente
        /// </summary>
        /// <param name="identidad">La identidad del cliente (13 caracteres)</param>
        /// <returns>Un objeto de tipo Cliente.</returns>
        /// 


        public void  CrearCliente(Cliente Cl)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql;

            sql = @"exec sp_crearCliente @nombre, @apellido, @identidad, @direccion, @telefono, @celular";

            SqlCommand cmd = conexion.EjecutarComando(sql);

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = Cl.nombres;
                    cmd.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = Cl.apellidos;
                    cmd.Parameters.Add("@identidad", SqlDbType.Char).Value = Cl.identidad;
                    cmd.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = Cl.direccion;
                    cmd.Parameters.Add("@telefono", SqlDbType.Char).Value = Cl.telefono;
                    cmd.Parameters.Add("@celular", SqlDbType.Char).Value = Cl.celular;
                }

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }
        
        public static Cliente ObtenerCliente(string identidad)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql;
            Cliente resultado = new Cliente();

            // Query SQL
            sql = @"SELECT *
                    FROM ATM.Cliente
                    WHERE identidad = @identidad";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@identidad", SqlDbType.Char, 13).Value = identidad;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.id = rdr.GetInt16(0);
                    resultado.nombres = rdr.GetString(1);
                    resultado.apellidos = rdr.GetString(2);
                    resultado.identidad = rdr.GetString(3);
                    resultado.direccion = rdr.GetString(4);
                    resultado.telefono = rdr.GetString(5);
                    resultado.celular = rdr.GetString(6);

                    // Remover espacios
                }

                return resultado;
            }
            catch (SqlException ex)
            {
                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
