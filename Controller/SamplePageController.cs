using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SUZTraining.Models.Pages;
using SUZTraining.Models.ViewModels; // Dette er hvor SamplePage-modellen ligger

public class SamplePageController : PageController<SamplePage>
{
	public IActionResult Index(SamplePage currentPage)
	{
		var model = new SamplePageViewModel
		{
			currentPage = currentPage
		};


		return View(model);
	}
}
