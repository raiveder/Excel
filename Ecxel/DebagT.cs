using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecxel
{
    class DebagT
    {
        /// <summary>
        /// Запись строки в файл Diagnostic
        /// </summary>
        /// <param name="s">Строка для записи в файл</param>
        public static void diagWrite(string s)
        {
            TextWriterTraceListener tr = new TextWriterTraceListener(File.AppendText("text.txt"));
            Trace.Listeners.Add(tr);
            Debug.WriteLine(s);
            Debug.Flush();
            tr.Close();
        }
    }
}
