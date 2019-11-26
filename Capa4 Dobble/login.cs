using Capa4_Dobble.Adriel;
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
          
            //var ventana = new ToweringInferno();
            //ventana.Show();
            //var ventana2 = new TheWell();
            //ventana2.Show();
            //var regaloEnvenenado = new Frander.Regalo_Envenenado.poisonedGift();
            //regaloEnvenenado.Show();



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
            /*
            panelRegistro.Visible = true;
            int[] cartas = { 0, 44, 31, 7, 25, 50, 4, 41 };
            Carta ventadaCard = new Carta();
            
            //ventadaCard.SetDraws(cartas);
            ventadaCard.updateDraws(cartas);
            ventadaCard.Show();
            */
            Frander.Regalo_Envenenado.poisonedGift RegaloEnvenendo = new Frander.Regalo_Envenenado.poisonedGift();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario.");
            }
            else {
                var myForm = new perfilJugador(usuario.Text);
                myForm.Show();
            }
         
        }



        private void panelLog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
