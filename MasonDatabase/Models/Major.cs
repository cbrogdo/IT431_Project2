using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasonDatabase.Models
{
    public class Major
    {
        [Required]
        [Key]
        public int ID { get; set; }
        

        [Required]
        [Display(Name = "Primary Area of Interest (Major)")]
        [MaxLength(100, ErrorMessage = "Major is too long")]
        [RegularExpression(@"^[A-Za-z ,-.']*$")]
        public string MajorOption { get; set; }

        public virtual ICollection<Application> Application { get; set; }
    }

}