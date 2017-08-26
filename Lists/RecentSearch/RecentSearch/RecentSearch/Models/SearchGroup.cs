using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentSearch
{
    public class SearchGroup:ObservableCollection<Searches>
    {
        public string GroupTitle { get; set; }
        public SearchGroup(string title ,IEnumerable<Searches>searches=null)
            :base(searches)
        {
            GroupTitle = title;
        }
    }
}
