using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Capa4_Dobble
{
    public partial class ToweringInferno : Form
    {
        List<System.Drawing.Image> imagenes = new List<System.Drawing.Image>();
        public ToweringInferno()
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
            int[] arreglo={ 14, 4, 9, 17, 16, 15, 18, 8 };
            updateDraws(arreglo);
            //MostrarJuego();
        }
        
        //public void MostrarJuego() {
        //    List<String> participantes = new List<String>();

        //    bool bandera1 = false;
        //    List<List<int>> mazo = Mazo();
        //    int numero = RandomNumber(0, mazo.Count());
        //    while (mazo.Count > 1) {
               
        //        Console.WriteLine("Mazo de cartas");
        //        foreach (int item in mazo[numero])
        //        {
        //            Console.Write(item + ", ");
        //        }
        //        mazo.RemoveAt(numero);
        //        Console.WriteLine("\n");
        //        if (bandera1 == false)
        //        {
        //            Console.WriteLine("Carta del jugador 1");
        //            Console.WriteLine("carta vuelta");
        //            Console.WriteLine("\n");
        //            foreach (int item in mazo[numero])
        //            {
        //                Console.Write(item + ", ");
        //            }
        //            mazo.RemoveAt(numero);
        //            bandera1 = true;
        //        }




        //    }
        //    if (mazo.Count <= 1) {
        //        Console.WriteLine("No quedan cartas");
        //    }
            


        //}

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void ToweringInferno_Load(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, panel3.Width, panel3.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddEllipse(new Rectangle(0, 2, 370, 370));
            //gp.AddArc(r.X, r.Y, d, d, 180, 90);
            //gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            //gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            //gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            panel3.Region = new Region(gp);

            this.WindowState = FormWindowState.Maximized;
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
} 
