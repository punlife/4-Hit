using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;

namespace _4_Hit
{
    static class FontLoader
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        static FontFamily ff;
        private static PrivateFontCollection fonts = new PrivateFontCollection();

        public static void loadFont()
        {
            byte[] fontData = Properties.Resources.kenpixel;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.kenpixel.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.kenpixel.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            ff = fonts.Families[0];

        }
        public static void assignFont(Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new Font(ff, size, fontStyle);
        }
    }
}
