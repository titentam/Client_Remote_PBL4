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
            client = new MyClient("192.168.249.96",5910);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Connect();
            Form2 f2 = new Form2(client); 
            f2.ShowDialog();

        }
    }
}
