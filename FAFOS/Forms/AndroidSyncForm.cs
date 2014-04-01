using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Xml;
using System.IO;

namespace FAFOS.Forms
{
    public partial class AndroidSyncForm : Form
    {
        Thread listenThread;
        TCPModel _TCPModel = null;
        Thread clientThread;
        int port;
        String fafosIP;

        public event EventHandler androidClosed;
        public AndroidSyncForm()
        {
            InitializeComponent();
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    fafosIP = ip.ToString();
                    ipLabel.Text += fafosIP;
                }
            }
            
        }
        public void ListenForClients()
        {
            // Create a model to listen from clients

            _TCPModel = new TCPModel(port, fafosIP);

            //            while (true)
            //   {
            //blocks until a client has connected to the server
            Socket TCPsocket = _TCPModel.AcceptOneClient();

            //create a thread to handle communication with connected client                
            clientThread = new Thread(new ParameterizedThreadStart(Communications));
            clientThread.IsBackground = true; // to stop all threads when application is terminated
            clientThread.Start(TCPsocket);
            // }
        }

        public void Communications(object socket)
        {
            Socket TCP_socket = (Socket)socket;

            // Create a new client object 
            ClientModel _ClientModel = new ClientModel(TCP_socket);

            while (true)
            {
                //Wait for the client data
                string XMLData = _ClientModel.ReceiveFromClient();   // block until client sends XML message
                if (XMLData != null)
                {
                    string url = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory)
                   + "\\Resources\\inspection.xml";
                    using (StreamWriter writer = new StreamWriter(url))
                    {
                        writer.Write(XMLData);
                        writer.Flush();
                    }
                    MessageBox.Show("Data Read Successful");
                    
                    break;
                    
                }
                else
                {
                    break;
                }
                statusLabel.Text = "Ready to Connect";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                port = Int32.Parse(portBox.Text);
                this.listenThread = new Thread(ListenForClients);
                listenThread.IsBackground = true; // to stop all threads when application is terminated
                this.listenThread.Start();
                statusLabel.Text = "Waiting for Data...";
            }
            catch (Exception x)
            {
                MessageBox.Show("Invalid Port Number", "Error");
            }
        }

        private void AndroidSyncForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            androidClosed(sender, e);
        }
    }
    class ClientModel
    {
        private Socket ClientSocket;
        private const int BufferSize = 15000;
        private byte[] buffer = new byte[BufferSize];

        public ClientModel(Socket s)
        {
            this.ClientSocket = s;
            ClientIP = ((IPEndPoint)s.RemoteEndPoint).Address;
            ClientPort = ((IPEndPoint)s.RemoteEndPoint).Port;
        }

        public string ReceiveFromClient()
        {
            byte[] data = new byte[BufferSize];
            int byteRecv = 0;
            string receivedData = null;
            try
            {
                byteRecv = ClientSocket.Receive(data, 0, BufferSize, SocketFlags.None);
                if (byteRecv > 0)
                {
                    return receivedData = Encoding.ASCII.GetString(data, 0, byteRecv);
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public IPAddress ClientIP { get; set; }
        public int ClientPort { get; set; }
        public IPEndPoint clientEndPoint { get; set; }

    }
    class TCPModel
    {
        private Socket listening_RTSPsocket = null;
        private IPAddress ServerIPAddr = null;
        private int RTSPport;

        public TCPModel(int GivenPort, String ip)
        {
            // Creating TCP listening socket
            if (listening_RTSPsocket == null)
                listening_RTSPsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Creating Endpoint to the localhost address with the given port number
            /*IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIP = ip;
                }
            }*/
            ServerIP = IPAddress.Parse(ip);
            RTSPport = GivenPort;
            IPEndPoint listenEndPoint = new IPEndPoint(ServerIPAddr, RTSPport);

            // Bind server socket to Endpoint object
            listening_RTSPsocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            listening_RTSPsocket.Bind(listenEndPoint);

            listening_RTSPsocket.Listen(int.MaxValue);


        }
        ~TCPModel()
        {
            listening_RTSPsocket.Close();

        }

        public Socket AcceptOneClient()
        {
            //blocks until a client has connected to the server
            return this.listening_RTSPsocket.Accept();
        }

        public IPAddress ServerIP
        {
            get { return ServerIPAddr; }
            set { ServerIPAddr = value; }
        }

    }
}
