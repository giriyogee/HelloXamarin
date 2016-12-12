using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloXamarin
{
    public class Category
    {
        public string Name
        {
            get;
            set;
        }

        public Func<ContentPage> PageFn
        {
            get;
            set;
        }

        public Category(string name, Func<ContentPage> pageFn)
        {
            Name = name;
            PageFn = pageFn;
        }
    }
}
