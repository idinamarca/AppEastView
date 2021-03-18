using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AppEastView
{
    public class Log
    {

        private static object locker = new Object();

        public static void EscribeLog(Exception ex)
        {
            try
            {
                lock (locker)
                {
                    var sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\logfile.txt", true);
                    sw.WriteLine(DateTime.Now + ": " + ex.Source.Trim() + "; " + ex.Message.Trim());
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception)
            {
                EscribeLog("Error al insertar Exception.");
            }
        }

        public static void EscribeLog(string msj)
        {
            try
            {
                lock (locker)
                {
                    var sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\logfile.txt", true);
                    sw.WriteLine(DateTime.Now + ": " + msj);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                EscribeLog("Exception." + ex.ToString());               
            }
        }

    }
}
