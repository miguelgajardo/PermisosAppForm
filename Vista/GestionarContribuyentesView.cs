using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PermisosAppForm.Controlador;
using PermisosAppForm.Modelo;

namespace PermisosAppForm.Vista
{
    public partial class GestionarContribuyentesView : Form
    {
        public GestionarContribuyentesView()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridContribuyentes.DataSource = ContribuyenteDAO.listarContribuyentes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContribuyenteDAO contribuyenteDAO = new ContribuyenteDAO();
            Contribuyente contribuyente = new Contribuyente(
                textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text
                );
            int resp = contribuyenteDAO.crearContribuyente(contribuyente);
            if (resp > 0)
            {
                MessageBox.Show("Contribuyente registrado en Base de Datos",
                              "AVISO DE SISTEMA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Contribuyente No fue registrado en Base de Datos.",
                              "AVISO DE SISTEMA",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Focus();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContribuyenteDAO contribuyenteDAO = new ContribuyenteDAO();
            Console.WriteLine("buscando por RUT de contribuyente" + textBox6.Text);
            Contribuyente contribuyente = new Contribuyente();
            string rut = textBox6.Text;
            contribuyente = ContribuyenteDAO.buscarContribuyente(rut);
            if (contribuyente != null)
            {
                textBox7.Text = contribuyente.rut;
                textBox8.Text = contribuyente.nombre;
                textBox9.Text = contribuyente.apellido;
                textBox10.Text = contribuyente.nacionalidad;
                textBox11.Text = contribuyente.comuna;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contribuyente contribuyente = new Contribuyente();
            contribuyente.rut = textBox7.Text;
            contribuyente.nombre = textBox8.Text;
            contribuyente.apellido = textBox9.Text;
            contribuyente.nacionalidad = textBox10.Text;
            contribuyente.comuna = textBox11.Text;
            int resp = ContribuyenteDAO.modificarContribuyente(contribuyente);
            if (resp > 0)
            {
                MessageBox.Show("Contribuyente Modificado.", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Contribuyente No Modificado, Verificar.", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string rut = textBox7.Text;
            int resp = ContribuyenteDAO.eliminarContribuyente(rut);
            if (resp > 0)
            {
                MessageBox.Show("Contribuyente Eliminado de la Tabla.", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Contribuyente No Eliminado.", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }



    }
}
