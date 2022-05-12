using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using CloudDriveBackgroudServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CloudDriveBackgroudServer
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _configuration;
        public Worker(ILogger<Worker> logger,IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            Console.WriteLine(_configuration.GetValue<string>("ConnectionStrings:CloudDrive"));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                ClientRequest request;
                IPHostEntry host = Dns.GetHostEntry("localhost");
                IPAddress ipAddress = host.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);
                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                listener.Bind(localEndPoint);
                listener.Listen(10);
                Socket handler;
                while (true)
                {
                    try
                    {
                        handler = listener.Accept();

                        string data = null;
                        byte[] bytes = null;

                        while (true)
                        {
                            bytes = new byte[1024];
                            int bytesRec = handler.Receive(bytes);
                            data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                            Console.WriteLine(data);
                            if (data.IndexOf("<EOF>") > -1)
                            {
                                break;
                            }
                        }
                        data = data.Substring(0, data.Length - 5);
                        request = JsonSerializer.Deserialize<ClientRequest>(data);
                        Console.WriteLine(request.Request);
                        Console.WriteLine(request.Email);
                        Console.WriteLine(request.Password);

                        switch (data)
                        {
                            case "Register":
                                break;
                            case "Synchronize":
                                break;
                            case "Insert changes":
                                break;
                            case "Get Versions of file":
                                break;
                            case "Get List of files":
                                break;
                            case "Get File from Version":
                                break;
                            case "Insert Localization of file":
                                break;
                        }
                        Console.WriteLine("Text received : {0}", data);
                        byte[] msg = Encoding.ASCII.GetBytes(data);
                        handler.Send(msg);
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
        }
    }
}
