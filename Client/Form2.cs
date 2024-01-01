using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Form2 : Form
    {
        private MyClient client;
        private bool isClosed;
        public event Action<string> MessageReceived;
        private TcpClient chatClient;
        private NetworkStream chatStream;
        private Thread listenerThread;
        private ChatForm chatForm;
        private bool isChatConnected;

        public Form2(MyClient client)
        {
            InitializeComponent();
            this.client = client;
            this.isClosed = false;

            this.KeyPreview = true;
            pictureBox1.MouseWheel += pictureBox1_MouseWheel;
            this.Activated += new EventHandler(Form_Activated);
            this.Deactivate += new EventHandler(Form_Deactivate);
            this.FormClosed += Form2_FormClosed;
            Thread t = new Thread(() =>
            {
                Start();
            });
            t.Start();
            // chat
            MessageReceived += OnMessageReceived;
            StartChat();
            isChatConnected = true;
            
        }
        private void StartChat()
        {
            try
            {
                chatClient = new TcpClient(client.ipServer, 6966);
                chatStream = chatClient.GetStream();
                listenerThread = new Thread(new ThreadStart(ListenForMessages));
                listenerThread.Start();
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ, ví dụ: hiển thị một thông báo lỗi
                MessageBox.Show("Lỗi trong cuộc trò chuyện: " + ex.Message);
            }
        }
        private void ListenForMessages()
        {
            while (isChatConnected)
            {
                 try
                {
                    byte[] message = new byte[4096];
                    int bytesRead;

                    try
                    {
                        bytesRead = chatStream.Read(message, 0, 4096);
                    }
                    catch
                    {
                        break;
                    }

                    if (bytesRead == 0)
                        break;

                    string receivedMessage = Encoding.ASCII.GetString(message, 0, bytesRead);
                    if (receivedMessage != null)
                    {
                        // Gọi sự kiện để thông báo về tin nhắn mới
                        MessageReceived?.Invoke(receivedMessage);
                    }
                    //DisplayMessage("Client: " + receivedMessage);


                }
                catch (Exception ex)
                {
                    isChatConnected=false;
                    if (chatClient.Connected)
                    {
                        chatClient.Close();
                    }
                    break;
                }
            }
        }
        private void OnMessageReceived(string message = null)
        {
            // Kiểm tra xem ChatForm đã được tạo chưa
            if (chatForm == null || chatForm.IsDisposed)
            {
                // Nếu chưa, tạo một instance mới của ChatForm trên luồng UI
                this.Invoke((MethodInvoker)delegate
                {
                    chatForm = new ChatForm(chatStream);
                    chatForm.Show();
                    if (message != null)
                    {
                        chatForm.DisplayMessage("Server: "+message);
                    }
                });
            }
            else
            {
                // Nếu đã tạo, thêm tin nhắn mới vào ChatForm hiện tại
                this.Invoke((MethodInvoker)delegate
                {
                    chatForm.DisplayMessage("Server: "+message);
                });
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
            client.UnHook();
            this.Dispose();
        }

        private void Start()
        {
            if (client.isConnected)
            {
                Thread screenThread = new Thread(() =>
                {
                    client.ReceiveScreenDesktop(ref pictureBox1, ref isClosed);
                    while (!isClosed)
                    {
                        Thread.Sleep(100); // Add a small delay to reduce CPU usage
                    }
                    try
                    {
                        this.Invoke(new Action(() =>
                        {
                            client.Close();
                            this.Dispose();
                        }));
                    }
                    catch (Exception)
                    {
                        // do something
                    }
                    
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


        private void loaBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                client.ReceiveVoice();
            });
            t.Start();
            MessageBox.Show("Dang nghe");
        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            OnMessageReceived();
            //ChatForm chatForm = new ChatForm(this.client.ipServer);
            //chatForm.ConnectToServer();
            //chatForm.Show();
        }

        private void swVoice_ValueChanged(object sender, bool value)
        {
            if (swVoice.Active)
            {
                client.VoiceRecorder();
            }
            else
            {
                client.VoiceStop();
            }
        }

        private void swSpeaker_ValueChanged(object sender, bool value)
        {
            if (swSpeaker.Active)
            {
                client.ReceiveVoice();
            }
            else
            {
                client.StopReceiveVoice();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }

}
