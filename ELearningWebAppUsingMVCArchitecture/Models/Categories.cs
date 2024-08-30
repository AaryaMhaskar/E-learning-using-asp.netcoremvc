using System.ComponentModel.DataAnnotations;

namespace ELearningWebAppUsingMVCArchitecture.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}
