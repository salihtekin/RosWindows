
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RosWindows.RosMasterBaglanti
{
    public class RosMasterHaberlesme
    {
        public AdresDegiskenleri adresler;
        public Socket istemciSoketi;
        public AsyncCallback asenkronGeriCagirma;
        public bool baglantiKontrol;
        IAsyncResult mesajSonucu;

        public RosMasterHaberlesme(string masterIPAdresi, string masterPortAdresi)
        {
            adresler = new AdresDegiskenleri();

            adresler.masterIPAdresi = masterIPAdresi;
            adresler.masterPortAdresi = masterPortAdresi;

            this.BaglantiMetodu();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BaglantiMetodu()
        {
            try
            {
                //UpdateControls(false);

                this.baglantiKontrol               = false;
                this.istemciSoketi                 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress masterIPAdresiParse      = IPAddress.Parse(adresler.masterIPAdresi);
                int portNumarasi                   = Convert.ToInt16(adresler.masterPortAdresi);
                IPEndPoint masterIPAdresiParseSon  = new IPEndPoint(masterIPAdresiParse, portNumarasi); // Bitiş noktası oluşturulur

                istemciSoketi.Connect(masterIPAdresiParseSon); // Uzak ana bilgisayara bağlanma sağlar.

                if (istemciSoketi.Connected)
                {
                    baglantiKontrol = true;
                    //UpdateControls(true);
                    //Wait for data asynchronously 
                    VeriBekleme();
                }

                istemciSoketi.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                byte[] veriAdresi = Encoding.UTF8.GetBytes("raw\r\n\r\n");
                istemciSoketi.Send(veriAdresi);
            }
            catch (SocketException hataMesaji)
            {
                string baglanmaBildirimi;
                baglanmaBildirimi = "\nBağlantı başarısız.Sunucunun çalışıp çalışmadığı kontrol edilmeli.\n" + hataMesaji.Message;
                MessageBox.Show(baglanmaBildirimi);
                baglantiKontrol = false;
                //UpdateControls(false);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void VeriBekleme()
        {
            try
            {
                if (asenkronGeriCagirma == null)
                {
                    asenkronGeriCagirma = new AsyncCallback(VeriAlimiSonrasi);
                }
                IstemciSoketiPaketi istemciSoketiPaketi = new IstemciSoketiPaketi();
                istemciSoketiPaketi.soketPaketi = istemciSoketi;

                // Start listening to the data asynchronously
                mesajSonucu = istemciSoketi.BeginReceive(istemciSoketiPaketi.dataBuffer,
                                                         0, istemciSoketiPaketi.dataBuffer.Length,
                                                         SocketFlags.None,
                                                         asenkronGeriCagirma,
                                                         istemciSoketiPaketi);
            }

            catch (SocketException baglantiHatasi)
            {
                MessageBox.Show(baglantiHatasi.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="asenkronAlıcı"></param>
        public void VeriAlimiSonrasi(IAsyncResult asenkronAlıcı)
        {
            try
            {
                IstemciSoketiPaketi soketID = (IstemciSoketiPaketi)asenkronAlıcı.AsyncState;
                int alinanDeger = soketID.soketPaketi.EndReceive(asenkronAlıcı);
                char[] chars = new char[alinanDeger + 1];
                Decoder UTF8decod = Encoding.UTF8.GetDecoder();
                int masterIDDecod = UTF8decod.GetChars(soketID.dataBuffer, 0, alinanDeger, chars, 0);
                String serializeVeri = new String(chars);
                try
                {
                    serializeVeri = Regex.Replace(serializeVeri, @"[^\u0000-\u007F]", string.Empty);
                    System.Diagnostics.Debug.WriteLine(serializeVeri.ToString());
                    //richTextRxMessage.Text = richTextRxMessage.Text + szData[2];
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                VeriBekleme();
            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1", "\nVeriAlimiSonrasi: Bağlantı sonucu arabirim kapatıldı.\n");
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }
    }
}
