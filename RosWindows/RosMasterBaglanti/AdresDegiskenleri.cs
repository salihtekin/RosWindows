using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosWindows.RosMasterBaglanti
{
    public class AdresDegiskenleri
    {
        /// <summary>
        /// RosCore çalıştırıldıktan sonra rosmaster'ın ıp adresi alınmaktadır.
        /// </summary>
        public string masterIPAdresi { get; set; }//textBoxIP.Text

        /// <summary>
        /// RosCore çalıştırıldıktan sonra rosmaster'ın masterPortAdresi adresi alınmaktadır.
        /// </summary>
        public string masterPortAdresi { get; set; }

    }
}
