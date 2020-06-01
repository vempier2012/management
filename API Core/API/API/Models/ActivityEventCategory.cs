using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ActivityEventCategory
    {
        public string classification_code { get; set; }
        public string event_code { get; set; }
        public string description { get; set; }
        public DateTime registration_time { get; set; }
        public DateTime registration_end_time { get; set; }
        public DateTime time_take_place { get; set; }
        public DateTime end_time { get; set; }
        public string location { get; set; }
        public string director { get; set; }
        public bool permission_status { get; set; }
        public string current_status { get; set; }
        public string rate { get; set; }

        public DateTime created_date { get; set; }
        public string created_by { get; set; }
        public DateTime updated_date { get; set; }
        public string updated_by { get; set; }
        public int modified_count { get; set; }
    }
}
