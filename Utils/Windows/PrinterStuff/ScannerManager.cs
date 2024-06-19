using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Utils.Windows.PrinterStuff {
    public class ScannerManager {
        const int SCANNER_MIN_X = 0;
        const int SCANNER_MIN_Y = 0;
        const int SCANNER_MAX_X = 850; // Adjust this according to your scanner's maximum X dimension in thousandths of an inch
        const int SCANNER_MAX_Y = 1100; // Adjust this according to your scanner's maximum Y dimension in thousandths of an inch
        const int SCANNER_DPI_X = 300;
        const int SCANNER_DPI_Y = 300;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int DeleteDC(IntPtr hdc);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern int DeleteObject(IntPtr hObject);

        public void ScanImage(string outputPath) {
            IntPtr desktopWindowHandle = GetDesktopWindow();
            IntPtr desktopDeviceContext = GetDC(desktopWindowHandle);
            IntPtr compatibleDeviceContext = CreateCompatibleDC(desktopDeviceContext);

            int width = (int)((SCANNER_MAX_X - SCANNER_MIN_X) * SCANNER_DPI_X / 1000.0);
            int height = (int)((SCANNER_MAX_Y - SCANNER_MIN_Y) * SCANNER_DPI_Y / 1000.0);

            IntPtr compatibleBitmap = CreateCompatibleBitmap(desktopDeviceContext, width, height);
            IntPtr oldBitmap = SelectObject(compatibleDeviceContext, compatibleBitmap);

            // Get the scanned image
            BitBlt(compatibleDeviceContext, 0, 0, width, height, desktopDeviceContext, SCANNER_MIN_X, SCANNER_MIN_Y, (int)CopyPixelOperation.SourceCopy);

            // Create Bitmap from compatible bitmap
            Bitmap bitmap = System.Drawing.Image.FromHbitmap(compatibleBitmap);

            // Save the scanned image
            string fileName = $"scanned_image_{DateTime.Now:yyyyMMddHHmmss}.png";
            string filePath = System.IO.Path.Combine(outputPath, fileName);
            bitmap.Save(filePath, ImageFormat.Png);

            // Cleanup
            SelectObject(compatibleDeviceContext, oldBitmap);
            DeleteObject(compatibleBitmap);
            DeleteDC(compatibleDeviceContext);
            ReleaseDC(desktopWindowHandle, desktopDeviceContext);

            Logger.LogInfo($"Scanned image saved: {filePath}");
        }
    }
}
