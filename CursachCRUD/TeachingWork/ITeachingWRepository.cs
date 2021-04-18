﻿using System.Collections.Generic;

namespace CursachCRUD.TeachingWork
{
    public interface ITeachingWRepository
    {

        public TeachingWorkModel GetTeachingWorkByTeachID(int id);

        public TeachingWorkModel GetTeachingWorkByWorkID(int id);

        public bool AddWork(TeachingWorkModel work);

        public bool UpdateWork(TeachingWorkModel updWork);
    }
}
