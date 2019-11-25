using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa4_Dobble.Frander.Regalo_Envenenado
{
    public partial class poisonedGift : Form
    {
        List<System.Drawing.Image> imagenes = new List<System.Drawing.Image>();

        public poisonedGift()
        {
            InitializeComponent();
            imagenes.Add(Properties.Resources._0);
            imagenes.Add(Properties.Resources._2);
            imagenes.Add(Properties.Resources._3);
            imagenes.Add(Properties.Resources._4);
            imagenes.Add(Properties.Resources._5);
            imagenes.Add(Properties.Resources._6);
            imagenes.Add(Properties.Resources._7);
            imagenes.Add(Properties.Resources._8);
            imagenes.Add(Properties.Resources._9);
            imagenes.Add(Properties.Resources._10);
            imagenes.Add(Properties.Resources._11);
            imagenes.Add(Properties.Resources._12);
            imagenes.Add(Properties.Resources._13);
            imagenes.Add(Properties.Resources._14);
            imagenes.Add(Properties.Resources._15);
            imagenes.Add(Properties.Resources._16);
            imagenes.Add(Properties.Resources._17);
            imagenes.Add(Properties.Resources._18);
            imagenes.Add(Properties.Resources._19);
            imagenes.Add(Properties.Resources._20);
            imagenes.Add(Properties.Resources._21);
            imagenes.Add(Properties.Resources._22);
            imagenes.Add(Properties.Resources._23);
            imagenes.Add(Properties.Resources._24);
            imagenes.Add(Properties.Resources._25);
            imagenes.Add(Properties.Resources._26);
            imagenes.Add(Properties.Resources._28);
            imagenes.Add(Properties.Resources._29);
            imagenes.Add(Properties.Resources._30);
            imagenes.Add(Properties.Resources._31);
            imagenes.Add(Properties.Resources._32);
            imagenes.Add(Properties.Resources._33);
            imagenes.Add(Properties.Resources._34);
            imagenes.Add(Properties.Resources._35);
            imagenes.Add(Properties.Resources._36);
            imagenes.Add(Properties.Resources._37);
            imagenes.Add(Properties.Resources._38);
            imagenes.Add(Properties.Resources._39);
            imagenes.Add(Properties.Resources._40);
            imagenes.Add(Properties.Resources._41);
            imagenes.Add(Properties.Resources._42);
            imagenes.Add(Properties.Resources._43);
            imagenes.Add(Properties.Resources._44);
            imagenes.Add(Properties.Resources._45);
            imagenes.Add(Properties.Resources._46);
            imagenes.Add(Properties.Resources._47);
            imagenes.Add(Properties.Resources._48);
            imagenes.Add(Properties.Resources._49);
            imagenes.Add(Properties.Resources._50);
            imagenes.Add(Properties.Resources._51);
            imagenes.Add(Properties.Resources._52);
            imagenes.Add(Properties.Resources._53);
            imagenes.Add(Properties.Resources._54);
            imagenes.Add(Properties.Resources._55);
            imagenes.Add(Properties.Resources._56);
            imagenes.Add(Properties.Resources._57);
            int[] arreglo = { 14, 4, 9, 17, 16, 15, 18, 8 };
            updateDraws(arreglo);
            
        }

        public void updateDraws(int[] entry)
        {
            img1.Image = imagenes[entry[0]];
            img2.Image = imagenes[entry[1]];
            img3.Image = imagenes[entry[2]];
            img4.Image = imagenes[entry[3]];
            img5.Image = imagenes[entry[4]];
            img6.Image = imagenes[entry[5]];
            img7.Image = imagenes[entry[6]];
            img8.Image = imagenes[entry[7]];
        }

        private void poisonedGift_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(new Rectangle(0, 2, 370, 370));
            panel3.Region = new Region(gp);
            this.WindowState = FormWindowState.Maximized;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
