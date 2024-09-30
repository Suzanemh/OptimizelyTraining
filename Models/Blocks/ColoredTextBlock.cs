using EPiServer.Core;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace SUZTraining.Models.Blocks
{
    [ContentType(DisplayName = "Colored Text Block", GUID = "5e6d22a0-90ba-4369-b543-a4fe855804d1", Description = "A block with a colored background and text")]
    public class ColoredTextBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Text", Description = "The text to display", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Text { get; set; }

        [Display(Name = "Background Color", Description = "The background color of the block", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string BackgroundColor { get; set; }
    }
}


