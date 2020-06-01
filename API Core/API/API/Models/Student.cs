using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Student
    {
        public string student_code { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string date_of_birth { get; set; }
        public string place_of_birth { get; set; }
        public string birth_place { get; set; }
        public bool gender { get; set; }
        public string identity_code { get; set; }
        public string personal_phone_num { get; set; }
        public string relative_phone_num { get; set; }
        public string permanent_addr { get; set; }
        public string temporary_addr { get; set; }
        public string personal_mail { get; set; }
        public DateTime created_date { get; set; }
        public string created_by { get; set; }
        public DateTime updated_date { get; set; }
        public string updated_by { get; set; }
        public int modified_count { get; set; }

        public ICollection<StudentMajor> StudentsMajors { get; set; }
        public ICollection<Attendence> Attendences { get; set; }
    }
}
