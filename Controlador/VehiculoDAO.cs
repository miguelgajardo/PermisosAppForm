using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PermisosAppForm.Modelo;
using MySql.Data.MySqlClient;
using PermisosAppForm.Config;

namespace PermisosAppForm.Controlador
{
    internal class VehiculoDAO
    {
        public static int registrarVehiculo(Vehiculo vehiculo, string rutContribuyente)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand command = new MySqlCommand(
                string.Format(
                    "INSERT INTO tbl_vehiculos(patente, marca, modelo, anio, rut_contribuyente) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    vehiculo.patente, vehiculo.marca, vehiculo.modelo,
                    vehiculo.anio, rutContribuyente),
                conexion);
            retorno = command.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int modificarVehiculo(Vehiculo vehiculo)
        {
            int resp = 0;
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand orden = new MySqlCommand(string.Format("UPDATE tbl_vehiculos SET marca='{0}', modelo='{1}', anio='{2}' WHERE patente='{3}' ", vehiculo.marca, vehiculo.modelo, vehiculo.anio, vehiculo.patente), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        public static Vehiculo buscarVehiculo(string patente)
        {
            Vehiculo vehiculo = new Vehiculo();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM tbl_vehiculos WHERE patente=@patente"), Conexion.openConnection());
            orden.Parameters.AddWithValue("@patente", patente);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                vehiculo.patente = lector.GetString(0);
                vehiculo.marca = lector.GetString(1);
                vehiculo.modelo = lector.GetString(2);
                vehiculo.anio = lector.GetString(3);
            }
            return vehiculo;
        }

        public static List<Vehiculo> listarVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM tbl_vehiculos"), conexion);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.patente = lector.GetString(0);
                vehiculo.marca = lector.GetString(1);
                vehiculo.modelo = lector.GetString(2);
                vehiculo.anio = lector.GetString(3);
                string rutContribuyente = lector.GetString(4);
                Contribuyente contribuyente = new Contribuyente();
                if (rutContribuyente.Length > 0)
                {
                    contribuyente = ContribuyenteDAO.buscarContribuyente(rutContribuyente);
                    vehiculo.contribuyente = contribuyente;
                }
                lista.Add(vehiculo);
            }
            return lista;
        }

        public static int eliminarVehiculo(string patente)
        {
            int resp = 0;
            MySqlConnection conexion = Conexion.openConnection();
            MySqlCommand orden = new MySqlCommand(string.Format("DELETE FROM tbl_vehiculos WHERE patente='{0}' ", patente), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }
    }
}
