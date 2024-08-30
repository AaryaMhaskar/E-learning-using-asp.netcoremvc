using System.ComponentModel.DataAnnotations;

namespace ELearningWebAppUsingMVCArchitecture.Models
{
    public class Sub_Categories
    {
        [Key]
        public int SubCategoryId{get; set;}
        public string? SubCategoryName { get; set; }
        public int CategoryId { get; set; }
      
    }
}
