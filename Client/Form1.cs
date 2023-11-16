using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private MyClient client;
        public Form1()
        {
            InitializeComponent();
            InitTemp();

        }

        private void InitTemp()
        {
            iptext.Text = "192.168.249.96";
            //iptext.Text = "127.0.0.1";
            passtext.Text = "1234";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void uiSymbolLabel2_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            // captchaText.Text.Equals(uiVerificationCode1.Code)
            if (true)
            {
                MessageBox.Show(passtext.Text);
                
                if(client==null) 
                {
                    client = new MyClient(iptext.Text, 5910);
                    client.Connect();   
                }
                

                if (client.SendPass(passtext.Text))
                {
                    Form2 f2 = new Form2(client);
                    f2.ShowDialog();
                    ConnectBtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                }

            }
            else
            {
                MessageBox.Show("Wrong Captchar. Please try again!!!");
            }
        }
    }
}
