using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web;

namespace JhbMetroChess.Extensions
{
	public static class UmbracoRazorExtensions
	{
		public static string TournamentStatus(this UmbracoHelper umbraco, object objStartDate, object objEndDate)
		{
			DateTime startDate = (DateTime)objStartDate;
			DateTime EndDate = (DateTime)objEndDate;

			if (DateTime.Now < startDate) return "upcoming";
			if (DateTime.Now < EndDate && DateTime.Now > startDate) return "inprogress";
			if (DateTime.Now > EndDate) return "previous";
			else return "";
		}


		/// <summary>
		/// If the intended image is not specified, this will return the fallback image
		/// </summary>
		/// <param name="umbraco"></param>
		/// <param name="mainImage"></param>
		/// <param name="fallbackImage"></param>
		/// <returns></returns>
		public static string fallbackImage(this UmbracoHelper umbraco, string mainImage, string fallbackImage)
		{
			if(string.IsNullOrEmpty(mainImage))
			{
				return fallbackImage;
			}
			return mainImage;
		}


										
		public static string HomeIfNotHome(this UmbracoHelper umbraco,string documentTypeAlias)
		{
			if(documentTypeAlias == "Home")
			{
				return "";
			}
			return "/";
		}

		public static string SetTargeBlank(this UmbracoHelper umbraco, bool setTargetBlank)
		{
			if (setTargetBlank == true)
			{
				return "target=\"_blank\"";
			}
			else return "";
		}
	}
}