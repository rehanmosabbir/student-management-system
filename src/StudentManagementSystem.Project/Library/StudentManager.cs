using Library;
using Newtonsoft.Json;
using Library.Interfaces;
using Library.Enums;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem
{
    public class StudentManager : IStudentManager
    {
        private List<Student> students = new List<Student>();

        private List<Course> allCourses = new List<Course>
        {
            new Course { CourseId = "CSC 101", CourseName = "Introduction to Computer Science", InstructorName = "Prof. Smith", NumberOfCredits = 3 },
            new Course { CourseId = "CSC 102", CourseName = "Introduction to Computer Science",InstructorName= "Dr. Smith",NumberOfCredits = 3},
            new Course { CourseId = "CSC 103", CourseName = "Data Structures and Algorithms",InstructorName= "Prof. Johnson",NumberOfCredits = 4},
            new Course { CourseId = "CSC 201", CourseName = "Artificial Intelligence",InstructorName= "Dr. Williams",NumberOfCredits = 3},
            new Course { CourseId = "CSC 202", CourseName = "Database Management",InstructorName= "Prof. Brown",NumberOfCredits = 3},
            new Course { CourseId = "CSC 203", CourseName = "Web Development",InstructorName= "Dr. Davis",NumberOfCredits = 4},
            new Course { CourseId = "ENG 201", CourseName = "English Literature", InstructorName = "Prof. Johnson", NumberOfCredits = 4 },
            new Course { CourseId = "ENG 101", CourseName = "English Grammar", InstructorName = "Prof. Smith", NumberOfCredits = 3 },
            new Course { CourseId = "ENG 102", CourseName = "English Literature", InstructorName = "Dr. Johnson", NumberOfCredits = 4 },
            new Course { CourseId = "ENG 103", CourseName = "Creative Writing", InstructorName = "Prof. Williams", NumberOfCredits = 3 },
            new Course { CourseId = "ENG 104", CourseName = "Public Speaking", InstructorName = "Dr. Brown", NumberOfCredits = 3 },
            new Course { CourseId = "ENG 105", CourseName = "Professional Communication", InstructorName = "Dr. Davis", NumberOfCredits = 4 },
            new Course { CourseId = "ENG 106", CourseName = "Language and Culture", InstructorName = "Prof. Martinez", NumberOfCredits = 3 },
            new Course { CourseId = "ENG 107", CourseName = "Technical Writing", InstructorName = "Dr. Garcia", NumberOfCredits = 4 },
            new Course { CourseId = "ENG 108", CourseName = "English for Business", InstructorName = "Prof. Taylor", NumberOfCredits = 3 },
            new Course { CourseId = "ENG 109", CourseName = "Academic Writing", InstructorName = "Dr. Clark", NumberOfCredits = 3 },
            new Course { CourseId = "ENG 110", CourseName = "Media and Communication", InstructorName = "Prof. Adams", NumberOfCredits = 4 },
            new Course { CourseId = "BBA 101", CourseName = "Principles of Management", InstructorName = "Prof. Smith", NumberOfCredits = 3 },
            new Course { CourseId = "BBA 102", CourseName = "Marketing Management", InstructorName = "Dr. Johnson", NumberOfCredits = 4 },
            new Course { CourseId = "BBA 103", CourseName = "Financial Accounting", InstructorName = "Prof. Williams", NumberOfCredits = 3 },
            new Course { CourseId = "BBA 104", CourseName = "Business Communication", InstructorName = "Dr. Brown", NumberOfCredits = 3 },
            new Course { CourseId = "BBA 105", CourseName = "Organizational Behavior", InstructorName = "Dr. Davis", NumberOfCredits = 4 },
            new Course { CourseId = "BBA 106", CourseName = "Business Ethics", InstructorName = "Prof. Martinez", NumberOfCredits = 3 },
            new Course { CourseId = "BBA 107", CourseName = "Managerial Economics", InstructorName = "Dr. Garcia", NumberOfCredits = 4 },
            new Course { CourseId = "BBA 108", CourseName = "Entrepreneurship", InstructorName = "Prof. Taylor", NumberOfCredits = 3 },
            new Course { CourseId = "BBA 109", CourseName = "Human Resource Management", InstructorName = "Dr. Clark", NumberOfCredits = 3 },
            new Course { CourseId = "BBA 110", CourseName = "Operations Management", InstructorName = "Prof. Adams", NumberOfCredits = 4 },
        };

        public void AddNewStudent()
        {
            // Implementation for adding a new student
            Student newStudent = new Student();

            Console.WriteLine("Please fill all the necessary informations:");
            Console.WriteLine();

            Console.Write("Enter First Name: ");
            newStudent.FirstName = Console.ReadLine();

            Console.Write("Enter Middle Name: ");
            newStudent.MiddleName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            newStudent.LastName = Console.ReadLine();

            Console.Write("Enter Student ID (eg. 091-352-041): ");
            newStudent.StudentId = Console.ReadLine();

            bool isFoundBatch = true;

            while (isFoundBatch)
            {
                Console.Write("Enter Joining Batch(Spring,Summer,Fall): ");
                var joiningBatch = Console.ReadLine();


                foreach (var batch in (SemesterCode[])Enum.GetValues(typeof(SemesterCode)))
                {
                    if (batch.ToString() == joiningBatch)
                    {
                        isFoundBatch = false;
                    }
                }
                if (isFoundBatch)
                {
                    Console.WriteLine("Please enter valid joining batch");
                }
                else
                {
                    newStudent.JoiningBatch = joiningBatch;
                    isFoundBatch = false;

                }
            }


            bool isFoundDepartment = true;

            while (isFoundDepartment)
            {
                Console.Write("Enter Department (ComputerScience, BBA, English): ");
                string department = Console.ReadLine();


                foreach (var dept in (Department[])Enum.GetValues(typeof(Department)))
                {
                    if (dept.ToString() == department)
                    {
                        isFoundDepartment = false;
                    }
                }
                if (isFoundDepartment)
                {
                    Console.WriteLine("Please enter valid Department");
                }
                else
                {
                    Enum.TryParse(department, out Department dept);
                    newStudent.Department = dept;
                    isFoundDepartment = false;

                }
            }

            //Console.Write("Enter Department (ComputerScience, BBA, English): ");
            //Enum.TryParse(Console.ReadLine(), out Department department);
            //newStudent.Department = department;



            bool isFoundDegree = true;

            while (isFoundDegree)
            {
                Console.Write("Enter Degree (BSC, BBA, BA, MSC, MBA, MA): ");
                string degree = Console.ReadLine();


                foreach (var deg in (Degree[])Enum.GetValues(typeof(Degree)))
                {
                    if (deg.ToString() == degree)
                    {
                        isFoundDegree = false;
                    }
                }
                if (isFoundDegree)
                {
                    Console.WriteLine("Please enter valid Degree");
                }
                else
                {
                    Enum.TryParse(degree, out Degree deg);
                    newStudent.Degree = deg;
                    isFoundDegree = false;

                }
            }

            //Console.Write("Enter Degree (BSC, BBA, BA, MSC, MBA, MA): ");
            //Enum.TryParse(Console.ReadLine(), out Degree degree);
            //newStudent.Degree = degree;



            var validationResults = new System.Collections.Generic.List<ValidationResult>();
            var validationContext = new ValidationContext(newStudent, null, null);

            bool isValid = Validator.TryValidateObject(newStudent, validationContext, validationResults, true);

            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }

            }
            else
            {
                students.Add(newStudent);
                Console.WriteLine();
                Console.WriteLine("Student Added Successfully");
                SaveStudentsToJson();
            }
        }

        public void ViewStudentDetails(string studentID)
        {
            // Implementation for viewing student details
            var student = students.FirstOrDefault(s => s.StudentId == studentID);
            if (student != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Student Details for ID: {studentID}");
                Console.WriteLine($"Name: {student.FirstName} {student.MiddleName} {student.LastName}");
                Console.WriteLine($"Student ID: {student.StudentId}");
                Console.WriteLine($"Joining Batch: {student.JoiningBatch}");
                Console.WriteLine($"Department: {student.Department}");
                Console.WriteLine($"Degree: {student.Degree}");

                // Display Semesters and Courses attended
                foreach (var semester in student.SemestersAttended)
                {
                    Console.WriteLine($"Semester: {semester.SemesterCode} {semester.Year}");
                    foreach (var course in semester.Courses)
                    {
                        Console.WriteLine($"Course ID: {course.CourseId}, Course Name: {course.CourseName}, Credits: {course.NumberOfCredits}, Instructor: {course.InstructorName}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void DeleteStudent(string studentID)
        {
            // Implementation for deleting a student
            var student = students.FirstOrDefault(s => s.StudentId == studentID);

            Console.WriteLine();
            if (student != null)
            {
                students.Remove(student);
                SaveStudentsToJson();
                Console.WriteLine($"Student with ID {studentID} deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void AddSemester(string studentID)
        {
            // Implementation for adding a new semester to the student and adding courses
            var student = students.FirstOrDefault(s => s.StudentId == studentID);


            if (student != null)
            {
                string studentDepartment = student.Department.ToString();
                Semester newSemester = new Semester();

                Console.Write("Enter Semester Code (Summer, Fall, Spring): ");
                Enum.TryParse(Console.ReadLine(), out SemesterCode semesterCode);
                newSemester.SemesterCode = semesterCode;// Spring

                Console.Write("Enter Year (YYYY): ");
                newSemester.Year = Console.ReadLine();

                var matchedCourses = allCourses.Where(course => course.CourseId.StartsWith(studentDepartment.Substring(0, 1))).ToList();

                // Display courses not taken by the student
                var coursesNotTaken = matchedCourses.Where(course => !student.SemestersAttended.Any(semester => semester.Courses.Any(c => c.CourseId == course.CourseId))).ToList();
                Console.WriteLine();
                Console.WriteLine("Available Courses:");
                foreach (var course in coursesNotTaken)
                {
                    Console.WriteLine($"Course ID: {course.CourseId}, Course Name: {course.CourseName}");
                }
                Console.WriteLine();
                Console.Write("Enter Course ID to add (XXX YYY): ");
                var selectedCourseID = Console.ReadLine();
                var selectedCourse = coursesNotTaken.FirstOrDefault(course => course.CourseId == selectedCourseID);
                if (selectedCourse != null)
                {
                    // Add the selected course to the new semester for the student
                    newSemester.Courses.Add(selectedCourse);
                    student.SemestersAttended.Add(newSemester);
                    SaveStudentsToJson();
                    Console.WriteLine();
                    Console.WriteLine($"Course {selectedCourseID} added to the student {studentID} for the semester.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Course not found or already taken by the student.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Student not found.");
            }
        }

        public void LoadStudentsFromJson()
        {
            // Implementation for loading students from JSON file
            try
            {
                string json = File.ReadAllText("../../../students.json");
                students = JsonConvert.DeserializeObject<List<Student>>(json);
            }
            catch (FileNotFoundException)
            {
                // Create an empty file if it doesn't exist
                File.WriteAllText("../../../students.json", "[]");
            }
        }

        public void SaveStudentsToJson()
        {
            // Implementation for saving students to JSON file
            string json = JsonConvert.SerializeObject(students, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("../../../students.json", json);
        }
    }
}
