using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactBook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contacts : ContentPage
    {
        private ObservableCollection<Contact> GetContact;
        public Contacts()
        {
            InitializeComponent();
            GetContact = new ObservableCollection<Contact>
            {
                new Contact{Id=1,FirstName="Ata" , LastName="Mahmoud"},
                new Contact{Id=2,FirstName="Mohamed" , LastName="Ata"}
            };
            ContactList.ItemsSource = GetContact;
           
        }

        private async void add_Activated(object sender, EventArgs e)
        {

            var page = new ContactDetail(new Contact());
            page.ContactAdded += (source, Contact) =>
              {
                  GetContact.Add(Contact);
              };
            await Navigation.PushAsync(page);
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            if (await DisplayAlert("Warning", $"Are you sure you want to delete {contact.FullName}?", "Yes", "No"))
                GetContact.Remove(contact);
                
        }

        private async void ContactList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (ContactList.SelectedItem == null)
                return;

            var selectedContact = e.SelectedItem as Contact;

            var page = new ContactDetail(selectedContact);
            page.ContactUpdated += (source, Contact) =>
              {
                  selectedContact.Id = Contact.Id;
                  selectedContact.FirstName = Contact.FirstName;
                  selectedContact.LastName = Contact.LastName;
                  selectedContact.Phone = Contact.Phone;
                  selectedContact.Email = Contact.Email;
                  selectedContact.IsBlocked = Contact.IsBlocked;
              };
            await Navigation.PushAsync(page);

        }
    }
}