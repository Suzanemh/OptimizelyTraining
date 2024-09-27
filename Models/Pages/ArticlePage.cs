
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace SUZTraining.Models.Pages
{
    [ContentType(DisplayName = "Article Page", GUID = "a2b2c2d2-e2f2-4a2b-9a2b-2a2b2a2b2a2b", Description = "Page type for articles")]
    public class ArticlePage : BasePage
    {
        [CultureSpecific]
        [Display(Name = "Article Heading", Description = "The heading of the article", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual string ArticleHeading { get; set; }

        [CultureSpecific]
        [Display(Name = "Article Body", Description = "The main body of the article", GroupName = SystemTabNames.Content, Order = 40)]
        public virtual XhtmlString ArticleBody { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Name = "Article Image", Description = "The image of the article", GroupName = SystemTabNames.Content, Order = 50)]
        public virtual ContentReference ArticleImage { get; set; }
    }
}