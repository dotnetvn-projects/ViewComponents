using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentSample.Models
{
    public class GirlListModel
    {
        public List<GirlModel> GirlList { get; set; }
        public int TotalRecord { get; set; }

        public GirlListModel()
        {
            GirlList = new List<GirlModel>();
        }
    }
}
