using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosWindows.RosSubscriber
{
    internal class RosSubscribe
    {
        private Socket istemciSoketi;

        /// <summary>
        /// 
        /// {"aliciTopic":"/rosbridge/subscribe","mesajMsg":["/topic",-1]}
        /// 
        /// {"aliciTopic":"/rosjs/subscribe", "mesajMsg":["/turtle1/pose",-1]}
        /// 
        /// </summary>
        /// <param name="aliciTopic"></param>
        /// <param name="mesaj"></param>
        private void Subscribe(string aliciTopic,object[] mesajMsg)
        {
            RosBridgeDotNet.RosBridgeDotNet.SubscribeMessage rosSubscribeMsg;
            try
            {
                rosSubscribeMsg        = new RosBridgeDotNet.RosBridgeDotNet.SubscribeMessage(aliciTopic, mesajMsg);
                string mesajSerializ   = JsonConvert.SerializeObject(rosSubscribeMsg);

                if (istemciSoketi != null)
                {
                    istemciSoketi.Send(new byte[] { 0 });    // \x00
                    istemciSoketi.Send(Encoding.UTF8.GetBytes(mesajSerializ));
                    istemciSoketi.Send(new byte[] { 255 });    // \xff
                }
            }
            catch (SocketException hata)
            {
                MessageBox.Show(hata.Message);
            }

            //Update();
        }
    }
}
