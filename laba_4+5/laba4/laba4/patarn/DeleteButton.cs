using laba4.worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace laba4
{
    internal class DeleteButton : IButtonClick
    {
        public DeleteButton(){}

        public void ButtonClick(fullProduct f)
        {
            f.products.Remove(f.products[f.idx]);

            FileWork.Serialize(f.products);

            f.NavigationService.Navigate(new Shop(true, true, Shop.GetFone()));

        }
    }
}
