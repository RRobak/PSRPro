using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CloudDriveClient
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class CloudDriveClientService : ICloudDriveClientService
    {
        private Socket socket;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public string SendMessage(string message)
        {

            try
            {
                Byte[] odebraneBajty = new Byte[100];
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress hostadd = IPAddress.Parse("127.0.0.1");
                int port = 9999;
                IPEndPoint EPhost = new IPEndPoint(hostadd, port);
                socket.Connect(EPhost);
                Byte[] byteData = Encoding.ASCII.GetBytes(message.ToCharArray());
                socket.Send(byteData, byteData.Length, 0);

                int ret = socket.Receive(odebraneBajty, odebraneBajty.Length, 0);
                return System.Text.Encoding.ASCII.GetString(odebraneBajty);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
    }
}
