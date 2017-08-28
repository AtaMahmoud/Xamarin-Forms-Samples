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
    public partial class UserProfile : ContentPage
    {
        private UserServices user = new UserServices();
        public UserProfile(int userId)
        {
            InitializeComponent();
            BindingContext = user.GetUser(userId);
        }
    }
}