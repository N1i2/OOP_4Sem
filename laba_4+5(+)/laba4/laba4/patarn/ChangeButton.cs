using laba4.worker;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Windows.Navigation;
using System.Xml.Linq;

namespace laba4
{
    internal class ChangeButton : IButtonClick
    {
        public ChangeButton(){}

        public void ButtonClick(fullProduct f)
        {
            f.changNow = !f.changNow;
            f.needChange = true;

            if (f.changNow)
            {
                f.name.Visibility = Visibility.Hidden;
                f.price.Visibility = Visibility.Hidden;
                f.quantity.Visibility = Visibility.Hidden;
                f.discription.Visibility = Visibility.Hidden;

                f.nameB.Visibility = Visibility.Visible;
                f.priceB.Visibility = Visibility.Visible;
                f.quantityB.Visibility = Visibility.Visible;
                f.discriptionB.Visibility = Visibility.Visible;

                f.nameB.Text = f.name.Text;
                f.priceB.Text = f.price.Text;
                f.quantityB.Text = f.quantity.Text;
                f.discriptionB.Text = f.discription.Text;

                f.change.SetResourceReference(Control.StyleProperty, "ShowSaveChange");
            }
            else
            {
                if (f.nameB.Text.Replace(" ", "") == string.Empty)
                {
                    f.nameB.Text = f.name.Text;
                }
                if (!double.TryParse(f.priceB.Text, out double pri) || pri <= 0)
                {
                    f.priceB.Text = f.price.Text;
                }
                if (!int.TryParse(f.quantityB.Text, out int que) || que < 0)
                {
                    f.quantityB.Text = "0";
                }
                if (f.discriptionB.Text.Replace(" ", "") == string.Empty)
                {
                    f.discriptionB.Text = f.discription.Text;
                }

                f.products[f.idx].Name = f.nameB.Text;
                f.products[f.idx].Price = Convert.ToInt32(f.priceB.Text);
                f.products[f.idx].Quantity = Convert.ToInt32(f.quantityB.Text);
                f.products[f.idx].AllDescription = f.discriptionB.Text;

                f.nameB.Visibility = Visibility.Hidden;
                f.priceB.Visibility = Visibility.Hidden;
                f.quantityB.Visibility = Visibility.Hidden;
                f.discriptionB.Visibility = Visibility.Hidden;

                f.name.Visibility = Visibility.Visible;
                f.price.Visibility = Visibility.Visible;
                f.quantity.Visibility = Visibility.Visible;
                f.discription.Visibility = Visibility.Visible;

                f.name.Text = f.nameB.Text;
                f.price.Text = f.priceB.Text;
                f.quantity.Text = f.quantityB.Text;
                f.discription.Text = f.discriptionB.Text;

                f.change.SetResourceReference(Control.StyleProperty, "ShowChange");

                if (f.quantity.Text == "0")
                {
                    f.order.Background = Brushes.Gray;
                }
                else
                {
                    f.order.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(30, 66, 64));
                }
            }
        }
    }
}
