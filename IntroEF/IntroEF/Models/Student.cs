﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroEF.Models
{
    public class Student
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dob { get; set; }
        public string email { get; set; }
    }
}