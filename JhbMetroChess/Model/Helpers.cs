using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace JhbMetroChess.Model
{
	public static class Helpers
	{
		public static bool ValidateRecapcha(string userResponse)
		{
			string secretKey = ConfigurationManager.AppSettings["ReCapcha_SecretKey"];
			//string userResponse = Request.Form["g-Recaptcha-Response"];

			var webClient = new System.Net.WebClient();
			string verification = webClient.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, userResponse));

			var verificationJson = Newtonsoft.Json.Linq.JObject.Parse(verification);
			if (verificationJson["success"].Value<bool>())
			{
				return true;
			}

			return false;
		}
	}
}