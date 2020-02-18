using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryingCheckBoxes.Models
{
    public class IndexViewModel
    {

        public List<Filter> Filters { get; set; } = new List<Filter>();
    }
    public class Filter
    {
        public string Name { get; set; }
        public bool Selected { get; set; }
    }
}
