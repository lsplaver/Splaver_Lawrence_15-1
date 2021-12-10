using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJack.Models
{
    public class HandViewModel
    {
        //public Dictionary<string, object> HandAndType { get; set; }
        public string HandType { get; set; }
        public Hand Hand { get; set; }
    }
}
