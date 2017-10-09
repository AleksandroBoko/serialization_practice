using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Practise.Domain;
using Serialization_Practise.Storage;
using Serialization_Practise.DataAccess;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Serialization_Practise.BusinessLogic
{
    class PupilManager : IPupilManager
    {
        IPupilDataAccess pupilAccess;

        public PupilManager()
        {
            pupilAccess = new PupilDataAccess();
        }

        public void AddPupil(Pupil pupil)
        {
            MemoryStorage.Pupils.Add(pupil);
        }

        public void SavePupil()
        {
            pupilAccess.SavePupils(MemoryStorage.Pupils);
        }

        public void GetPupils()
        {
            MemoryStorage.Pupils = pupilAccess.GetPupils();
        }

        public IEnumerable<Pupil> GetPupilByName(string name)
        {
            return MemoryStorage.Pupils.Where(pupil => pupil.Name.Equals(name));
        }
    }
}
