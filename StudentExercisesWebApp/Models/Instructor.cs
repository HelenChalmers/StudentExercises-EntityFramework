using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace StudentExercisesWebApp.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        [Display(Name = "FirstName")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Instructor's Cohort")]
        [Required(ErrorMessage = "Please select a corhort")]
        public int CohortId { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
    }
}
