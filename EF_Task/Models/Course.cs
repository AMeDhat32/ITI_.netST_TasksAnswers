﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string? Name { get; set; }
      
    }
}
