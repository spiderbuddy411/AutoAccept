using LCUAPI.API.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCUAPI.API
{
	class LCU
	{
		private static readonly string string_0 = "\"--remoting-auth-token=(?'token'.*?)\" | \"--app-port=(?'port'|.*?)\"";
		private static readonly RegexOptions regexOptions_0 = RegexOptions.Multiline;
		private static int port = 0;
		private static string token = string.Empty;
		private static string LastVersion = string.Empty;

		public static string GetRequest(RestSharp.Method method, string strrequest, object parameter = null, DataFormat dataFormat = DataFormat.None)
		{
			CheckUxLauncher();
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(NetClass.NewClass.Main));
			RestClient restClient = new RestClient("https://127.0.0.1:" + port)
			{
				Authenticator = new HttpBasicAuthenticator("riot", token)
			};
			RestRequest request = new RestRequest(strrequest, method);
			var result = restClient.Execute(request);
			if (method == Method.PUT && dataFormat == DataFormat.Json)
			{
				request.AddBody(parameter);
			}
			else if (method == Method.POST)
			{
				request.AddBody(parameter);
			}
			return result.Content;
		}

		public static string GetRequest(RestSharp.Method method, string strrequest, DataFormat dataFormat, object parameter = null)
		{
			CheckUxLauncher();
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(NetClass.NewClass.Main));
			RestClient restClient = new RestClient("https://127.0.0.1:" + port)
			{
				Authenticator = new HttpBasicAuthenticator("riot", token)
			};
			RestRequest request = new RestRequest(strrequest, method, dataFormat);
			if (method == Method.PUT && dataFormat == DataFormat.Json)
			{
				request.AddBody(parameter);
			}
			else if (method == Method.POST)
            {
				request.AddBody(parameter);
			}
			var result = restClient.Execute(request);
			return result.Content;
		}

		public static string GetRequestJson(RestSharp.Method method, string strrequest, object parameter = null)
		{
			CheckUxLauncher();
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(NetClass.NewClass.Main));
			RestClient restClient = new RestClient("https://127.0.0.1:" + port)
			{
				Authenticator = new HttpBasicAuthenticator("riot", token)
			};
			RestRequest request = new RestRequest(strrequest, method, DataFormat.Json);
			if (method == Method.PUT && DataFormat.Json == DataFormat.Json)
			{
				request.AddJsonBody(parameter);
			}
			else if (method == Method.POST)
			{
				request.AddJsonBody(parameter);
			}
			var result = restClient.Execute(request);
			return result.Content;
		}

		public static void CheckUxLauncher()
        {
			if(port == 0 && token == string.Empty)
            {
				ValueTuple<string, string> valueTuple = GetUxLauncher();
				token = valueTuple.Item1;					// token
				port = int.Parse(valueTuple.Item2);  // port
				string versionsJSON = new WebClient().DownloadString("https://ddragon.leagueoflegends.com/api/versions.json");
				Console.WriteLine(versionsJSON);
				versionsJSON = versionsJSON.Split(',')[0];
				versionsJSON = versionsJSON.Replace("[", "");
				versionsJSON = versionsJSON.Replace("\"", "");
				LastVersion = versionsJSON;
			}
        }

		private static bool showed = false;
		static ValueTuple<string, string> GetUxLauncher()
		{
			string text = "";
			string text2 = "";
			ManagementClass managementClass = new ManagementClass("Win32_Process");
			foreach (ManagementBaseObject managementBaseObject in managementClass.GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (managementObject["Name"].Equals("LeagueClientUx.exe"))
				{
					foreach (object obj in Regex.Matches(managementObject["CommandLine"].ToString(), string_0, regexOptions_0))
					{
						Match match = (Match)obj;
						if (!string.IsNullOrEmpty(match.Groups["port"].ToString()))
						{
							text2 = match.Groups["port"].ToString();
						}
						else if (!string.IsNullOrEmpty(match.Groups["token"].ToString()))
						{
							text = match.Groups["token"].ToString();
						}
					}
				}
			}
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
			{
				Console.WriteLine("LoL Client Not Found!");
				Environment.Exit(31);
			}
			return new ValueTuple<string, string>(text, text2);
		}

		public class NetClass
		{
			internal bool Main(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}

			public static readonly NetClass NewClass = new NetClass();
			static RemoteCertificateValidationCallback callback;
		}

		// other

		public static void UxKill()
		{
			string ux = API.LCU.GetRequest(RestSharp.Method.POST, "/riotclient/kill-ux");
		}

		public static void UxLaunch()
		{
			string ux = API.LCU.GetRequest(RestSharp.Method.POST, "/riotclient/launch-ux");
		}

		public static void UxRestart()
		{
			string ux = API.LCU.GetRequest(RestSharp.Method.POST, "/riotclient/kill-and-restart-ux");
		}

		public static void UxShow()
        {
			string ux = API.LCU.GetRequest(RestSharp.Method.POST, "/riotclient/ux-show");
		}

		public static void UxMinimaze()
		{
			string ux = API.LCU.GetRequest(RestSharp.Method.POST, "/riotclient/ux-minimize");
		}
	}
}
