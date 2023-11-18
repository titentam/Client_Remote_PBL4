using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form2 : Form
    {
        private MyClient client;
        public Form2(MyClient client)
        {
            InitializeComponent();
            this.client = client;

            this.KeyPreview = true;
            pictureBox1.MouseWheel += pictureBox1_MouseWheel;
            this.Activated += new EventHandler(Form_Activated);
            this.Deactivate += new EventHandler(Form_Deactivate);
            Thread t = new Thread(() =>
            {
                Start();
            });
            t.Start();
        }

        private void Start()
        {
            if (client.isConnected)
            {
                Thread screenThread = new Thread(() =>
                {
                    client.ReceiveScreenDesktop(ref pictureBox1);
                });

                screenThread.Start();
            }
        }

        private double[] GetScaleCursor(int x, int y)
        {
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            double scaleX = x * 1.0 / width * 1.0;
            double scaleY = y * 1.0 / height * 1.0;
            return new double[] { scaleX, scaleY };
        }

        private void MoveCursor()
        {

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var scale = GetScaleCursor(e.X, e.Y);

            client.SendMouseMove(scale[0], scale[1]);
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            client.SendMouseScroll(e.Delta);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Focus();
            MoveCursor();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var scale = GetScaleCursor(e.X, e.Y);
            client.SendMouseDown(scale[0], scale[1],e.Button);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var scale = GetScaleCursor(e.X, e.Y);
            client.SendMouseUp(scale[0], scale[1], e.Button);
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            // Đặt hook bàn phím khi Form được kích hoạt
            client.SetHook();
        }

        private void Form_Deactivate(object sender, EventArgs e)
        {
            // Gỡ bỏ hook bàn phím khi Form bị hủy kích hoạt
            client.UnHook();
        }


        private void micBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                client.SendVoice();
            });
            t.Start();
            MessageBox.Show("Dang noi");
        }

        private void loaBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                client.ReceiveVoice();
            });
            t.Start();
            MessageBox.Show("Dang nghe");
        }
    }

}
