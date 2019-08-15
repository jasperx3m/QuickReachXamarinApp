using QuickReach.Models;
using QuickReach.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuickReach
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        private List<MasterMenuItem> menuItems { get; set; }
        public MainPage()
        {
            InitializeComponent();
            menuItems = new List<MasterMenuItem>();
            var page1 = new MasterMenuItem() { Title = "Approval", Icon = "notification.png", TargetType = typeof(ApprovalPage) };
            menuItems.Add(page1);

            navigationDrawerList.ItemsSource = menuItems;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ApprovalPage)));
        }
        void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterMenuItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
