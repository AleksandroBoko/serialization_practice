using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Practise.Domain;

namespace Serialization_Practise.BusinessLogic
{
    interface IPupilManager
    {
        void AddPupil(Pupil pupil);
        //void RemoveUser();
        void SavePupil();
    }
}
