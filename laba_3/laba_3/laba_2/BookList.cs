using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    public class BookList
    {
        public string Name { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;

        [Range(100, 5000, ErrorMessage = "Error Page")]
        public int Pages { get; set; }
    }
}
