using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentSearch
{
    public class SearchGroup:Search
    {
        public string GroupTitle { get; set; }
        public SearchGroup(string title=null)
        {
            GroupTitle = title;
        }
    }
}
