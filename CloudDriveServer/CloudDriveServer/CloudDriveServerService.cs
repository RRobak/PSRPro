using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CloudDriveServer
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class CloudDriveServerService : ICloudDriveServer
    {
        private static TcpListener tcpLsn;
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
        public string HandleMessage()
        {
            Console.WriteLine("Enter HandleMessage");
                try
                {
                    Console.WriteLine("Waiting for a connection...");
                    tcpLsn = new TcpListener(IPAddress.Any, 9999);
                    tcpLsn.Start();
                    Socket socket = tcpLsn.AcceptSocket();
                    Byte[] odebraneBajty = new Byte[100];
                    int ret = socket.Receive(odebraneBajty, odebraneBajty.Length, 0);
                    string tmp = null;
                    tmp = System.Text.Encoding.ASCII.GetString(odebraneBajty);
                    Console.WriteLine(tmp);

                    string wiadomosc = "Otrzymalem wiadmosc";
                    Byte[] byteData = Encoding.ASCII.GetBytes(wiadomosc.ToCharArray());
                    socket.Send(byteData, byteData.Length, 0);
                    socket.Close();
                    Console.WriteLine("Connection closed");
                return "SEND";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                return (ex.Message);  
            }
            
        }
    }
}
