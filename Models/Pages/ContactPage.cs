using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace SUZTraining.Models.Pages
{
    [ContentType(DisplayName = "Contact Page", GUID = "bee7d32f-7581-409c-a2d5-d9d67fa56de0", Description = "Page type for contact information")]
    public class ContactPage : BasePage
    {
        [CultureSpecific]
        [Display(Name = "Contact Heading", Description = "The heading of the contact page", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual string ContactHeading { get; set; }

        [CultureSpecific]
        [Display(Name = "Contact Information", Description = "The contact information", GroupName = SystemTabNames.Content, Order = 40)]
        public virtual XhtmlString ContactInformation { get; set; }

        [CultureSpecific]
        [Display(Name = "Contact Form", Description = "The contact form", GroupName = SystemTabNames.Content, Order = 50)]
        public virtual XhtmlString ContactForm { get; set; }
    }
}

