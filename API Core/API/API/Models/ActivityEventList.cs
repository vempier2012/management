using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ActivityEventList
    {
        public string event_code { get; set; }
        public string event_name { get; set; }
        public string classification_code { get; set; }
        public string description { get; set; }

        public ActivityEventCategory ActivityEventCategory { get; set; }
    }
}
