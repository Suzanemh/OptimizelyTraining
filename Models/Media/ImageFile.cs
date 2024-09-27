


using System.ComponentModel.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace SUZTraining.Models.Media
{


    //Definere contenttype
    [ContentType(DisplayName = "Image File",
        Description = "Use this to upload image files.")]
    [MediaDescriptor(ExtensionString = "jpg, jpeg, png, gif")]


    public class ImageFile : ImageData
    {

        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }

    }
}
