﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            
            var menuPage = new MenuPage();
            menuPage.OnMenuSelect = (categoryPage) => {
                Detail = new NavigationPage(categoryPage);
                IsPresented = false;
            };

            Master = menuPage;
            
            Detail = new NavigationPage(new Home());
        }
    }
}
