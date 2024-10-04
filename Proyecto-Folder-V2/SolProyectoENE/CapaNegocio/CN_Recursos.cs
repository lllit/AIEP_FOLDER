using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class CN_Recursos
    {
        private Conexion conexion = new Conexion();
        public static string GenerarClave()
        {
            string clave = Guid.NewGuid().ToString("N").Substring(0, 6);
            return clave;
        }

        public static string ConvertirSha256(string texto)
        {
            StringBuilder Sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        public static string ConvertirBase64(string ruta, out bool conversion)
        {
            string textoBase64 = string.Empty;
            conversion = true;

            try
            {
                byte[] bytes = File.ReadAllBytes(ruta);
                textoBase64 = Convert.ToBase64String(bytes);


            }
            catch
            {
                conversion = false;
            }

            return textoBase64;

        }

        

        public List<KeyValuePair<string, string>> ObtenerAFP()
        {
            List<KeyValuePair<string, string>> afpList = new List<KeyValuePair<string, string>>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT IdAFP, NombreAFP FROM AFP", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Agregar IdAFP y NombreAFP como pares clave-valor
                        afpList.Add(new KeyValuePair<string, string>(reader["IdAFP"].ToString(), reader["NombreAFP"].ToString()));
                    }
                }

                conn.Close();
            }

            return afpList;
        }

        public List<KeyValuePair<string, string>> ObtenerSalud()
        {
            List<KeyValuePair<string, string>> saludList = new List<KeyValuePair<string, string>>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT IdSalud, NombreSalud FROM Salud", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Agregar IdSalud y NombreSalud como pares clave-valor
                        saludList.Add(new KeyValuePair<string, string>(reader["IdSalud"].ToString(), reader["NombreSalud"].ToString()));
                    }
                }

                conn.Close();
            }

            return saludList;
        }

    }
}
