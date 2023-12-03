using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Enums;
namespace Library
{
    public class Student
    {
        public string? StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public Department Department { get; set; }
        public Degree Degree { get; set; }
        public string? JoiningBatch { get; set; }
        public List<Semester> SemestersAttended { get; set; } = new List<Semester>();
    }
}
