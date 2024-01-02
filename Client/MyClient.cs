using ControlCustom;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
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
        private VoiceIn voiceIn;
        private VoiceOut voiceOut;
        private string ipServer;
        private HookKeyBoard hook;
        private bool isListening; // voice chat from server
        public ChatForm chatForm;


        public Action ShowChatForm;
        public bool isConnected { get => client.Connected;}

        public MyClient(string ipServer, int port)
        {
            this.ipServer = ipServer;
            this.port = port;
            
            
        }

        public void InitChat()
        {
            chatForm = new ChatForm();
            chatForm.SendMessage += SendMessage;

            chatForm.Show();
            //chatForm.Visible = false;
        }
        public string GetIp()
        {
            return this.ipServer;
        }
        public void Close()
        {
            if(client != null)
            {
                client.Close();
            }
            if(voiceIn != null)
            {
                voiceIn.Close();
            }
            if( voiceOut != null )
            {
                voiceOut.Close();
            }
            if(chatForm != null)
            {
                chatForm.Dispose();
            }
        }

        public void Connect()
        {   
            client = new TcpClient();
            client.Connect(ipServer, port);
            stream = client.GetStream();
            reader = new BinaryReader(stream);
            writer = new BinaryWriter(stream);
            //InitVoice();


            //InitChat();
            hook = HookKeyBoard.getInstance(stream, writer);
        }

        private void InitVoice()
        {
         
            voiceIn = new VoiceIn(ipServer, 6969);
            voiceOut = new VoiceOut(voiceIn.GetWaveFormat(), 6969);

        }

        public void ReceiveVoice()
        {
            voiceOut.Play();
            isListening = true;
            Thread t = new Thread(() =>
            {
                while (isListening)
                {
                    voiceOut.ReceiveData();
                }
            });
            t.Start();
            
        }
        public void StopReceiveVoice()
        {
            isListening = false;
            voiceOut.Stop();
        }

        public void VoiceRecorder()
        {
            Thread t = new Thread(() =>
            {
                voiceIn.StartRecording();
            });
            t.Start();
        }
        public void VoiceStop()
        {
            voiceIn.StopRecording();
        }
        public bool SendPass(string pass)
        {
            if(isConnected)
            {
                try
                {
                    writer.Write(pass);
                    return reader.ReadBoolean();
                }
                catch (Exception ex)
                {
                    return false;
                }
                
            }
            return false;
        }

        public void ReceiveScreenDesktop(ref PictureBox screen, ref bool isClosed)
        {
            while (client.Connected)
            {
                try
                {
                    byte type = reader.ReadByte();
                    if(type == 0) // screen
                    {
                        int length = reader.ReadInt32();

                        byte[] bitmapByte = reader.ReadBytes(length);


                        var bitmap = DataHelper.ByteArrayToBitmap(bitmapByte);
                        screen.Image = bitmap;
                    }
                    if(type == 1) // chat
                    {
                        
                        if (chatForm == null || chatForm.IsDisposed)
                        {
                            ShowChatForm.Invoke();
                        }

                        string message = reader.ReadString();
                        chatForm.DisplayMessage("Server: " + message);
                    }
                    
                }
                catch (IOException ex) 
                {
                    MessageBox.Show("Disconnected!");
                    isClosed = true;
                    break;
                }
                
            }
        }


        public void SendMessage(string message)
        {
            if (isConnected)
            {
                writer.Write((byte)ControlCustom.ClientMessage.MESSAGE);
                writer.Write(message);
                stream.Flush();
            }
            
        }
       
        public void SendMouseMove(double scaleX, double scaleY)
        {
            if (isConnected)
            {
                try
                {
                    writer.Write((byte)ControlCustom.ClientMessage.MOUSE_MOVE);
                    writer.Write(scaleX);
                    writer.Write(scaleY);
                    stream.Flush();
                }
                catch(Exception ex)
                {
                    return;
                }
                
            }
           
        }
        public void SendMouseScroll(int scrollValue)
        {
            if (isConnected)
            {
                try
                {
                    writer.Write((byte)ControlCustom.ClientMessage.MOUSE_SCROLL);
                    writer.Write(scrollValue);
                    stream.Flush();
                }
                catch (Exception ex)
                {
                    return;
                }
                
            }
            
        }
        public void SendMouseDown(double scaleX, double scaleY, MouseButtons btn = MouseButtons.Left)
        {
            if (isConnected)
            {
                try
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
                catch( Exception ex)
                {
                    return;
                }
                
            }
            
        }
        public void SendMouseUp(double scaleX, double scaleY, MouseButtons btn = MouseButtons.Left)
        {
            if(isConnected)
            {
                try
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
                catch (Exception)
                {

                    return;
                }
                
            }
            
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
