namespace Library.Interfaces
{
    public interface IStudentManager
    {
        void AddNewStudent();
        void ViewStudentDetails(string studentID);
        void DeleteStudent(string studentID);
        void AddSemester(string studentID);
        void LoadStudentsFromJson();
        void SaveStudentsToJson();  
    }
}