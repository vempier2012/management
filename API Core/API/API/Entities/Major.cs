﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Major
    {
        public string major_code { get; set; }
        public string major_name { get; set; }
        public string faculty_code { get; set; }
        public DateTime created_date { get; set; }
        public string created_by { get; set; }
        public DateTime updated_date { get; set; }
        public string updated_by { get; set; }
        public int modified_count { get; set; }

        public Faculty Faculties { get; set; }
        public ICollection<StudentMajor> StudentsMajors { get; set; }
    }
}
