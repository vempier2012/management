using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class StudentMajor
    {
        public string student_code { get; set; }
        public string major_code { get; set; }
        public DateTime created_date { get; set; }
        public string created_by { get; set; }
        public DateTime updated_date { get; set; }
        public string updated_by { get; set; }
        public int modified_count { get; set; }

        public Student Students { get; set; }
        public Major Majors { get; set; }
    }
}
