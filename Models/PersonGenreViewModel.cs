using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Demo.Models
{
    public class PersonGenreViewModel
    {
        public List<Person> Persons { get; set; }
        public SelectList Genres { get; set; }
        public string PersonGenre { get; set; }
        public string SearchString { get; set; }
    }
}