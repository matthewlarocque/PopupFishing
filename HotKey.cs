using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PopupPersonalGain
{
    public class HotKey
    {
        [Flags()]
        public enum LosModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8,
            Mode_NoRpt = 0x4000
        }


        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, LosModifiers km, Keys vk);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    }
}
