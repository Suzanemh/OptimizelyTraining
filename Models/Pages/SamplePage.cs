namespace SUZTraining.Models.Pages
{
	using System.ComponentModel.DataAnnotations;
	using EPiServer.Core;
	using EPiServer.DataAnnotations;

    [ContentType(DisplayName = "Sample Page", GUID = "b91d4b09-678b-45b6-9f1e-69fb5a8dd79f", Description = "This is a sample page.")]
    public class SamplePage : PageData
    {
		[CultureSpecific]
		[Display(Name = "Heading", Description = "The heading of the page.", GroupName = SiteGroupNames.Specialized, Order = 10)]
		public virtual string Heading { get; set; }

		[CultureSpecific]
		[Display(Name = "Main body", Description = "The main body uses the XHTML-editor so you can insert, for example text, images, and tables.", GroupName = SiteGroupNames.Specialized, Order = 20)]
		public virtual XhtmlString MainBody { get; set; }
	}
}

