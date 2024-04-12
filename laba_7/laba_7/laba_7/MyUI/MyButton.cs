using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace laba_7.MyUI
{
    public class MyButton:Button
    {
        public MyButton()
        {
            Margin = new System.Windows.Thickness(350, 327, 350, 123);
            Content = "Go";
        }
    }
}
