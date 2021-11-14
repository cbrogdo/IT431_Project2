using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasonDatabase_Project2.Models
{
    public class Application
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Must be less than 50 characters")]
        [RegularExpression(@"^[a-z,A-Z, ]*$", ErrorMessage = "First Name must contain only letters or a space")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(25, ErrorMessage = "Must be less than 25 characters")]
        [RegularExpression(@"^[a-z,A-Z, ]*$", ErrorMessage = "Middle Name must contain only letters or a space")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
       
        [Required]
        [MaxLength(50, ErrorMessage = "Must be less than 50 characters")]
        [RegularExpression(@"^[a-z,A-Z,-, ]*$", ErrorMessage = "Last Name must contain only letters, a hyphen, or space")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(11, ErrorMessage = "Must be exactly 11 characters")]
        [MinLength(11, ErrorMessage = "Must be exactly 11 characters")]
        [RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        // [RegularExpression(@"[1-9]{1}\d{2}-\d{2}-\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        [Display(Name = "Social Security Number (123-45-6789)")]

        public string  SSN { get; set; }

        [Required]
        //[RegularExpression(@"^[a-z,A-Z,@,.,_]*$", ErrorMessage = "Invalid Email Address")]
        //[RegularExpression(@"^[a - z, A - Z,., _] *$[@] [a-z]*$[.] [a-z]", ErrorMessage = "Invalid Email Address")]
        [RegularExpression(@"^[a - z, A - Z,., _] *[@][a - z] *[.][a - z]3$")]

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Must be less than 20 characters")]
        [MinLength(12, ErrorMessage = "Must be 12 or more characters")]
        [RegularExpression(@"^\d{10}|\d{3}-\d{3}-\d{4}$", ErrorMessage = "Invalid Phone Number")]
        // [RegularExpression(@"[1-9]{1}\d{3}-\d{3}-\d{4}$", ErrorMessage = "Invalid Phone Number")]
        [Display(Name = "Home Phone Number (123-456-7890)")]
        public string HomePhone { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Must be less than 20 characters")]
        [MinLength(12, ErrorMessage = "Must be 12 or more characters")]
        [RegularExpression(@"^\d{10}|\d{3}-\d{3}-\d{4}$", ErrorMessage = "Invalid Phone Number")]
        // [RegularExpression(@"[1-9]{1}\d{3}-\d{3}-\d{4}$", ErrorMessage = "Invalid Phone Number")]
        [Display(Name = "Cell Phone Number (123-456-7890)")]
        public string CellPhone { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Must be less than 100 characters")]
        [Display(Name = "Street Address")]
        public string Street { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Must be less than 50 characters")]
        [Display(Name ="City")]
        public string City { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "Must be exactly 2 characters")]
        [Display(Name ="State Abbreviation (ex. VA)")]
        public string State { get; set; }

        [Required]
        [MaxLength(5, ErrorMessage = "Must be exactly 5 numbers") ]
        [RegularExpression(@"^[0-9]*$", ErrorMessage ="Must contain only numbers")]

        public string ZipCode { get; set; }

        [Required]
        [Display(Name ="Date of Birth")]
        public DateTime DOB { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [RegularExpression(@"^[a-z,A-Z,-, ]*$", ErrorMessage ="Name must contain letters, a hyphen, or space")]
        [Display(Name ="High School Name")]
        public string SchoolName { get; set; }

        [Required]
        [RegularExpression(@"^[a-z,A-Z,-, ]*$", ErrorMessage = "City must contain letters, a hyphen, or space")]
        [Display(Name ="High School City")]
        public string SchoolCity { get; set; }

        [Required]
        [Display(Name ="High School Graduation Date")]

        public DateTime GradDate { get; set; }

        [Required]
       // [RegularExpression(@"^[0 - 4]\.\d{2}$/")]
        [RegularExpression(@"[0-4]*(.[0-9][0-9]*)?$", ErrorMessage = "GPA must be between 0.0 to 4.0")]
        //Sliding Scale??
        public int GPA { get; set; }

        [Required]
        [RegularExpression(@"^[0 - 800]*$", ErrorMessage = "Must be between 0 and 800")]
        [Display(Name ="SAT Math Score")]
        public int SATMath { get; set; }

        [Required]
        [RegularExpression(@"[0-8]$|^ [0-9] [0-9]$|^(800)$", ErrorMessage = "Must be between 0 and 800")]
      
        [Display(Name = "SAT Verbal Score")]
        public int SATVerbal { get; set; }

        [Required]
        [Display(Name = "Primary Area of Interest (Major)")]
        public string[] Major { get; set; }

        [Required]
        [Display(Name = "Prospective Enrollment Semester ")]
        public string EnrollSem { get; set; }

        [Required]
        
        [Display(Name ="Prospective Enrollment Year")]
        //[RegularExpression(@"^\d{4}[2022 - 2999]", ErrorMessage = "Cannot be prior to 2022 or after 2999")]
        [RegularExpression("([2][0-9][0-9][0-9])", ErrorMessage = "Cannot be prior to 2022 or after 2999")]
        public int EnrollYear { get; set; }

    }
}