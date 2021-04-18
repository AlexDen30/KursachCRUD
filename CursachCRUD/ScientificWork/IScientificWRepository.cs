using System.Collections.Generic;

namespace CursachCRUD.ScientificWork
{
    public interface IScientificWRepository
    {
        public IEnumerable<ScientificWorkModel> GetAllWorksByUserId(int id);

        public ScientificWorkModel GetTeachingWorkByWorkID(int id);

        public bool AddWork(ScientificWorkModel work);

        public bool UpdateWork(ScientificWorkModel updWork);
    }
}
