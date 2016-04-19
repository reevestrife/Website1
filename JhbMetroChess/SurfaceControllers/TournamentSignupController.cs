using Google.GData.Client;
using Google.GData.Spreadsheets;
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
	public class TournamentSignupController : SurfaceController
	{
		[ChildActionOnly]
		public ActionResult TournamentForm(int tournamentId)
		{
			return View(new TournamentEntry() { TournamentId = tournamentId });
		}


		[HttpPost]
		public string SubmitTournamentForm(TournamentEntry model)
		{
			try
			{
				if (ModelState.IsValid)
				{

					JhbMetro.Admin.Model.Model db = new JhbMetro.Admin.Model.Model();
					db.zTourEntries.Add(new JhbMetro.Admin.Model.zTourEntry() {
						ChessaID = model.ChessaId,
						entryComments = model.EntryComment,
						PlayerBirthdate = model.DateOfBirth,
						PlayerClub = model.Club,
						PlayerClubOther = model.ClubOther,
						PlayerEmail = model.Email,
						PlayerGender = model.Gender,
						PlayerName = model.Name,
						PlayerPhone = model.PhoneNumber,
						PlayerSurname = model.Surname,
						PlayerUnion = model.Union,
						SectionID = model.SectionId,
						TourID = model.TournamentId,
						RegisterDate = DateTime.Now.ToString("ddMMMHH:mm"),
					});
					db.SaveChanges();

				
					var mailTemplate = this.HttpContext.Server.MapPath("/MailTemplates/TournamentSignup.html");
					var body = System.IO.File.ReadAllText(mailTemplate)
						.Replace("{Tournament}", model.TournamentId.ToString())
						.Replace("{Surname}", model.Surname)
						.Replace("{FirstName}", model.Name)
						.Replace("{ChessaId}", model.ChessaId)
						.Replace("{DateOfBirth}", model.DateOfBirth)
						.Replace("{Gender}", model.Gender)
						.Replace("{EmailAddress}", model.Email)
						.Replace("{PhoneNumber}", model.PhoneNumber)
						.Replace("{Club}", model.Club)
						.Replace("{Section}", model.SectionId.ToString())
						.Replace("{Note}", model.EntryComment)
						.Replace("{DateofEntry}", DateTime.Now.ToString("dd MMM HH:mm"));
					umbraco.library.SendMail(ConfigurationManager.AppSettings["FromEmail"], ConfigurationManager.AppSettings["TournamnetSignupMailReceiver"], $"New Entry for Tournament: {model.TournamentId.ToString()}", body, true);

					return "Thank you for your entry. ";
				}
			}
			catch(Exception ex)
			{

			}
			return "please complete all required fields and then submit again";
		}


		private void SendTournamentEntryMail(TournamentEntry model)
		{

			
		}

		[HttpPost]
		public string GoolePostback()
		{
			return "GooglePostback";
		}



		private void PostToGoogleSheet()
		{
			if (ModelState.IsValid)
			{
				/*
				////////////////////////////////////////////////////////////////////////////
				// STEP 1: Configure how to perform OAuth 2.0
				////////////////////////////////////////////////////////////////////////////

				// TODO: Update the following information with that obtained from
				// https://code.google.com/apis/console. After registering
				// your application, these will be provided for you.

				string CLIENT_ID = "62887415940-m9daki8qjk87hpf666as3pd7nim274qp.apps.googleusercontent.com";

				// This is the OAuth 2.0 Client Secret retrieved
				// above.  Be sure to store this value securely.  Leaking this
				// value would enable others to act on behalf of your application!
				string CLIENT_SECRET = "BjddxoYhyJ52U3XOvzIRPQ3w";

				// Space separated list of scopes for which to request access.
				string SCOPE = "https://spreadsheets.google.com/feeds https://docs.google.com/feeds";

				// This is the Redirect URI for installed applications.
				// If you are building a web application, you have to set your
				// Redirect URI at https://code.google.com/apis/console.
				string REDIRECT_URI = "urn:ietf:wg:oauth:2.0:oob";

				////////////////////////////////////////////////////////////////////////////
				// STEP 2: Set up the OAuth 2.0 object
				////////////////////////////////////////////////////////////////////////////

				// OAuth2Parameters holds all the parameters related to OAuth 2.0.
				OAuth2Parameters parameters = new OAuth2Parameters();

				// Set your OAuth 2.0 Client Id (which you can register at
				// https://code.google.com/apis/console).
				parameters.ClientId = CLIENT_ID;

				// Set your OAuth 2.0 Client Secret, which can be obtained at
				// https://code.google.com/apis/console.
				parameters.ClientSecret = CLIENT_SECRET;

				// Set your Redirect URI, which can be registered at
				// https://code.google.com/apis/console.
				parameters.RedirectUri = REDIRECT_URI;

				////////////////////////////////////////////////////////////////////////////
				// STEP 3: Get the Authorization URL
				////////////////////////////////////////////////////////////////////////////

				// Set the scope for this particular service.
				parameters.Scope = SCOPE;

				// Get the authorization url.  The user of your application must visit
				// this url in order to authorize with Google.  If you are building a
				// browser-based application, you can redirect the user to the authorization
				// url.
				string authorizationUrl = OAuthUtil.CreateOAuth2AuthorizationUrl(parameters);
				Console.WriteLine(authorizationUrl);
				Console.WriteLine("Please visit the URL above to authorize your OAuth "
				  + "request token.  Once that is complete, type in your access code to "
				  + "continue...");
				parameters.AccessCode = Console.ReadLine();

				////////////////////////////////////////////////////////////////////////////
				// STEP 4: Get the Access Token
				////////////////////////////////////////////////////////////////////////////

				// Once the user authorizes with Google, the request token can be exchanged
				// for a long-lived access token.  If you are building a browser-based
				// application, you should parse the incoming request token from the url and
				// set it in OAuthParameters before calling GetAccessToken().
				OAuthUtil.GetAccessToken(parameters);
				string accessToken = parameters.AccessToken;
				Console.WriteLine("OAuth Access Token: " + accessToken);

				////////////////////////////////////////////////////////////////////////////
				// STEP 5: Make an OAuth authorized request to Google
				////////////////////////////////////////////////////////////////////////////

				// Initialize the variables needed to make the request
				GOAuth2RequestFactory requestFactory =
					new GOAuth2RequestFactory(null, "MySpreadsheetIntegration-v1", parameters);
				SpreadsheetsService service = new SpreadsheetsService("MySpreadsheetIntegration-v1");
				service.RequestFactory = requestFactory;

				// Make the request to Google
				// See other portions of this guide for code to put here...







				SpreadsheetsService service = new SpreadsheetsService("jhbmetrochess-1198");

				// TODO: Authorize the service object for a specific user (see other sections)

				// Instantiate a SpreadsheetQuery object to retrieve spreadsheets.
				SpreadsheetQuery query = new SpreadsheetQuery();

				// Make a request to the API and get all spreadsheets.
				SpreadsheetFeed feed = service.Query(query);

				if (feed.Entries.Count == 0)
				{
					// TODO: There were no spreadsheets, act accordingly.
				}

				// TODO: Choose a spreadsheet more intelligently based on your
				// app's needs.
				SpreadsheetEntry spreadsheet = (SpreadsheetEntry)feed.Entries[0];
				Console.WriteLine(spreadsheet.Title.Text);

				// Get the first worksheet of the first spreadsheet.
				// TODO: Choose a worksheet more intelligently based on your
				// app's needs.
				WorksheetFeed wsFeed = spreadsheet.Worksheets;
				WorksheetEntry worksheet = (WorksheetEntry)wsFeed.Entries[0];

				// Define the URL to request the list feed of the worksheet.
				AtomLink listFeedLink = worksheet.Links.FindService(GDataSpreadsheetsNameTable.ListRel, null);

				// Fetch the list feed of the worksheet.
				ListQuery listQuery = new ListQuery(listFeedLink.HRef.ToString());
				ListFeed listFeed = service.Query(listQuery);

				// Create a local representation of the new row.
				ListEntry row = new ListEntry();
				row.Elements.Add(new ListEntry.Custom() { LocalName = "firstname", Value = "Joe" });
				row.Elements.Add(new ListEntry.Custom() { LocalName = "lastname", Value = "Smith" });
				row.Elements.Add(new ListEntry.Custom() { LocalName = "age", Value = "26" });
				row.Elements.Add(new ListEntry.Custom() { LocalName = "height", Value = "176" });

				// Send the new row to the API for insertion.
				service.Insert(listFeed, row);

	*/
			}
			//	umbraco.library.SendMail(sendEmailsFrom, sendEmailsTo, subject, body, true);

			//TempData["InfoMessage"] = "Your message has been successfully sent and we will be in touch soon...";

			//		return RedirectToCurrentUmbracoPage();
			//return CurrentUmbracoPage();
		}


	}
}

	