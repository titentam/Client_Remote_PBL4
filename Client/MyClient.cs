using ControlCustom;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class MyClient
    {
        private TcpClient client;
        private NetworkStream stream;
        private BinaryReader reader;
        private BinaryWriter writer;
        private int port;
        
        private string ipServer;
        private HookKeyBoard hook;
       
        public bool isConnected { get => client.Connected;}

        public MyClient(string ipServer, int port)
        {
            this.ipServer = ipServer;
            this.port = port;
           
        }

        public void Connect()
        {   
            client = new TcpClient();
            client.Connect(ipServer, port);
            stream = client.GetStream();
            reader = new BinaryReader(stream);
            writer = new BinaryWriter(stream);

            hook = HookKeyBoard.getInstance(stream, writer);
            
        }
        public bool SendPass(string pass)
        {
            writer.Write(pass);
            return reader.ReadBoolean();
        }

        public void ReceiveScreenDesktop(ref PictureBox screen)
        {
            while (client.Connected)
            {
                int length = reader.ReadInt32();

                byte[] bitmapByte = reader.ReadBytes(length);
                

                var bitmap = DataHelper.ByteArrayToBitmap(bitmapByte);
                screen.Image = bitmap;
            }
        }

        public void SendMouseMove(double scaleX, double scaleY)
        {
            writer.Write((byte)ControlCustom.ClientMessage.MOUSE_MOVE);
            writer.Write(scaleX);
            writer.Write(scaleY);
            stream.Flush();
        }
        public void SendMouseScroll(int scrollValue)
        {
            writer.Write((byte)ControlCustom.ClientMessage.MOUSE_SCROLL);
            writer.Write(scrollValue);
            stream.Flush();
        }
        public void SendMouseDown(double scaleX, double scaleY, MouseButtons btn = MouseButtons.Left)
        {
            byte type;
            if (btn == MouseButtons.Left)
            {
                type = (byte)ControlCustom.ClientMessage.MOUSE_LEFT_DOWN;
            }
            else
            {
                type = (byte)ControlCustom.ClientMessage.MOUSE_RIGHT_DOWN;
            }

            writer.Write(type);
            writer.Write(scaleX);
            writer.Write(scaleY);
            stream.Flush();
        }
        public void SendMouseUp(double scaleX, double scaleY, MouseButtons btn = MouseButtons.Left)
        {

            byte type;
            if (btn == MouseButtons.Left)
            {
                type = (byte)ControlCustom.ClientMessage.MOUSE_LEFT_UP;
            }
            else
            {
                type = (byte)ControlCustom.ClientMessage.MOUSE_RIGHT_UP;
            }
            writer.Write(type);
            writer.Write(scaleX);
            writer.Write(scaleY);
            stream.Flush();
        }
        
        public void SetHook()
        {
            hook.SetHook();
        }
        public void UnHook()
        {
            if (HookKeyBoard._hookID != IntPtr.Zero)
            {
                HookKeyBoard.UnhookWindowsHookEx(HookKeyBoard._hookID);
            }
        }


    }
}
