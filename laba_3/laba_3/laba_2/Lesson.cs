using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace laba_2
{
    public class Lesson
    {
        [Required(ErrorMessage = "Error Name")]
        public string Name { get; set; } = string.Empty;
        public int Year { get; set; }

        [MyValidation]
        public int Semester { get; set; }
        public string Specialies { get; set; } = string.Empty;
        public int Control { get; set; }
        public int Lectures { get; set; }
        public int Laboratory { get; set; }
        public Lectorer Lector { get; set; } = new Lectorer();
        public List<BookList> Books { get; set; } = new List<BookList>();
    }
}
