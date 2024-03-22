using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.message
{
    abstract class LanduegeSettings
    {
        public string nameError { get; set; } = string.Empty;
        public string priceError { get; set; } = string.Empty;
        public string uncorrectPriceError { get; set; } = string.Empty;
        public string pathError { get; set; } = string.Empty;
        public string discriptionError { get; set; } = string.Empty;
        public string fullDiscriptionError { get; set; } = string.Empty;
        public string quantityError { get; set; } = string.Empty;
        public string uncorrectQuantityError { get; set; } = string.Empty;
        public string notNumberError { get; set; }
        public string resultEmptyError { get; set; }

        public string hello { get; set; } = string.Empty;
        public string ansverDel { get; set; } = string.Empty;
        public string ansverChan { get; set; } = string.Empty;
    }
}
