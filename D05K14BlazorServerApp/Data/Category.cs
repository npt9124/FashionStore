using System.ComponentModel.DataAnnotations;
namespace D05K14BlazorServerApp.Data
{
    public class Category
    {
        public int CatId { get; set; }
        [Required (ErrorMessage ="Please fill category name")]
        public string CatName { get; set; }
        [Required]
        [Range(0,1)]
        public int IsDeleted { get; set; }
    }
}
