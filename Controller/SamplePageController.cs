using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SUZTraining.Models.Pages; // Dette er hvor SamplePage-modellen ligger

public class SamplePageController : Controller
{
	public IActionResult Index()
	{
		var model = new SamplePage
		{
			Heading = "Sample Heading",
			MainBody = new XhtmlString("Sample Main Body Content")
		};

		if (model == null || model.Heading == null || model.MainBody == null)
		{
			// Håndter null-tilfelle
			return View("Error");
		}

		return View(model);
	}
}
