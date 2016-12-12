using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class Home : ContentPage
    {
        public Home()
        {
            Title = "Home";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Jay - Scientist and Consultant" }
                }
            };
        }
    }
}
