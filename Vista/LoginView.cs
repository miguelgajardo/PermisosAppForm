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

namespace PermisosAppForm
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean isLogin = false;
            LoginController loginControl = new LoginController();
            if (textBox1.Text != null && textBox2.Text != null)
            {
                Credencial credencial = new Credencial(textBox1.Text, textBox2.Text);
                isLogin = loginControl.login(credencial);
                if (isLogin)
                {
                    Vista.DashboardView dashboard = new Vista.DashboardView();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Error al intentar iniciar sesión!");
                }
            } else
            {
                MessageBox.Show("Ingrese valores válidos para el inicio de sesión!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
