using EPiServer.Core;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace SUZTraining.Models.Pages
{
    [ContentType(DisplayName = "Base Page", GUID = "d1a5a1e1-1a1e-4a1e-9a1e-1a1e1a1e1a1e", Description = "Base page for common properties")]
    public class BasePage : PageData
    {
        [CultureSpecific]
        [Display(Name = "Page Title", Description = "The title of the page", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string PageTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta Description", Description = "The meta description of the page", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string MetaDescription { get; set; }
    }
}