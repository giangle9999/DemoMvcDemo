using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace Demo.Models{
    [Table("Person")]
    public class Person {
        [Key]
        public string PersonID { get; set; }

        public string PersonName { get; set; }

        public string Rating { get; set; }
        
    }
}
//dotnet-aspnet-codegenerator controller -name ProductsController -m Product -dc DemoDBContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite