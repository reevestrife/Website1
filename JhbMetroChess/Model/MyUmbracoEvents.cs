using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using umbraco.businesslogic;
using umbraco.BusinessLogic;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;

namespace JhbMetroChess.Model
{
	public class WorkflowEventHandler : ApplicationEventHandler
	{
		public WorkflowEventHandler()
		{
			ContentService.Publishing += ContentService_Publishing;
		}

		private void ContentService_Publishing(Umbraco.Core.Publishing.IPublishingStrategy sender, Umbraco.Core.Events.PublishEventArgs<Umbraco.Core.Models.IContent> e)
		{
			foreach (var item in e.PublishedEntities.Where(p=> p.ContentTypeId == 1))
			{
		//		item.
			} 
		}

		protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
		{
			base.ApplicationStarted(umbracoApplication, applicationContext);


			
			//Create a custom route
			RouteTable.Routes.MapRoute(
				"old site attachments",
				"wp-content/uploads/{year}/{month}/{file}",
				new
				{
					controller = "OldSiteReroutes",
					action = "Attachments",
					sku = UrlParameter.Optional
				});

			//Create a custom route
			RouteTable.Routes.MapRoute(
				"old site includes",
				"wp-includes/{type}/{library}/{resource}",
				new
				{
					controller = "OldSiteReroutes",
					action = "Includes",
					sku = UrlParameter.Optional
				});
		}
	}
}