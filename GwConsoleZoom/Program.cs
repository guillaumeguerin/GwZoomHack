using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;

namespace GwConsoleZoom
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var m = new MemorySharp(ApplicationFinder.FromProcessName("Gw").First()))
            {
                m.Assembly.Inject("NOP", new IntPtr(0x0045D4BB));
                m.Assembly.Inject("NOP", new IntPtr(0x0045D4BC));
                m.Assembly.Inject("NOP", new IntPtr(0x0045D4BD));

                m.Assembly.Inject("NOP", new IntPtr(0x0045BE87));
                m.Assembly.Inject("NOP", new IntPtr(0x0045BE88));
                m.Assembly.Inject("NOP", new IntPtr(0x0045BE89));

                m.Assembly.Inject("NOP", new IntPtr(0x0045BEBB));
                m.Assembly.Inject("NOP", new IntPtr(0x0045BEBC));
                m.Assembly.Inject("NOP", new IntPtr(0x0045BEBD));
            }
        }

    }
}
