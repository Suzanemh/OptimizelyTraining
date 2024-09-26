using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SUZTraining.Models.Pages; // Dette er hvor SamplePage-modellen ligger

	public class SamplePageController : PageController<SamplePage>
	{
		public ActionResult Index(SamplePage currentPage)
		{
			return View(currentPage);
		}
	}

