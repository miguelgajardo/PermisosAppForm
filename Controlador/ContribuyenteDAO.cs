using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PermisosAppForm.Config;
using PermisosAppForm.Modelo;

namespace PermisosAppForm.Controlador
{
    internal class ContribuyenteDAO
    {
        public int crearContribuyente(Contribuyente contribuyente)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand command = new MySqlCommand(
                string.Format(
                    "INSERT INTO tbl_contribuyentes(rut, nombre, apellido, nacionalidad, comuna) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    contribuyente.rut, contribuyente.nombre, contribuyente.apellido,
                    contribuyente.nacionalidad, contribuyente.comuna), 
                conexion);
            retorno = command.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int modificarContribuyente(Contribuyente contribuyente)
        {
            int resp = 0;
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand orden = new MySqlCommand(string.Format("UPDATE tbl_contribuyentes SET nombre='{0}', apellido='{1}', nacionalidad='{2}', comuna='{3}' WHERE rut='{4}' ", contribuyente.nombre, contribuyente.apellido, contribuyente.nacionalidad, contribuyente.comuna, contribuyente.rut), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public static Contribuyente buscarContribuyente(string rut)
        {
            Contribuyente contribuyente = new Contribuyente();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM tbl_contribuyentes WHERE rut=@rut"), Conexion.openConnection());
            orden.Parameters.AddWithValue("@rut", rut);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                contribuyente.rut = lector.GetString(0);
                contribuyente.nombre = lector.GetString(1);
                contribuyente.apellido = lector.GetString(2);
                contribuyente.nacionalidad = lector.GetString(3);
                contribuyente.comuna = lector.GetString(4);
            }
            return contribuyente;
        }

        public static List<Contribuyente> listarContribuyentes()
        {
            List<Contribuyente> lista = new List<Contribuyente>();
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM tbl_contribuyentes"), conexion);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Contribuyente contribuyente = new Contribuyente();
                contribuyente.rut = lector.GetString(0);
                contribuyente.nombre = lector.GetString(1);
                contribuyente.apellido = lector.GetString(2);
                contribuyente.nacionalidad = lector.GetString(3);
                contribuyente.comuna = lector.GetString(4);
                lista.Add(contribuyente);
            }
            return lista;
        }

        public static int eliminarContribuyente(string rut)
        {
            int resp = 0;
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand orden = new MySqlCommand(string.Format("DELETE FROM tbl_contribuyentes WHERE rut='{0}' ", rut), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }
    }
}
