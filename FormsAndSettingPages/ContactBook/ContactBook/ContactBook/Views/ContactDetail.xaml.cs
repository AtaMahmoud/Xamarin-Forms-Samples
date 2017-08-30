using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactBook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetail : ContentPage
    {
        public EventHandler<Contact> ContactAdded;
        public EventHandler<Contact> ContactUpdated;

     
       
        public ContactDetail(Contact contact)
        {
            InitializeComponent();
            BindingContext = new Contact
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Email=contact.Email,
                Phone=contact.Phone,
                IsBlocked=contact.IsBlocked,
            };
           
           
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            var contact = BindingContext as Contact;
            if(string.IsNullOrWhiteSpace(contact.FullName))
            {
               await DisplayAlert("Erorr!", "Please Enter the Name", "ok");
                return;
            }
            if(contact.Id==0)
            {
                contact.Id = 1;
                ContactAdded?.Invoke(this, contact);

            }
            else
            {
                ContactUpdated?.Invoke(this, contact);
            }
            await Navigation.PopAsync();
        }
    }
}