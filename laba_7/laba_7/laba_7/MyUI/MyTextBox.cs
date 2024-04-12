﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace laba_7.MyUI
{
    public class MyTxtBox: TextBox
    {
        public MyTxtBox()
        {
            Name = "TextColor";
            Margin = new System.Windows.Thickness(300, 150, 300, 250);
            Background = Brushes.Black;
            Foreground = Brushes.White;
        }
    }
}
