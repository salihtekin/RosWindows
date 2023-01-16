using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosWindows.ProsesBaslat
{
    public static class RosExeBaslat
    {
        public static void RosCoreBaslat()
        {
            Process ros = new Process();
            ProcessStartInfo baglantiBilgi = new ProcessStartInfo();
            baglantiBilgi.FileName = "cmd.exe";
            baglantiBilgi.RedirectStandardInput = true;
            baglantiBilgi.UseShellExecute = false;

            ros.StartInfo = baglantiBilgi;
            ros.Start();

            using (StreamWriter girilecekKodlar = ros.StandardInput)
            {
                if (girilecekKodlar.BaseStream.CanWrite)
                {
                    girilecekKodlar.WriteLine("c:\\opt\\ros\\noetic\\x64\\setup.bat");
                    girilecekKodlar.WriteLine("roscore");
                }
            }
        }

        public static void GazeboBaslat()
        {
            Process ros = new Process();
            ProcessStartInfo baglantiBilgi = new ProcessStartInfo();
            baglantiBilgi.FileName = "cmd.exe";
            baglantiBilgi.RedirectStandardInput = true;
            baglantiBilgi.UseShellExecute = false;

            ros.StartInfo = baglantiBilgi;
            ros.Start();

            using (StreamWriter girilecekKodlar = ros.StandardInput)
            {
                if (girilecekKodlar.BaseStream.CanWrite)
                {
                    girilecekKodlar.WriteLine("c:\\opt\\ros\\noetic\\x64\\setup.bat");
                    girilecekKodlar.WriteLine("roslaunch gazebo_ros empty_world.launch");
                }
            }

        }
    }
}
