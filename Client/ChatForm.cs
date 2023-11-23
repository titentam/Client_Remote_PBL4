using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ChatForm : Form
    {
        private TcpClient client;
        private NetworkStream clientStream;
        private Thread listenerThread;

        public ChatForm()
        {
            InitializeComponent();
        }

        public void ConnectToServer()
        {
            client = new TcpClient("127.0.0.1", 6966);
            clientStream = client.GetStream();

            listenerThread = new Thread(new ThreadStart(ListenForMessages));
            listenerThread.Start();
        }

        private void ListenForMessages()
        {
            while (true)
            {
                byte[] message = new byte[4096];
                int bytesRead;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    break;
                }

                if (bytesRead == 0)
                    break;

                string receivedMessage = Encoding.ASCII.GetString(message, 0, bytesRead);
                DisplayMessage("Server: " + receivedMessage);
            }
        }

        private void DisplayMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(DisplayMessage), message);
                return;
            }

            chatArea.AppendText(message + Environment.NewLine);
        }

        private void SendMessage(string message)
        {
            byte[] messageBytes = Encoding.ASCII.GetBytes(message);
            clientStream.Write(messageBytes, 0, messageBytes.Length);
            DisplayMessage("You: " + message);
        }


        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string message = chatTxt.Text;
            SendMessage(message);
            chatTxt.Clear();
        }
    }
}
