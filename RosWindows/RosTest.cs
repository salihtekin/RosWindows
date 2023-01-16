using RosWindows.ProsesBaslat;
using RosWindows.RosMasterBaglanti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosWindows
{
    public partial class RosTest : Form
    {
        public RosTest()
        {
            InitializeComponent();
        }
        private void RosTest_Load(object sender, EventArgs e)
        {
            RosExeBaslat.RosCoreBaslat();
        }
        private void BaglantiButonu_Click(object sender, EventArgs e)
        {
            rosMasterIP_TextBox.Text = "127.0.0.1";
            rosMasterHost_TextBox.Text = "11311";
            RosMasterHaberlesme baglanti = new RosMasterHaberlesme(rosMasterIP_TextBox.Text, rosMasterHost_TextBox.Text);
            if (baglanti.baglantiKontrol == true)
            {
                baglantiSonucu_TextBox.Text = "Bağlantı sağlandı.";
            }
            else 
            {
                baglantiSonucu_TextBox.Text = "Uygunsuz bağlantı.";

            }

            RosExeBaslat.GazeboBaslat();
        }

        private void rosMasterIP_TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
