using System;
using System.Collections;
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
    public partial class Carta : Form
    {
        ArrayList nuevo = new ArrayList();
        public Carta()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //pictureBox1.ImageLocation = @"C:\Users\MSI\Desktop\MYAPP\Slider\Slider\bt1.jpg";          
        }
        private void SetDraws(ArrayList entry)
        {
            this.nuevo = entry;
        }

        public void updateDraws()
        {

            img1.Image = Properties.Resources.gato;
        }

        private void Carta_Load(object sender, EventArgs e)
        {

        }
    }
}
