using RosWindows.RosMasterBaglanti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void BaglantiButonu_Click(object sender, EventArgs e)
        {
            RosMasterHaberlesme baglanti = new RosMasterHaberlesme(rosMasterIP_TextBox.Text, rosMasterHost_TextBox.Text);

            if (baglanti.baglantiKontrol == true)
            {
                baglantiSonucu_TextBox.Text = "Bağlantı sağlandı.";
            }
            else 
            {
                baglantiSonucu_TextBox.Text = "Uygunsuz bağlantı.";

            }
        }
    }
}
