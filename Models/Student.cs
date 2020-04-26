using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationPoster.Models
{
    public class Student
    {
        [Key]
        public int AutoId { get; set; }

        [Display(Name = "Full Name")]
        [Required]
        public string FullName { get; set; }

        public string Address { get; set; }

        [Display(Name = "Current Title")]
        public string Title { get; set; }
        public int? Total { get; set; }
        public virtual List<Application> applicationObj { get; set; }
    }
}
