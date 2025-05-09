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
                    "INSERT INTO tbl_contribuyentes " +
                    "(rut, nombre, apellido, nacionalidad, comuna) " +
                    "VALUES ('{ 0 }', '{1}', '{2}', '{3}', '{4}')",
                    contribuyente.rut, contribuyente.nombre, contribuyente.apellido,
                    contribuyente.nacionalidad, contribuyente.comuna), conexion);
            retorno = command.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }
    }
}
