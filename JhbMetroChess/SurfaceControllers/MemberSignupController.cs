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

			JhbMetro.Admin.Model.Model db = new JhbMetro.Admin.Model.Model();

			var sss = db.zMembers.Add(new JhbMetro.Admin.Model.zMember() {
				MemberBirthdate	= model.DateOfBirth,	
				MemberChessaID = model.ChessaId,
				MemberClub = model.Club,
				MemberEmail = model.Email,
				MemberGender = model.Gender,
				MemberName = model.Name,
				MemberNamePref = model.PreferedName,
				MemberNotes = model.Note,
				MemberParent = model.ParentName,
				MemberParentEmail = model.ParentEmail,
				MemberParentEmployer = model.ParentEmployer,
				MemberParentPhone = model.ParentPhone,
				MemberPhone = model.PhoneNumber,
				MemberSurname = model.Surname
			});
			db.SaveChanges();

			var mailTemplate = this.HttpContext.Server.MapPath("/MailTemplates/MemberSignup.html");
			var body = System.IO.File.ReadAllText(mailTemplate)
				.Replace("{Surname}", model.Surname)
				.Replace("{FirstName}", model.Name)
				.Replace("{ChessaId}", model.ChessaId)
				.Replace("{DateOfBirth}", model.DateOfBirth.ToString("yyy-MM-dd"))
				.Replace("{Gender}", model.Gender)
				.Replace("{EmailAddress}", model.Email)
				.Replace("{PhoneNumber}", model.PhoneNumber)
				.Replace("{Club}", model.Club)
				//.Replace("{Section}", model.Sec)
				.Replace("{Note}", model.Note)
				.Replace("{DateofEntry}", DateTime.Now.ToString());
			umbraco.library.SendMail(ConfigurationManager.AppSettings["FromEmail"], ConfigurationManager.AppSettings["MemberSignupMailReceiver"], $"New Membership Signup: {model.Name} {model.Surname}", body, true);

			return "Signup Complete";
		}
	}
}