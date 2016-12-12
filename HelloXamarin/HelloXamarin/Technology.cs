using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class Technology : ContentPage
    {
        public Technology()
        {
            Title = "Technology";
            Content = new StackLayout
            {               
                Children = {
                    new Label { Text = "Technology - <Some Sample Text>" }
                }
            };
        }
    }
}
