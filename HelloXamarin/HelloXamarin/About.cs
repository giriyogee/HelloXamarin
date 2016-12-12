using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class About : ContentPage
    {
        public About()
        {
            Title = "About";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "About - <Some Sample text>" }
                }
            };
        }
    }
}
