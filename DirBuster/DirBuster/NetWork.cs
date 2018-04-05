using System;
using System.Net;

namespace DirBuster.DirBuster
{
    public class TimedWebClient : WebClient
    {
        public int Timeout { get; set; }
        public TimedWebClient()
        {
            this.Timeout = 600000;
        }
        protected override WebRequest GetWebRequest(Uri address)
        {
            var objWebRequest = base.GetWebRequest(address);
            objWebRequest.Timeout = this.Timeout;
            return objWebRequest;
        }
    }

    class NetWork
    {
        public string Get_Html(string url)
        {
            try
            {
                WebClient Client = new WebClient();
                return Client.DownloadString(url);
            }catch
            {
                return string.Empty;
            }
        }
        public bool Address_Check(string url,bool Result)
        {
            try
            {
                TimedWebClient client = new TimedWebClient();
                client.Timeout = 800;
                if(Result == true)
                {
                    if(client.DownloadString(url).Length >= 10 && client.DownloadString(url).IndexOf("ZendGuard") == -1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }else
                {
                    if (client.DownloadString(url) != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
