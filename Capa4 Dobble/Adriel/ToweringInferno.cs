using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace Capa4_Dobble
{
    //public class ExThread
    //{

    //    Non-static method
    //    public void mythread1()
    //    {
    //        for (int z = 0; z < 3; z++)
    //        {
    //            Console.WriteLine("First Thread");
    //        }
    //    }
    //}

    public partial class ToweringInferno : Form
    {
        List<System.Drawing.Image> imagenes = new List<System.Drawing.Image>();
        private System.Windows.Forms.Timer timer1;
        private int counter = 5;
        string usuario;
        Socket sender2;
        IPEndPoint localEndPoint;
        public ToweringInferno(string usuario)
        {
            this.usuario = usuario;


           
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
           
            
           
        }
        public void RecibeMensajes()
        {
            Capa4_Dobble.Carta.Mazo carta = new Capa4_Dobble.Carta.Mazo();
            while (true)
            {
                try
                {
                    byte[] messageReceived = new byte[1024];
                    
                    
                    int mazoRecv = sender2.Receive(messageReceived);
                    string cartaMazo = Encoding.ASCII.GetString(messageReceived, 0, mazoRecv);
                    int cartaRecv = sender2.Receive(messageReceived);
                    string cartaUsuario = Encoding.ASCII.GetString(messageReceived, 0, cartaRecv);

                    //if (Encoding.ASCII.GetString(messageReceived, 0, byteRecv).Length <= 2) // 38
                    //{

                    //    string mensaje = Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
                    //    int comando = Int32.Parse(mensaje);
                    //    List<int> arreglo = carta.Mazo(comando);
                    //    updateDraws(arreglo);
                    //    var vetanaTower2 = new ToweringInferno(usuario);

                    //}
                    //else
                    //{
                    //}


                    sender2.Shutdown(SocketShutdown.Both);
                    sender2.Close();
                }

                // Manage of Socket's Exceptions 
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("No se pudo establecer conexión con el servidor");
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }

                catch (SocketException se)
                {
                    MessageBox.Show("No se pudo establecer conexión con el servidor");
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }

                catch (Exception e2)
                {
                    MessageBox.Show("No se pudo establecer conexión con el servidor");
                    Console.WriteLine("Unexpected exception : {0}", e2.ToString());
                }
            }
       


           
            
        }


        private void btnStart_Click_1(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timee.Text = "AHORA!".ToString();
                timer1.Stop();
                
                pictureBox9.Visible = false;

            }
                
            timee.Text = counter.ToString();
        }
        private void ToweringInferno_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            try {
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddr = IPAddress.Parse("192.168.0.3");//AQUI SE ESTABLECE LA IP DEL SERVER
                localEndPoint = new IPEndPoint(ipAddr, 50000);//AQUI SE ESTABLECE EL PUERTO DEL SERVER
                sender2 = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                sender2.Connect(localEndPoint);

            }
            catch{ }


            Thread t = new Thread(RecibeMensajes);
            t.Start();


            int[] arreglo = { 31, 22, 27, 44, 43, 45, 4, 10 };
            int[] arreglo2 = { 45, 52, 11, 17, 28, 48, 2, 40 };


           
            

            Rectangle r = new Rectangle(0, 0, panel3.Width, panel3.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddEllipse(new Rectangle(0, 2, 370, 370));
            panel3.Region = new Region(gp);


            Rectangle r2 = new Rectangle(0, 0, panel1.Width, panel1.Height);
            System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
            gp2.AddEllipse(new Rectangle(0, 2, 370, 370));
            panel1.Region = new Region(gp2);


            Rectangle r3 = new Rectangle(0, 0, pictureBox9.Width, pictureBox9.Height);
            System.Drawing.Drawing2D.GraphicsPath gp3 = new System.Drawing.Drawing2D.GraphicsPath();
            gp3.AddEllipse(new Rectangle(0, 0, 370, 370));
            pictureBox9.Region = new Region(gp3);
            this.WindowState = FormWindowState.Maximized;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            timee.Text = counter.ToString();
        }

        public void updateDraws(List<int> entry)
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
            Console.WriteLine(entry.Count());
            pictureBox1.Image = imagenes[entry[0]];
            pictureBox2.Image = imagenes[entry[1]];
            pictureBox3.Image = imagenes[entry[2]];
            pictureBox4.Image = imagenes[entry[3]];
            pictureBox5.Image = imagenes[entry[4]];
            pictureBox6.Image = imagenes[entry[5]];
            pictureBox7.Image = imagenes[entry[6]];
            pictureBox8.Image = imagenes[entry[7]];

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void timee_Click(object sender, EventArgs e)
        {

        }
    }
} 
