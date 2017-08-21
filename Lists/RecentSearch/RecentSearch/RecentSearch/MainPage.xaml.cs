using System;
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
        public MainPage()
        {
            InitializeComponent();
            RecentSearchList.ItemsSource = PopulateListView();
        }

        public IEnumerable<SearchGroup> PopulateListView()
        {
            var searches = new ObservableCollection<SearchGroup>()
            {
                new SearchGroup("Recent Searches")
                {
                    Id=1,Location="West HollyWood, CA,United States" ,CheckIn=new DateTime(2016,9,1),CheckOut=new DateTime(2016,9,10)
                },
                 new SearchGroup("Recent Searches")
                {
                    Id=2,Location="North HollyWood, CA,United States" ,CheckIn=new DateTime(2017,9,1),CheckOut=new DateTime(2017,9,10)
                },
                 new SearchGroup("Recent Searches")
                {
                    Id=3,Location="Cairo, CA,Egypt" ,CheckIn=new DateTime(2017,8,1),CheckOut=new DateTime(2017,9,1)
                }
            };
            return searches;
        }
    }
}
