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
            int[] arreglo2 = { 10, 6, 5, 25, 16, 13, 42, 11 };
            int[] arreglo3 = { 10, 4, 20, 21, 22, 23, 24, 26 };
            int[] arreglo4 = { 14, 10, 27, 28, 29, 30, 31, 32 };
            int[] arreglo5 = { 14, 11, 4, 33, 34, 35, 36, 37 };

            updateDraws(arreglo);
            updateDraws2(arreglo2);  
            updateDraws3(arreglo3);
            updateDraws4(arreglo4);
            updateDraws5(arreglo5);

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

        public void updateDraws2(int[] entry)
        {
            img1_2.Image = imagenes[entry[0]];
            img2_2.Image = imagenes[entry[1]];
            img3_2.Image = imagenes[entry[2]];
            img4_2.Image = imagenes[entry[3]];
            img5_2.Image = imagenes[entry[4]];
            img6_2.Image = imagenes[entry[5]];
            img7_2.Image = imagenes[entry[6]];
            img8_2.Image = imagenes[entry[7]];
        }

        public void updateDraws3(int[] entry)
        {
            img1_3.Image = imagenes[entry[0]];
            img2_3.Image = imagenes[entry[1]];
            img3_3.Image = imagenes[entry[2]];
            img4_3.Image = imagenes[entry[3]];
            img5_3.Image = imagenes[entry[4]];
            img6_3.Image = imagenes[entry[5]];
            img7_3.Image = imagenes[entry[6]];
            img8_3.Image = imagenes[entry[7]];
        }

        public void updateDraws4(int[] entry)
        {
            img1_4.Image = imagenes[entry[0]];
            img2_4.Image = imagenes[entry[1]];
            img3_4.Image = imagenes[entry[2]];
            img4_4.Image = imagenes[entry[3]];
            img5_4.Image = imagenes[entry[4]];
            img6_4.Image = imagenes[entry[5]];
            img7_4.Image = imagenes[entry[6]];
            img8_4.Image = imagenes[entry[7]];
        }

        public void updateDraws5(int[] entry)
        {
            img1_5.Image = imagenes[entry[0]];
            img2_5.Image = imagenes[entry[1]];
            img3_5.Image = imagenes[entry[2]];
            img4_5.Image = imagenes[entry[3]];
            img5_5.Image = imagenes[entry[4]];
            img6_5.Image = imagenes[entry[5]];
            img7_5.Image = imagenes[entry[6]];
            img8_5.Image = imagenes[entry[7]];
        }

        private void poisonedGift_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(new Rectangle(0, 2, 291, 291));
            panel3.Region = new Region(gp);
            panel1.Region = new Region(gp);
            panel2.Region = new Region(gp);
            panel4.Region = new Region(gp);
            panel5.Region = new Region(gp);

            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void img3_4_Click(object sender, EventArgs e)
        {

        }

        private void img6_4_Click(object sender, EventArgs e)
        {

        }

        private void img8_4_Click(object sender, EventArgs e)
        {

        }

        private void img7_4_Click(object sender, EventArgs e)
        {

        }

        private void img2_Click(object sender, EventArgs e)
        {

        }

        private void img3_Click(object sender, EventArgs e)
        {

        }

        private void img1_Click(object sender, EventArgs e)
        {

        }

        private void img6_Click(object sender, EventArgs e)
        {

        }

        private void img2_2_Click(object sender, EventArgs e)
        {

        }

        private void img3_2_Click(object sender, EventArgs e)
        {

        }

        private void img3_3_Click(object sender, EventArgs e)
        {

        }

        private void img7_3_Click(object sender, EventArgs e)
        {

        }

        private void img6_3_Click(object sender, EventArgs e)
        {

        }

        private void img8_3_Click(object sender, EventArgs e)
        {

        }

        private void img5_4_Click(object sender, EventArgs e)
        {

        }

        private void img8_2_Click(object sender, EventArgs e)
        {

        }

        private void img4_4_Click(object sender, EventArgs e)
        {

        }

        private void img3_5_Click(object sender, EventArgs e)
        {

        }

        private void img7_5_Click(object sender, EventArgs e)
        {

        }

        private void img4_Click(object sender, EventArgs e)
        {

        }

        private void img7_2_Click(object sender, EventArgs e)
        {

        }

        private void img6_2_Click(object sender, EventArgs e)
        {

        }

        private void img4_2_Click(object sender, EventArgs e)
        {

        }

        private void img4_3_Click(object sender, EventArgs e)
        {

        }

        private void img2_3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_me_Click(object sender, EventArgs e)
        {

        }
    }
}
