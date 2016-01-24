﻿using JhbMetroChess.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace JhbMetroChess.SurfaceControllers
{
    public class ContactUsController : SurfaceController
	{
		[HttpPost]
		public string PostContactUs(ContactUs model)
		{
			var mailTemplate = this.HttpContext.Server.MapPath("/MailTemplates/ContactUs.html");
			var body = System.IO.File.ReadAllText(mailTemplate)
				.Replace("{Name}", model.Name)
				.Replace("{Email}", model.Email)
				.Replace("{Phone}", model.Phone)
				.Replace("{Comments}", model.Comments);
						
			umbraco.library.SendMail(ConfigurationManager.AppSettings["FromEmail"], ConfigurationManager.AppSettings["ContactUsMailReceiver"], $"New Contact Us Message From: {model.Name}", body, true);

			return "Thank you for your message, we will be in touch.";
		}
	}
}