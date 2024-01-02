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
        
        public ChatForm()
        {
            InitializeComponent();
            
            
        }

        public Action<string> SendMessage;
        public void DisplayMessage(string message)
        {
            
            if (chatArea.IsHandleCreated)
            {
                chatArea.Invoke(new Action(() =>
                {
                    chatArea.AppendText(message + "\n");
                }));
            }
            else
            {
                MessageBox.Show(message);
            }
            
        }
    
        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = chatTxt.Text;
            DisplayMessage("Me: "+ message);
            SendMessage.Invoke(message); // send to server
            chatTxt.Clear();
        }
    }
}
