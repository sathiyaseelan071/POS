using System;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VegetableBox
{
    internal class PrintGlobal : Form
    {
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter(string szPrinter, out IntPtr hPrinter, PRINTER_DEFAULTS pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, int level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFO di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFO
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }

        public class PRINTER_DEFAULTS
        {
            public int pDatatype;
            public int pDevMode;
            public int DesiredAccess;
        }

        private const int PRINTER_ACCESS_USE = 0x00000008;

        public bool SendFileToPrinter(string printerName, string filePath)
        {
            IntPtr printerHandle;
            PRINTER_DEFAULTS printerDefaults = new PRINTER_DEFAULTS();
            printerDefaults.DesiredAccess = PRINTER_ACCESS_USE;

            if (OpenPrinter(printerName, out printerHandle, printerDefaults))
            {
                IntPtr fileHandle = new IntPtr(0);
                DOCINFO docInfo = new DOCINFO();
                docInfo.pDocName = "Print Document";
                docInfo.pDataType = "RAW";

                if (StartDocPrinter(printerHandle, 1, docInfo))
                {
                    if (StartPagePrinter(printerHandle))
                    {
                        int bytesWritten;
                        IntPtr p = Marshal.StringToCoTaskMemAnsi(filePath);
                        WritePrinter(printerHandle, p, (int)filePath.Length, out bytesWritten);
                        Marshal.FreeCoTaskMem(p);
                        EndPagePrinter(printerHandle);
                    }
                    EndDocPrinter(printerHandle);
                }
                ClosePrinter(printerHandle);
            }

            return true;
        }
    }


}
