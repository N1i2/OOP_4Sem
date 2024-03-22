using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.message
{
    class AngText : LanduegeSettings
    {
        public AngText()
        {
            nameError = "You did not write the product name";
            priceError = "You did not write the price of the product";
            uncorrectPriceError = "You wrote an incorrect price";
            pathError = "You wrote an incorrect path to the image";
            discriptionError = "You did not write a short description";
            fullDiscriptionError = "You did not write a full description";
            quantityError = "You did not write the quantity of the product";
            uncorrectQuantityError = "you wrote an incorrect quantity of the product";
            notNumberError = "Uncorrect price";
            resultEmptyError = "We donthave this product";

            hello = "Hello";
            ansverDel = "Are you sure you want to remove this product?";
            ansverChan = "If you exit, the changes will not be saved!";
        }
    }
}