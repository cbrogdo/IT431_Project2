using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasonDatabase.Models
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
        [Display(Name = "Social Security Number (123-45-6789)")]
        public string SSN { get; set; }


        [Required]
        [RegularExpression("[a-zA-Z0-9._-]+@[a-z]+(\\.)[a-z]{2,3}", ErrorMessage = "Please enter a valid email address")]
        //[RegularExpression(@"^(([^<>()[\]\\.,;:\s@""]+(\.[^<>()[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$", ErrorMessage ="Please enter a valid email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid Email address")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }


        [Required]
        [MaxLength(20, ErrorMessage = "Must be less than 20 characters")]
        [MinLength(12, ErrorMessage = "Must be 12 or more characters")]
        [RegularExpression(@"^\d{10}|\d{3}-\d{3}-\d{4}$", ErrorMessage = "Invalid Phone Number")]
        [Display(Name = "Home Phone Number (123-456-7890)")]
        public string HomePhone { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Must be less than 20 characters")]
        [MinLength(12, ErrorMessage = "Must be 12 or more characters")]
        [RegularExpression(@"^\d{10}|\d{3}-\d{3}-\d{4}$", ErrorMessage = "Invalid Phone Number")]
        [Display(Name = "Cell Phone Number (123-456-7890)")]
        public string CellPhone { get; set; }

        //!!!!!!!!!!!!!!!!!Good through here!!!!!!!!!!!!!!!

        [Required]
        [MaxLength(100, ErrorMessage = "Must be less than 100 characters")]
        [Display(Name = "Street Address")]
        public string Street { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Must be less than 50 characters")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "Must be exactly 2 characters")]
        [Display(Name = "State Abbreviation (ex. VA)")]
        public string State { get; set; }

        [Required]
        [MaxLength(5, ErrorMessage = "Must be exactly 5 numbers")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip Code - Zip Codes must be 5 digits and can only contain numbers")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }


        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }


        [Required]
        public string Gender { get; set; }


        //!!!!!!!!!!!!!!!!!!!!!Working through here!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        [Required]
        [RegularExpression(@"^[a-z,A-Z,-, ]*$", ErrorMessage = "Name must contain letters, a hyphen, or space")]
        [Display(Name = "High School Name")]
        public string SchoolName { get; set; }

        [Required]
        [RegularExpression(@"^[a-z,A-Z,-, ]*$", ErrorMessage = "City must contain letters, a hyphen, or space")]
        [Display(Name = "High School City")]
        public string SchoolCity { get; set; }

        [Required]
        [Display(Name = "High School Graduation Date")]
        public DateTime GradDate { get; set; }


        [Required]
        [Range(0, 4.9, ErrorMessage = "GPA must be between 0.0 to 4.0")]
        //[RegularExpression(@"[0-4]*(.[0-9][0-9]*)?$", ErrorMessage = "GPA must be between 0.0 to 4.0")]
        //Sliding Scale??
        public decimal GPA { get; set; }

        //!!!!!!!!!!!!!!!!!!!!!!Working through here!!!!!!!!!!!!!!!!!!!!!!!!!!!

        [Required]
        //[RegularExpression("[0-7][0-9]{0,2}|800", ErrorMessage = "Must be between 0 and 800")]
        [Range(0, 800, ErrorMessage = "Must be between 0 and 800")]
        [Display(Name = "SAT Math Score")]
        public int SATMath { get; set; }

        [Required]
        [Range(0, 800, ErrorMessage = "Must be between 0 and 800")]
        [Display(Name = "SAT Verbal Score")]
        public int SATVerbal { get; set; }

        [Required]
        [Display(Name = "Primary Area of Interest (Major)")]
        public int? MajorID { get; set; }
        public virtual Major Major { get; set; }

        [Required]
        //drop down list
        [Display(Name = "Prospective Enrollment Semester ")]
        public int? SemesterID { get; set; }
        public virtual Semester Semester { get; set; }

        [Required]
        [Display(Name = "Prospective Enrollment Year")]
        [Range(2022, 2999, ErrorMessage = "Cannot be prior to 2022 or after 2999")]
        public int EnrollYear { get; set; }

        [Required]
        public DateTime SubmitDate { get; set; }

        public int?ListID { get; set; }
        public virtual List List { get; set; }

    }
}