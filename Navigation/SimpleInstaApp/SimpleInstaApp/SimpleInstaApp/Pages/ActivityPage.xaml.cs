using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleInstaApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityPage : ContentPage
    {
        private ActivityServices activity = new ActivityServices();
        public ActivityPage()
        {
            InitializeComponent();
            ActivityList.ItemsSource = activity.GetActivity();
        }

        private   void ActivityList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var user = e.SelectedItem as Activity;
            ActivityList.SelectedItem = null;
            Navigation.PushAsync(new UserProfile(user.UserId));
           
           
        }
    }
}