using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using VSLangProj;

namespace JobApplicationPoster.Models
{
    public class Application
    {
        [Key]
        public int Identy { get; set; }

        [Display(Name = "Company Name")]
        public string Company { get; set; }

        [Display(Name = "Job Position")]
        public string Title { get; set; }
        public string Location { get; set; }
        public int? Sticker { get; set; }

        public int? StudentId { get; set; }
        [ForeignKey("StudentIdentification")]

        public virtual Student studentObj { get; set; }

    }
}
