using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CloudDriveServer;
using System.ServiceModel.Description;

namespace CloudDriveServerHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzymy adres gdzie pod którym będzie dostępna usługa
            Uri baseAddress = new Uri("http://localhost:8733/CloudDriveServerService/");

            // Tworzymy obiekt klasy CalculatorService
            ServiceHost selfHost = new ServiceHost(typeof(CloudDriveServerService), baseAddress);

            try
            {
                // Dodajemy Endopoint usługi
                selfHost.AddServiceEndpoint(typeof(ICloudDriveServer), new WSHttpBinding(), "CalculatorService");

                // Umożliwiamy wymianę metadanych
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Startujemy serwis
                selfHost.Open();
                Console.WriteLine("Serwis działa....");
                Console.WriteLine("Naciśnij <ENTER> by zakończyć.");
                Console.WriteLine();
                Console.ReadLine();

                // zamykamy serwis
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Przechwyciłem wyjątek: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}
