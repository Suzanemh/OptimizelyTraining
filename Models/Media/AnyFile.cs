using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace SUZTraining.Models.Media
{
    [ContentType(DisplayName = "Any File",
        GUID = "7940b86a-ca6e-4313-ae8b-d96695774837",
    Description = "Use this to upload any type of file.")]

   
    public class AnyFile : MediaData
    {
    }
}