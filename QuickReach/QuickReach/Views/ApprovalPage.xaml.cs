using QuickReach.ViewModels;
using SwipeCards.Controls;
using QuickReach.Controls.Views;
using QuickReach.Controls.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace QuickReach.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApprovalPage : Xamarin.Forms.ContentPage
    {
        public ApprovalPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

            // Disable swiping between tabs on Android, as it collides 
            // with Swipe Card's swipe gestures
            //this.On<Xamarin.Forms.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);
        }

        void RestartButton_Clicked(object sender, EventArgs e)
        {
            CardStackView.Setup();
        }
        void CardStackView_Swiped(object sender, Controls.Arguments.SwipedEventArgs e)
        {

        }

    }
}
