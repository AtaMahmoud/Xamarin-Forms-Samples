using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentSearch
{
    public class SearchService
    {
        private List<Searches> _searches = new List<Searches>
        {
            new Searches
            {
                ID = 1,
                Location = "West Hollywood, CA, United States",
                CheckIn = new DateTime(2016, 9, 1),
                CheckOut = new DateTime(2016, 11, 1)
            },
            new Searches
            {
                ID = 2,
                Location = "Santa Monica, CA, United States",
                CheckIn = new DateTime(2016, 9, 1),
                CheckOut = new DateTime(2016, 11, 1)
            },
            new Searches
            {
                ID = 3,
                Location = "Cairo, CI, Egypt",
                CheckIn = new DateTime(2017, 9, 1),
                CheckOut = new DateTime(2017, 11, 1)
            },
            new Searches
            {
                ID = 4,
                Location = "Mnoufiya, MN, Egypt",
                CheckIn = new DateTime(2017, 8, 1),
                CheckOut = new DateTime(2017, 10, 1)
            }
        };
        public IEnumerable<Searches> GetSearches(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter))
                return _searches;
            return _searches.Where(word => word.Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
        }
        public void DeleteSearch(int id)
        {
            _searches.Remove(_searches.Single(s=>s.ID==id));
        }
    }
}
