using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace Demo.Models{
    [Table("Demo123s")]
    public class Demo123 {
        [Key]
        public string Demo123ID { get; set; }

        public string Demo123Name { get; set; }
        public object Title { get; internal set; }
    }
}