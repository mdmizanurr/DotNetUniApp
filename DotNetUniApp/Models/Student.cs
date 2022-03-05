﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotNetUniApp.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
       

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}