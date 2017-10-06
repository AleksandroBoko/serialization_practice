using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Practise.Domain;

namespace Serialization_Practise.DataAccess
{
    interface ICourseDataAccess
    {
        void SaveCourses(List<Course> courses);
        List<Course> GetCourses();
    }
}
