using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Practise.Domain;

namespace Serialization_Practise.DataAccess
{
    interface IPupilDataAccess
    {
        void SavePupils(List<Pupil> pupils);
        List<Pupil> GetPupils();
    }
}
