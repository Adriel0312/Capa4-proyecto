using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa4_Dobble
{
    public partial class login : Form
    {
        public login()
        {

            InitializeComponent();
            panelInicioSesion.Visible = false;
            panelRegistro.Visible = false;
            contrasennaUsuario.Text = "";
            contrasennaUsuario.PasswordChar = '*';
            contrasennaUsuario.MaxLength = 14;
            textConstrasennaRegsitro.Text = "";
            textConstrasennaRegsitro.PasswordChar = '*';
            textConstrasennaRegsitro.MaxLength = 14;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelInicioSesion.Visible = true;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            panelInicioSesion.Visible = false;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
                    }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrarse_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false; 
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            var myForm = new perfilJugador();
            myForm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
