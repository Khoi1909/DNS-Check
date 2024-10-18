using System;
using System.Net;

namespace MyDNS
{
    class Program
    {
        static void Main(string[] args)
        {
            string domainName;

            if (args.Length > 0)
            {
                domainName = args[0];
            }
            else
            {
                Console.Write("Nhap ten mien đe tra cuu DNS: ");
                domainName = Console.ReadLine();
            }
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(domainName);
                Console.WriteLine($"Thong tin DNS cho ten mien: {domainName}");

                foreach (IPAddress ip in hostEntry.AddressList)
                {
                    Console.WriteLine($"Đia chi IP: {ip}");
                }

                foreach (string alias in hostEntry.Aliases)
                {
                    Console.WriteLine($"Alias: {alias}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi khi tra cuu DNS: {ex.Message}");
            }
        }
    }
}
