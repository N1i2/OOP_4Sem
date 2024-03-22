using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.message
{
    class RuText : LanduegeSettings
    {
        public RuText()
        {
            nameError = "Вы не написали имя продукта";
            priceError = "Вы не написали цену продукта";
            uncorrectPriceError = "Вы написали некорректную цену";
            pathError = "Вы написали некоректный путь до изображения";
            discriptionError = "Вы не написали краткое описание";
            fullDiscriptionError = "Вы не написали полное описание";
            quantityError = "Вы не написали количество продукта";
            uncorrectQuantityError = "вы написали некоррексное количество товара";
            notNumberError = "Некорректная цена";
            resultEmptyError = "У нас нет таких продуктов";

            hello = "Привет";
            ansverDel = "Вы уверены что хотите удалить этот продукт?";
            ansverChan = "Если вы выйдете то изменения не сохраняться!";
        }
    }
}
