using System;
using System.Net;

namespace ddns
{
	class Program
	{
		static void Main(string[] args)
        {
            //string LastIPFilePath = Environment.GetEnvironmentVariable(nameof(LastIPFilePath));
            //string LogIPFilePath = Environment.GetEnvironmentVariable(nameof(LogIPFilePath));
            string RawIPSource = Environment.GetEnvironmentVariable(nameof(RawIPSource));
            string PddToken = Environment.GetEnvironmentVariable(nameof(PddToken));
            string Domain = Environment.GetEnvironmentVariable(nameof(Domain));
            string Subdomain = Environment.GetEnvironmentVariable(nameof(Subdomain));
            string RecordID = Environment.GetEnvironmentVariable(nameof(RecordID));
            string TTL = Environment.GetEnvironmentVariable(nameof(TTL));

            using WebClient client = new();
            string currentIp = client.DownloadString(RawIPSource);
            //File.AppendAllText(LogIPFilePath, currentIp + "\n");
            //if (File.ReadAllLines(LastIPFilePath).First() == currentIp) return;

            string editRequestUrl = $"https://pddimp.yandex.ru/api2/admin/dns/edit?domain={Domain}&record_id={RecordID}&subdomain={Subdomain}&ttl={TTL}&content={currentIp}";
            client.Headers.Add("PddToken", PddToken);
            if(!client.UploadString(editRequestUrl, "").Contains("\"success\"\": \"\"ok\"\"")) return;
            //File.WriteAllText(LastIPFilePath, currentIp);
        }
	}
}
