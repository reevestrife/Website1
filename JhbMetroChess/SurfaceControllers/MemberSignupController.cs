using JhbMetroChess.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace JhbMetroChess.SurfaceControllers
{
	public class MemberSignupController : SurfaceController
	{
		[ChildActionOnly]
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public string PostMemberSignup(MemberSignup model)
		{
			var mailTemplate = this.HttpContext.Server.MapPath("/MailTemplates/MemberSignup.html");
			var body = System.IO.File.ReadAllText(mailTemplate)
				.Replace("{Surname}", model.Surname)
				.Replace("{FirstName}", model.FirstName)
				.Replace("{ChessaId}", model.ChessaId)
				.Replace("{DateOfBirth}", model.DateOfBirth)
				.Replace("{Gender}", model.Gender)
				.Replace("{EmailAddress}", model.EmailAddress)
				.Replace("{PhoneNumber}", model.PhoneNumber)
				.Replace("{Club}", model.Club)
				.Replace("{Section}", model.Section)
				.Replace("{Note}", model.Note)
				.Replace("{DateofEntry}", model.DateofEntry.ToString());
			umbraco.library.SendMail(ConfigurationManager.AppSettings["FromEmail"], ConfigurationManager.AppSettings["MemberSignupMailReceiver"], $"New Membership Signup: {model.FirstName} {model.Surname}", body, true);

			return "Signup Complete";
		}
	}
}