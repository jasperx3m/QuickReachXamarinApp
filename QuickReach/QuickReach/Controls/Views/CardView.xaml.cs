using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickReach.Controls.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardView : ContentView
    {
        public CardView(DataTemplate itemTemplate)
        {
            InitializeComponent();
            Container.Content = itemTemplate.CreateContent() as View;
        }
        public void Update(object item)
        {
            Container.Content.BindingContext = item;
        }
    }
}