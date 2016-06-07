using System.ComponentModel.DataAnnotations;

namespace AspNetMvcCoreNullContainer.Models
{
    public class ChildClass
    {
        [DataType(DataType.MultilineText)]
        public string MultilineText { get; set; }
    }
}