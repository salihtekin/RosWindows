using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosWindows.RosPublisher
{
    public class RosPublish
    {
        private Socket istemciSoketi;

        /// <summary>
        /// 
        /// Örnek topic      => ' string topic = "/turtle1/command_velocity"; '
        /// 
        /// Örnek mesajTipi  => ' string msgtype = "turtlesim/Velocity"; '
        /// 
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="mesajTipi"></param>
        /// <param name="gonderilenMsg"></param>
        private void Publish(string topic, string mesajTipi, object[] gonderilenMsg ) 
        {
            try
            {      
                // gönderilenmsg =>' RosBridgeDotNet.RosBridgeDotNet.TurtleSim turtleGo1  = new RosBridgeDotNet.RosBridgeDotNet.TurtleSim(linear, angular); ' şeklinde tanımlanarak
                // içeriye gönderilebilir.Bu ros turtlebotuna komut göndermek için hazır olarak tanımlanmış değişkenleri barındırmaktadır 

                RosBridgeDotNet.RosBridgeDotNet.PublishMessage mesaj = new RosBridgeDotNet.RosBridgeDotNet.PublishMessage(topic, mesajTipi, gonderilenMsg);

                string sonMesaj = JsonConvert.SerializeObject(mesaj);
                
                if (istemciSoketi != null)
                {
                    istemciSoketi.Send(new byte[] { 0 });    // \x00
                    istemciSoketi.Send(Encoding.UTF8.GetBytes(sonMesaj));
                    istemciSoketi.Send(new byte[] { 255 });    // \xff
                }
            }
            catch (SocketException hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
