using System.Collections.Generic;

namespace CursachCRUD.Lecturer
{
    public interface ILecturerRepository
    {
        public IEnumerable<LecturerModel> GetAllLecturers();

        public LecturerModel GetLecturerByLecId(int id);

        public bool AddLecturer(LecturerModel lecturer);

        public bool UpdateLecturer(LecturerModel updLec);

        
    }
}
