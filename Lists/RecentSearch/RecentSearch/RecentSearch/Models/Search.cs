using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentSearch
{
    public class Search
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public String Period
        {
            get
            {
                return String.Format($"{CheckIn.ToString("MMM d,yyy")} - {CheckOut.ToString("MMM d,yyy")}");
            }
        }
    }
}
