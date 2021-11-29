using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Demo.Models{
    [Table("Categories")]
    public class Category {
        [Key]
        public int CategoryID { get; set; }

        public string Name { get; set; }
        public ICollection<Product1> Product1s {get; set;}
    }
}