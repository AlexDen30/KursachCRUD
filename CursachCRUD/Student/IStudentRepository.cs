using System.Collections.Generic;

namespace CursachCRUD.Student
{
    public interface IStudentRepository
    {
        public IEnumerable<StudentModel> GetAllStudents();

        public StudentModel GetStudentByStudId(int id);

        public bool AddStudent(StudentModel student);

        public bool UpdateStudent(StudentModel upStudent);
    }
}
