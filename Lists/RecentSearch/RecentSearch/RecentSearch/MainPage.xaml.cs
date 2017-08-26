using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RecentSearch
{
    public partial class MainPage : ContentPage
    {
        private SearchService GetSearchService;
        private List<SearchGroup> _searchGroup;
        public MainPage()
        {
            InitializeComponent();
            GetSearchService = new SearchService();
            PopulateListView(GetSearchService.GetSearches());
        }

        private void PopulateListView(IEnumerable<Searches> searches)
        {
            _searchGroup = new List<SearchGroup>
            {
                new SearchGroup("Recent Searches",searches)
            };
            RecentSearchList.ItemsSource = _searchGroup;
        }

        private void RecentSearchList_Refreshing(object sender, EventArgs e)
        {
            PopulateListView(GetSearchService.GetSearches(ListSearchBar.Text));
            RecentSearchList.EndRefresh();
        }

        private void ListSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            PopulateListView(GetSearchService.GetSearches(e.NewTextValue));
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Searches;
            _searchGroup[0].Remove(search);

            GetSearchService.DeleteSearch(search.ID);
            DisplayAlert("Delted", search.Location, "Ok");
        }

        private void RecentSearchList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var search = e.SelectedItem as Searches;
            DisplayAlert("Selected", search.Location, "Ok");
        }
    }
}
