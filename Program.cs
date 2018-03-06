using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace ConsoleApplication7
{
    class Program
    {
        static void LayIP()
        {
            String strHostName = Dns.GetHostName();
            Console.WriteLine("Host Name: " + strHostName);
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
            for (int i = 0; i < iphostentry.AddressList.Length; i++)
            {
                Console.WriteLine(iphostentry.AddressList[i]);
            }
        }
        static void nslookupip(string a)
        {
            IPHostEntry entry = Dns.Resolve(a);
            Console.WriteLine(entry.HostName);
            Console.WriteLine(entry.AddressList[0]);
        }
        
        static void Main(string[] args)
        {
            
        }
    }
}
