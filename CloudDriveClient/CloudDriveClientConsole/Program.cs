using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudDriveClientConsole.CloudDriveClientReference;
namespace CloudDriveClientConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CloudDriveClientServiceClient client = new CloudDriveClientServiceClient();
            string message;
            Console.WriteLine("Podaj wiadmosc");
            message=Console.ReadLine();
            message=client.SendMessage(message);
            Console.WriteLine(message);
        }
    }
}
