using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Enums;
namespace Library
{
    public class Student
    {
        [Required(ErrorMessage = "Student ID is required.")]
        public string? StudentId { get; set; }
        [Required(ErrorMessage = "FirstName is required.")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "MiddleName is required.")]
        public string? MiddleName { get; set; }
        [Required(ErrorMessage = "LastName is required.")]
        public string? LastName { get; set; }

        public Department Department { get; set; }

        public Degree Degree { get; set; }
        [Required(ErrorMessage = "JoiningBatch is required.")]
        public string? JoiningBatch { get; set; }
        public List<Semester> SemestersAttended { get; set; } = new List<Semester>();
    }
}
