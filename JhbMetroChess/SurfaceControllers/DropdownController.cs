using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace JhbMetroChess.SurfaceControllers
{
	public class DropdownController : SurfaceController
	{
		[ChildActionOnly]
		public ActionResult Club()
		{
			return View(new JhbMetro.Admin.Model.Model().zClubs.ToList());
		}

		[ChildActionOnly]
		public ActionResult TournamentSection(int tournamentId)
		{
			return View(new JhbMetro.Admin.Model.Model().zTourSections.ToList());
		}

		[ChildActionOnly]
		public ActionResult Union()
		{
			return View(new JhbMetro.Admin.Model.Model().zUnions.ToList());
		}
	}
}

	