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
    
        List<System.Drawing.Image> imagenes = new List<System.Drawing.Image>();
        public Carta()
        {   
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

            

            

            InitializeComponent();
        }

        public List<int> Mazo(int posicion)
        {
            List<List<int>> mazoCartas = new List<List<int>>();
            mazoCartas.Add(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 });
            mazoCartas.Add(new List<int> { 9, 10, 11, 56, 57, 12, 13, 5 });
            mazoCartas.Add(new List<int> { 14, 4, 9, 17, 16, 15, 18, 8 });
            mazoCartas.Add(new List<int> { 24, 14, 20, 11, 21, 7, 22, 23 });
            mazoCartas.Add(new List<int> { 28, 25, 13, 26, 6, 27, 19, 21 });
            mazoCartas.Add(new List<int> { 29, 13, 30, 17, 7, 31, 33, 32 });
            mazoCartas.Add(new List<int> { 1, 34, 35, 30, 36, 16, 11, 27 });
            mazoCartas.Add(new List<int> { 34, 13, 20, 4, 40, 38, 39, 37 });
            mazoCartas.Add(new List<int> { 35, 37, 41, 21, 31, 42, 2, 9 });
            mazoCartas.Add(new List<int> { 31, 22, 27, 44, 43, 45, 4, 10 });
            mazoCartas.Add(new List<int> { 41, 46, 34, 24, 47, 17, 10, 6 });
            mazoCartas.Add(new List<int> { 20, 6, 36, 9, 33, 49, 48, 43 });
            mazoCartas.Add(new List<int> { 43, 26, 16, 40, 41, 7, 50, 12 });
            mazoCartas.Add(new List<int> { 6, 16, 22, 53, 29, 37, 52, 57 });
            mazoCartas.Add(new List<int> { 41, 33, 27, 56, 14, 3, 52, 38 });
            mazoCartas.Add(new List<int> { 7, 19, 56, 46, 45, 37, 36, 55 });
            mazoCartas.Add(new List<int> { 16, 31, 28, 51, 47, 20, 56, 8 });
            mazoCartas.Add(new List<int> { 50, 39, 3, 30, 9, 22, 46, 28 });
            mazoCartas.Add(new List<int> { 33, 46, 42, 53, 26, 11, 51, 4 });
            mazoCartas.Add(new List<int> { 17, 27, 51, 50, 49, 37, 5, 23 });
            mazoCartas.Add(new List<int> { 42, 32, 20, 52, 10, 19, 50, 1 });
            mazoCartas.Add(new List<int> { 40, 56, 42, 23, 30, 44, 6, 18 });
            mazoCartas.Add(new List<int> { 4, 36, 32, 4, 23, 54, 57, 28 });
            mazoCartas.Add(new List<int> { 46, 32, 38, 44, 48, 5, 21, 16 });
            mazoCartas.Add(new List<int> { 52, 7, 51, 44, 54, 25, 34, 9 });
            mazoCartas.Add(new List<int> { 15, 6, 11, 50, 31, 54, 38, 55 });
            mazoCartas.Add(new List<int> { 36, 22, 42, 38, 25, 8, 12, 17 });
            mazoCartas.Add(new List<int> { 23, 25, 39, 2, 10, 33, 16, 55 });
            mazoCartas.Add(new List<int> { 24, 9, 40, 27, 32, 55, 8, 53 });
            mazoCartas.Add(new List<int> { 19, 44, 8, 49, 29, 11, 41, 39 });
            mazoCartas.Add(new List<int> { 54, 53, 1, 43, 17, 21, 56, 39 });
            mazoCartas.Add(new List<int> { 53, 49, 18, 35, 10, 28, 7, 38 });
            mazoCartas.Add(new List<int> { 25, 59, 1, 57, 14, 40, 46, 31 });
            mazoCartas.Add(new List<int> { 41, 22, 51, 55, 18, 48, 13, 1 });
            mazoCartas.Add(new List<int> { 34, 45, 21, 50, 8, 33, 18, 57 });
            mazoCartas.Add(new List<int> { 42, 39, 57, 48, 15, 47, 7, 27 });
            mazoCartas.Add(new List<int> { 53, 34, 48, 3, 31, 19, 23, 12 });
            mazoCartas.Add(new List<int> { 56, 32, 49, 15, 2, 26, 22, 34 });
            mazoCartas.Add(new List<int> { 15, 12, 37, 24, 33, 35, 44, 1 });
            mazoCartas.Add(new List<int> { 54, 18, 29, 20, 27, 46, 2, 12 });
            mazoCartas.Add(new List<int> { 38, 57, 2, 24, 43, 30, 19, 51 });
            mazoCartas.Add(new List<int> { 4, 56, 50, 25, 24, 29, 48, 35 });
            mazoCartas.Add(new List<int> { 28, 42, 55, 34, 43, 14, 5, 29 });
            mazoCartas.Add(new List<int> { 35, 52, 46, 23, 13, 8, 43, 15 });
            mazoCartas.Add(new List<int> { 6, 51, 32, 39, 35, 14, 45, 12 });
            mazoCartas.Add(new List<int> { 2, 53, 14, 13, 36, 50, 44, 47 });
            mazoCartas.Add(new List<int> { 3, 42, 54, 49, 24, 13, 45, 16 });
            mazoCartas.Add(new List<int> { 45, 45, 47, 26, 9, 23, 38, 1 });
            mazoCartas.Add(new List<int> { 25, 18, 43, 47, 37, 11, 32, 3 });
            mazoCartas.Add(new List<int> { 44, 55, 57, 35, 35, 26, 20, 17 });
            mazoCartas.Add(new List<int> { 48, 26, 26, 37, 10, 54, 8, 30 });
            mazoCartas.Add(new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 });


            //RandomNumber(0, 50);

            //mazoCartas.RemoveAt(51);
            //foreach (List<int> subList in mazoCartas)
            //{
            //    foreach (int item in subList)
            //    {
            //        Console.Write(item + ", ");
            //    }
            //    Console.WriteLine("\n");
            //}
            return mazoCartas[posicion];




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //pictureBox1.ImageLocation = @"C:\Users\MSI\Desktop\MYAPP\Slider\Slider\bt1.jpg";          
        }
        public void SetDraws(int[] entry)
        {

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

        private void Carta_Load(object sender, EventArgs e)
        {

        }

        private void img6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void img5_Click(object sender, EventArgs e)
        {

        }

        private void img2_Click(object sender, EventArgs e)
        {

        }

        private void img8_Click(object sender, EventArgs e)
        {

        }

        private void img7_Click(object sender, EventArgs e)
        {

        }

        private void img3_Click(object sender, EventArgs e)
        {

        }
    }
}
