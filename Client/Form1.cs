﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
            uiComboBox1.SelectedIndex=1;
            InitTemp();

        }

        private void InitTemp()
        {
            iptext.Text = "192.168.249.96";
            //iptext.Text = "127.0.0.1";
            passtext.Text = "1234";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            // 
            if (captchaText.Text.Equals(uiVerificationCode1.Code)||true)
            {
                //MessageBox.Show(passtext.Text);
                
                if(client==null) 
                {
                    try
                    {
                        client = new MyClient(iptext.Text, 5910);
                        client.Connect();
                    }
                    catch (SocketException)
                    {
                        client=null;
                        MessageBox.Show("Server not exist");
                    }
                   
                }

                if (client != null)
                {
                    if (client.SendPass(passtext.Text))
                    {
                        Form2 f2 = new Form2(client);
                        ConnectBtn.Enabled = false;
                        f2.ShowDialog();
                        client = null;
                        ConnectBtn.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Wrong Captchar. Please try again!!!");
            }
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = uiComboBox1.SelectedItem.ToString();

            // Check the selected value and set TextBox text accordingly
            if (selectedValue.Equals("English"))
            {
                ipLabel.Text= "Partner's IP";
                passLabel.Text="Password";
                ConnectBtn.Text="Start Controlling";
                uiLabel1.Text="Remote Desktop Controller App";

            }
            else if (selectedValue.Equals("Tiếng Việt"))
            {
                ipLabel.Text= "IP Đối Tác";
                passLabel.Text="Mật Khẩu";
                ConnectBtn.Text="Bắt đầu điều khiển";
                uiLabel1.Text="Ứng Dụng Điều Khiển Máy Tính Từ Xa";
            }
        }
    }
}
