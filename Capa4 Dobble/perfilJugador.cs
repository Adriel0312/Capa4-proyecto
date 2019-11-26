using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Capa4_Dobble
{
    public partial class perfilJugador : Form
    {
        string usuario;
        public perfilJugador(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            label1.Text = usuario;
        }

        private void perfilJugador_Load(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
             }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vetanaTower = new ToweringInferno(usuario);
            vetanaTower.Show();
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddr = IPAddress.Parse("192.168.0.3");//AQUI SE ESTABLECE LA IP DEL SERVER
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 50000);//AQUI SE ESTABLECE EL PUERTO DEL SERVER
                Socket sender2 = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {

                    // Connect Socket to the remote  
                    // endpoint using method Connect() 
                    sender2.Connect(localEndPoint);

                    // We print EndPoint information  
                    // that we are connected 
                    Console.WriteLine("Socket connected to -> {0} ",
                                  sender2.RemoteEndPoint.ToString());


                    byte[] messageSent = Encoding.ASCII.GetBytes("[1]:[" + usuario + "]");
                    int byteSent = sender2.Send(messageSent);

                    byte[] messageReceived = new byte[1024];

                    // We receive the messagge using  
                    // the method Receive(). This  
                    // method returns number of bytes 
                    // received, that we'll use to  
                    // convert them to string 
                    int byteRecv = sender2.Receive(messageReceived);
                    if (Encoding.ASCII.GetString(messageReceived, 0, byteRecv) == "1")
                    {
                        MessageBox.Show("Sala de juego encontrada.");
                        var vetanaTower2 = new ToweringInferno(usuario);

                    }
                    else
                    {
                        MessageBox.Show("No hay salas de juego disponibles, intente de nuevo");
                    }


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

            catch (Exception e2)
            {
                MessageBox.Show("No se pudo establecer conexión con el servidor 111");
                Console.WriteLine(e2.ToString());
            }
        }
    }
}
