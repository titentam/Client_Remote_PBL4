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
        private static ChatForm instance;

        public delegate void SendMessageDelegate(string message);
        public SendMessageDelegate SendMessage;


        public static ChatForm Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChatForm();
                return instance;
            }
        }

        private ChatForm()
        {
            InitializeComponent();
        }

        public void AppendMessage(string message)
        {
            chatArea.AppendText("Server: "+ message+"\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage(chatTxt.Text);
            chatTxt.Clear();
        }
    }
}
