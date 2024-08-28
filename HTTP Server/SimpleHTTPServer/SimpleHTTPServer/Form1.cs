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
using System.Threading;
using System.CodeDom;
using System.Drawing.Text;



namespace SimpleHTTPServer
{
    public partial class Form1 : Form
    {
        private Socket httpServer;
        private int serverPort = 80;
        private Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void ServerLogsText_TextChanged(object sender, EventArgs e)
        {

        }
        private void ServerPortText_TextChanged(object sender, EventArgs e)
        {

        }

        private void S_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StopServerBtn.Enabled = false;
        }

        private void StartServerBtn_Click(object sender, EventArgs e)
        {

            ServerLogsText.Text = "";

            try
            {
                httpServer = new Socket(SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    serverPort = int.Parse(ServerPortText.Text.ToString());
                    if (serverPort > 65535 || serverPort <= 0)
                    {
                        throw new Exception("Server Port not within the range");
                    }
                }
                catch (Exception ex)
                {
                    serverPort = 80;
                    ServerLogsText.Text = "Server Failed to Start on Specified Port \n";
                }
                thread = new Thread(new ThreadStart(this.connectionThreadMethod));
                thread.Start();

                //disable and enable buttons
                StartServerBtn.Enabled = false;
                StopServerBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while starting the server");
                ServerLogsText.Text = "Server Starting Failed \n";
            }
            ServerLogsText.Text = "Server Started";

        }

        private void StopServerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //close the socket
                httpServer.Close();

                //kill the thread
                thread.Abort();

                //disable and enable buttons
                StartServerBtn.Enabled = true;
                StopServerBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stopping Failed");
            }
        }
        private void connectionThreadMethod()
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, serverPort);
                httpServer.Bind(endpoint);
                httpServer.Listen(1);
                startListeningForConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("I could not start.");
            }
        }
        private void startListeningForConnection()
        {
            while (true)
            {
                DateTime time = DateTime.Now;

                String data = "";
                byte[] bytes = new byte[2048];

                Socket client = httpServer.Accept(); //Blocking Statement

                //reading the inbound connection data
                while (true)
                {

                    int numBytes = client.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, numBytes);

                    if (data.IndexOf("\r\n") > -1)
                        break;
                }
                //data read

                ServerLogsText.Invoke((MethodInvoker)delegate
                {
                    //runs inside the UI thread
                    ServerLogsText.Text += "\r\n\r\n";
                    ServerLogsText.Text += data;
                    ServerLogsText.Text += "\n\n-------End of Request-------";
                });

                //send back the response
                String resHeader = "HTTP/1.1 200 Everything is Fine\nServer: my_cSharp server\nContent-Type: text/html; charset: UTF-8\n\n";
                String resBody = "<!DOCTYPE html>" +
                    "<html>" +
                    "<head><title>My Server</title></head>" +
                    "<body>" +
                    "<h4>Server Time is: " + time.ToString() + "</h4>" +
                    "</body></html>";

                String resStr = resHeader + resBody;

                byte[] resData = Encoding.ASCII.GetBytes(resStr);

                client.SendTo(resData, client.RemoteEndPoint);

                client.Close();

            }
        }
    }
}

