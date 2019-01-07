using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;


namespace PingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ipAddress.Text=GetLocalIPAddress();
            subnetMask.Text = GetSubnetMask();
            defaultGateway.Text = GetGateway();
            dnsName.Text = getDNS();
            checkStatus();
            Console.Write( System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName);


        }




        public void checkStatus()
        {

            


           
            if (pingHost(defaultGateway.Text) && (pingHost("8.8.8.8")|| getDNS() == "mw.na.cat.com"))
            {
                status.Text = "Connected to the Internet";
            }
            else if (pingHost(defaultGateway.Text))
            {
                status.Text = "Connected to Gateway \nNo connection to Internet";
            }
        }





        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                button1.PerformClick();
            }
        }

        public string getText()
        {
            return textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Thinking";
            string ipAddress = getText();
            
            string truth = "false";
            pingHost(ipAddress);

            if(pingHost(ipAddress)==true)
            {
                truth = "true";
            }


            label2.Text= truth;
        }

        public static bool pingHost(string ipaddress)
        {
            
        
            bool pingable = false;

            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(ipaddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch(PingException)
            {

            }
            finally
            {
                if(pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }


        public static string GetSubnetMask()
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                     
                            return unicastIPAddressInformation.IPv4Mask.ToString();
                        
                    }
                }
            }

                    return "255.255.255.255";
        }






        public static string GetGateway()
        {
            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
                if (f.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (GatewayIPAddressInformation d in f.GetIPProperties().GatewayAddresses)
                    {
                        return d.Address.ToString();
                    }
                }
                else
                {
                    return "0.0.0.0";
                }
            return "Error";
         }




        public static string getDNS()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)

            {

                IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();

                return ipProperties.DnsSuffix.ToString();


            }

            return "name";
        }


 
    }
}
