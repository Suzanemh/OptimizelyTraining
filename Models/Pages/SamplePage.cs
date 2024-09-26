namespace SUZTraining.Models.Pages
{
    using EPiServer.Core;
    using EPiServer.DataAnnotations;

    [ContentType(DisplayName = "Sample Page", GUID = "b91d4b09-678b-45b6-9f1e-69fb5a8dd79f", Description = "This is a sample page.")]
    public class SamplePage : PageData
    {
        public virtual string Heading { get; set; }
        public virtual XhtmlString MainBody { get; set; }
    }
}
