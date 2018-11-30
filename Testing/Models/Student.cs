using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Testing.Models
{
    public class Student
    {
        [Key]
        public string Name { get; set; }
        public int Index { get; set; }
        public int Age { get; set; }
    }
}