using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class HookKeyBoard
    {
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        public static IntPtr _hookID = IntPtr.Zero;
        private NetworkStream stream;
        private BinaryWriter writer;

        private static HookKeyBoard hook;

        private HookKeyBoard(NetworkStream stream, BinaryWriter writer)
        {
            this.stream = stream;
            this.writer = writer;
        }
        public static HookKeyBoard getInstance(NetworkStream stream, BinaryWriter writer)
        {
            if (Hook == null)
            {
                Hook = new HookKeyBoard(stream, writer);
            }
            else
            {
                Hook.stream = stream;
                Hook.writer = writer;
            }
            return Hook;
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        public static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static LowLevelKeyboardProc _proc = HookCallback;

        public static HookKeyBoard Hook { get => hook; set => hook = value; }

        [StructLayout(LayoutKind.Sequential)]
        struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }

        // Đặt hook bàn phím cấp thấp
        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            _hookID = SetWindowsHookEx(13, _proc, hInstance, 0);
        }
        // Xử lý hook
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT kbd = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));
                if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    Console.WriteLine(kbd.key.ToString() + " Down");
                    SendKeyDown(kbd.key);

                }
                else if (wParam == (IntPtr)WM_KEYUP)
                {

                    Console.WriteLine(kbd.key.ToString() + " Up");
                    SendKeyUp(kbd.key);

                }
                else if (!IsAltKeyUp(kbd.flags) && kbd.key == Keys.Tab)
                {
                    Console.WriteLine("alt Down + tab");
                    SendKeyDown(Keys.LMenu);
                    SendKeyDown(Keys.Tab);
                }
                else if (!IsAltKeyUp(kbd.flags))
                {
                    Console.WriteLine("alt Down");
                    SendKeyDown(Keys.LMenu);
                }
                return (IntPtr)1; // Chặn sự kiện 
            }

            return CallNextHookEx(_hookID, nCode, (int)wParam, lParam);
        }

        // Kiểm tra xem phím Alt có được nhả hay không
        private static bool IsAltKeyUp(int flags)
        {
            return (flags & 0x20) == 0x20 && (flags & 0x80) == 0x80;
        }

        private static void SendKeyDown(Keys key)
        {
            byte type = (byte)ControlCustom.ClientMessage.KEY_DOWN;
            Hook.writer.Write(type);
            Hook.writer.Write((int)key);
            Hook.stream.Flush();
        }
        private static void SendKeyUp(Keys key)
        {
            byte type = (byte)ControlCustom.ClientMessage.KEY_UP;
            Hook.writer.Write(type);
            Hook.writer.Write((int)key);
            Hook.stream.Flush();

        }
    }
}
