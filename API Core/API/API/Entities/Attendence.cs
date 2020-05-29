using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Attendence
    {
        public string event_code { get; set; }
        public string student_code { get; set; }
        public DateTime time_checkin { get; set; }
        public DateTime time_checkout { get; set; }
        public DateTime created_date { get; set; }
        public string created_by { get; set; }
        public DateTime updated_date { get; set; }
        public string updated_by { get; set; }
        public int modified_count { get; set; }

        public ActivityEventList ActivityEvent { get; set; }
        public Student Student { get; set; }
    }
}
