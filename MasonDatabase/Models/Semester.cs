using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasonDatabase.Models
{
    public class Semester
    {
        [Required]
        [Key]
        public int ID { get; set; }


        [Required]
        [Display(Name = "Prospective Enrollment Semester ")]
        public string EnrollSem { get; set; }

        public virtual ICollection<Application> Application { get; set; }
    }
}