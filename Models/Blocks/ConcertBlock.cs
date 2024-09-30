using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace SUZTraining.Models.Blocks
{
    [ContentType(DisplayName = "Concert Block", GUID = "36c424fe-70e0-49d8-972e-9d1f9c4c4e3a", Description = "A block to display concert details")]
    public class ConcertBlock : BlockData
    {
        [Display(Name = "Concert Image", Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ConcertImage { get; set; }

        [Display(Name = "Concert Title", Order = 20)]
        public virtual string Title { get; set; }

        [Display(Name = "Concert Date", Order = 30)]
        public virtual string Date { get; set; }

        [Display(Name = "Concert Time", Order = 40)]
        public virtual string Time { get; set; }
    }
}
