using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace laba_7.Start
{
    public static class MyCommand
    {
        public static readonly RoutedUICommand SayHello = new RoutedUICommand(
            "Say Hello", "SayHello", typeof(MyCommand),
            new InputGestureCollection()
            {
                new KeyGesture(Key.V, ModifierKeys.Alt)
            }
        );
    }
}
