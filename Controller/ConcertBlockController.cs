using EPiServer.Web.Mvc;
using SUZTraining.Models.Blocks;
using Microsoft.AspNetCore.Mvc;
using SUZTraining.Models.Pages;



namespace SUZTraining.Controllers
{
    public class ConcertBlockController : BlockComponent<ConcertBlock>
    {
        protected override IViewComponentResult InvokeComponent(ConcertBlock currentBlock)
        {
            return View("~/Views/ConcertBlock/Index.cshtml", currentBlock);
        }
    }
}


