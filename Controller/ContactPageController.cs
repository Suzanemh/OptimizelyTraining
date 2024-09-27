/*using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SUZTraining.Models.Pages;

public class ContactPageController : PageController<ContactPage>
{
    public IActionResult Index(ContactPageController currentPage)
    {
        return View(currentPage);
    }
}
*/



using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SUZTraining.Models.Pages;

public class ContactPageController : PageController<ContactPage>
{
    public IActionResult Index(ContactPage currentPage)
    {
        if (currentPage == null)
        {
            return NotFound();
        }

        return View(currentPage);
    }
}
