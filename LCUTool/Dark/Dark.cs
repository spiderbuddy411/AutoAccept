using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 ClassciDarkTheme coded by Lufzys https://github.com/Lufzys
 */

namespace ClassicDarkTheme.Dark
{
    class Dark
    {
        public static Color DefaultButtonBackColor = Color.FromArgb(33, 33, 39);
        public static Color DefaultButtonHover = Color.FromArgb(39, 39, 46);
        public static Color DefaultButtonDown = Color.FromArgb(22, 22, 26);
        public static Color DefaultTextboxBackColor = Color.FromArgb(29, 30, 33);
        public static Color DefaultButtonBorderColor = Color.FromArgb(47, 47, 53);
        public static Color DefaultBorderColor = Color.FromArgb(100, 100, 100);
        public enum MouseEvent
        {
            Down,
            Up,
            Hover,
            Leave
        }

        public static async void Sleep(double msec)
        {
            for (var since = DateTime.Now; (DateTime.Now - since).TotalMilliseconds < msec;)
                await Task.Delay(TimeSpan.FromTicks(10));
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private static PrivateFontCollection fonts = new PrivateFontCollection();
        public static FontFamily fontFamily;

        public static void LoadFont()
        {
            byte[] fontData = LCUTool.Properties.Resources.Roboto_Medium;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, LCUTool.Properties.Resources.Roboto_Medium.Length);
            AddFontMemResourceEx(fontPtr, (uint)LCUTool.Properties.Resources.Roboto_Medium.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            fontFamily = fonts.Families[0];
        }
    }
}
