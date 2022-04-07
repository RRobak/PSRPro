using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudDriveServerForm.CloudDriveServiceReference;
namespace CloudDriveServerForm
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
       /* [STAThread]*/
        static void Main()
        {
            CloudDriveServerClient client = new CloudDriveServerClient();
            client.HandleMessage();
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
        }
    }
}
