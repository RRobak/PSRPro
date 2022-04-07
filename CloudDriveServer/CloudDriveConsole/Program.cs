using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudDriveConsole.CloudDriveServiceReference;
namespace CloudDriveConsole
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            CloudDriveServerClient client = new CloudDriveServerClient();
            while (true)
            {
                try
                {
                    Task<string> server=GetConnection(client);
                    string message = await server;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        public static async Task<string> GetConnection(CloudDriveServerClient client)
        { 
            return client.HandleMessage();
        }

    }
}
