using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RosWindows.RosMasterBaglanti
{
    public class IstemciSoketiPaketi
    {
        public Socket soketPaketi;

        public byte[] dataBuffer = new byte[1];
    }
}
