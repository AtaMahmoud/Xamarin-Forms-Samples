using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecentSearch
{
    public class Searches
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Period
        {
            get
            {
                return string.Format($"{CheckIn.ToString("MMM d,yyy")}- {CheckOut.ToString("MMM d,yyy")}");
            }
        }
    }
}
