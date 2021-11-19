using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models{
    [Table("People")]
    public class Customer {
        [Key]
        public int CustomerID { get; set; }

        public string Fullname { get; set; }
    }
}