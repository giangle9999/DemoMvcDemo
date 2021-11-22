using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models{
    [Table("Categories")]
    public class Category {
        [Key]
        public int CategoryID { get; set; }

        public string Name { get; set; }
    }
}