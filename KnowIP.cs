//Finding IP address of a machine

using System;
using System.Net;

    class KnowIP
    {
public static void Main()
{
string host;

//Enter any host name like www.bing.com
Console.Write("Enter host name :");
host=Console.ReadLine();      

            try
            {
           //IPHostEntry hostname = Dns.GetHostByName(host);
	     IPHostEntry hostname = Dns.GetHostEntry(host);
             IPAddress[] ip = hostname.AddressList;
             Console.WriteLine(ip[0].ToString()); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }


//content of sohamglobal.com