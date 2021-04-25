using System.Collections.Generic;

namespace CursachCRUD.Lecturer
{
    public interface ILecturerRepository
    {
        public IEnumerable<LecturerModel> GetAllLecturers();

        public LecturerModel GetLecturerByLecId(int id);

        public bool AddLecturer(LecturerModel lecturer);

        public bool UpdateLecturerAchivements(string achiv, int lecId);

        public bool UpdateLecturerPublications(string publ, int lecId);

        public bool UpdateLecturerTeachingInfo(string teacInf, int lecId);

        public bool UpdateLecturerPhoto(byte[] photo, int lecId);

    }
}
