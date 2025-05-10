using System;
using System.Windows.Forms;
using PermisosAppForm.Controlador;
using PermisosAppForm.Modelo;

namespace PermisosAppForm.Vista
{
    public partial class GestionarVehiculosView : Form
    {
        public GestionarVehiculosView()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridVehiculos.DataSource = VehiculoDAO.listarVehiculos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modelo.Contribuyente contribuyente = new Modelo.Contribuyente();
            string rutContribuyente = textBox1.Text;
            contribuyente = ContribuyenteDAO.buscarContribuyente(rutContribuyente);
            if (contribuyente != null)
            {
                textBox2.Text = contribuyente.nombre + " " + contribuyente.apellido;
            } else
            {
                MessageBox.Show("No se encontró al contribuyente - Debe existir para registrar un nuevo vehículo");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int resp = 0;
            string rut = textBox1.Text;
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.patente = textBox4.Text;
            vehiculo.marca = textBox5.Text;
            vehiculo.modelo = textBox6.Text;
            vehiculo.anio = textBox7.Text;
            resp = VehiculoDAO.registrarVehiculo(vehiculo, rut);
            if (resp > 0)
            {
                MessageBox.Show("Vehículo registrado en Base de Datos",
                              "AVISO DE SISTEMA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Vehículo No fue registrado en Base de Datos.",
                              "AVISO DE SISTEMA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo = VehiculoDAO.buscarVehiculo(textBox8.Text);
            if (vehiculo != null) {
                textBox9.Text = vehiculo.patente;
                textBox10.Text = vehiculo.marca;
                textBox11.Text = vehiculo.modelo;
                textBox12.Text = vehiculo.anio;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int resp = 0;
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.patente = textBox9.Text;
            vehiculo.marca = textBox10.Text;
            vehiculo.modelo = textBox11.Text;
            vehiculo.anio = textBox12.Text;
            resp = VehiculoDAO.modificarVehiculo(vehiculo);
            if(resp > 0)
            {
                MessageBox.Show("Vehículo actualizado en Base de Datos",
                              "AVISO DE SISTEMA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Vehículo No fue actualizado en Base de Datos.",
                              "AVISO DE SISTEMA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string patente = textBox8.Text;
            int resp = 0;
            if(patente.Length > 0)
            {
                resp = VehiculoDAO.eliminarVehiculo(patente);
                if(resp > 0)
                {
                    MessageBox.Show("Vehículo eliminado de Base de Datos",
                                  "AVISO DE SISTEMA",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Vehículo No fue eliminado en Base de Datos.",
                                  "AVISO DE SISTEMA",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }
    }
}