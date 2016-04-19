using System.Net;
using System.Web.Mvc;

namespace JhbMetroChess.MvcControllers
{
    public class OldSiteReroutesController : Controller
    {
        // GET: OldSiteReroutes
        public ActionResult Index()
        {
			return new HttpStatusCodeResult(HttpStatusCode.Gone);
		}

		public ActionResult Attachments(string year, string month, string file)
		{
			return new HttpStatusCodeResult(HttpStatusCode.Gone);
		}

		public ActionResult Includes(string type, string library,string resource)
		{
			return new HttpStatusCodeResult(HttpStatusCode.Gone);
		}
	}
}