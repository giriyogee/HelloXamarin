using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class Science : ContentPage
    {
        public Science()
        {
            Title = "Science";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Science - <Sample Text>" }
                }
            };
        }
    }
}
