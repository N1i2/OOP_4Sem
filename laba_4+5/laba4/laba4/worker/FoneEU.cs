using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace laba4
{
    public class FoneEU : ComboBox
    {
        List<ComboBoxItem> itm = new List<ComboBoxItem>();

        public FoneEU()
        {
            //string hh = TryFindResource("whiteF").ToString()??"hello";

            itm.Add(new ComboBoxItem
            {
                IsSelected = true,
                Name = "whiteItem",
                Background = Brushes.White,
                Foreground = Brushes.Gray,
            });

            itm.Add(new ComboBoxItem
            {
                Name = "blackItem",
                Background = Brushes.Black,
                Foreground = Brushes.White,
            });

            Items.Add(itm[0]);
            Items.Add(itm[1]);
        }

        public void itemFocus(int i)
        {
            itm[i].Foreground = Brushes.Gray;
            if (i == 0)
            {
                itm[1].Foreground = Brushes.White;
            }
            else
            {
                itm[0].Foreground = Brushes.Black;
            }
        }
        public void focuseBlack()
        {
            itm[1].IsSelected = true;
            itemFocus(1);
        }
        public void reversLang()
        {
            itm[0].Content = TryFindResource("whiteF");
            itm[1].Content = TryFindResource("blackF");
        }
    }
}
