using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models{
    [Table("Student")]
    public class Student1 {
        [Key]
        public int Student1ID { get; set; }

        public string Fullname { get; set; }
    }
}