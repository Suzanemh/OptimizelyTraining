using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using SUZTraining.Models.Pages;

public class ArticlePageController : PageController<ArticlePage>
{
    public IActionResult Index(ArticlePage currentPage)
    {
        return View(currentPage);
    }
}
