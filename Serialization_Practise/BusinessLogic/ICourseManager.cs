using Serialization_Practise.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Practise.BusinessLogic
{
    interface ICourseManager
    {
        void AddCourse(Course pupil);
        //void RemoveUser();
        void SaveCourse();
    }
}
