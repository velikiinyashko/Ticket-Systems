using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using SystemsLogic.Logs;

namespace SystemsLogic.Transports
{
    class Server
    {
        TcpListener Listener;
        IPAddress Address;
        int PortListener;
        EventLogs Logs = new EventLogs("Server");

        Server(string IpAddress, int Port)
        {
            this.Address = IPAddress.Parse(IpAddress);
            this.PortListener = Port;
            Listener = new TcpListener(Address, PortListener);
        }

        public void Start()
        {
            try
            {
                Listener.Start();
                while (true)
                {

                }
            }catch(Exception ex)
            {
                Logs.LogText = ex.Message;
                Logs.WrineEventLogError();
            }
        }
    }
}
