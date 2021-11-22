using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Demo.Models{
    [Table("Product1s")]
    public class Product1 {
        [Key]
        public int Product1ID { get; set; }

        public string Product1Name { get; set; }
        public int CategoryID { get; set; }

        public Category category { get; set;}
        
    }
}