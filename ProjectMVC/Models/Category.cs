using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectMVC.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [DisplayName ("Category Name")]
        public string Name { get; set; }

        [DisplayName("Number Of Items")]

        public int NumberOfItems { get; set; }

    }
}
