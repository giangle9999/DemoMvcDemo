using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]

        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; }          

        
    }
}
//dotnet-aspnet-codegenerator controller -name StudentsController -m Student -dc DemoDBContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite