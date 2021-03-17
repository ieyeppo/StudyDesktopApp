using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalShopApp.Helper
{
    class Common
    {
        public static string ConnString = "Data Source=127.0.0.1;" +
                                            "Initial Catalog=bookrentalshop;" +
                                            "User ID=sa;" +
                                            "Password=123456789";
        public static string LoginId = string.Empty;

        /// <summary>
        /// IP 주소 받아오는 메서드
        /// </summary>
        /// <returns></returns>
        internal static string GetLocalIp()
        {
            string localIP = "";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }

            return localIP;
        }
    }
}
