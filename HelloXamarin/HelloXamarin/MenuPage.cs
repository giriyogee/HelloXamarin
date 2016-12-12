using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace HelloXamarin
{
    public class MenuPage : ContentPage
    {
        public Action<ContentPage> OnMenuSelect
        {
            get;
            set;
        }
        public MenuPage()
        {
            Title = "Menu";
            Icon = "menu.png";

            Padding = new Thickness(10, 20);

            var categories = new List<Category>() {

                new Category("Home",()=>new Home()),
                new Category("Science", () => new Science()),
                new Category("Technology", () => new Technology()),
                new Category("About", () => new About())
            };

            var dataTemplate = new DataTemplate(typeof(TextCell));
            dataTemplate.SetBinding(TextCell.TextProperty, "Name");

            var listView = new ListView()
            {
                ItemsSource = categories,
                ItemTemplate = dataTemplate
            };

            listView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => {
                if (OnMenuSelect != null)
                {
                    var category = (Category)e.SelectedItem;
                    var categoryPage = category.PageFn();
                    OnMenuSelect(categoryPage);
                }
            };

            Content = listView;
        }
    }
}
