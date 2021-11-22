using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models{
  
    public class School : Student1 {
        
        public int TeacherID { get; set; }

        public string University { get; set; }
    }
}