using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Click
    {
        IButtonClick click = new ChangeButton();
        static fullProduct full = new fullProduct();

        public Click()
        {

        }
        public Click(fullProduct f)
        {
            full = f;
        }
        public Click(IButtonClick cl)
        {
            this.click = cl;
        }

        public void ClickButton()
        {
            click.ButtonClick(full);
        }
    }
}
