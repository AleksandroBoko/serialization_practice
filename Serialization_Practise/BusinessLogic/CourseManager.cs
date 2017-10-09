using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Practise.Domain;
using Serialization_Practise.Storage;
using Serialization_Practise.DataAccess;

namespace Serialization_Practise.BusinessLogic
{
    class CourseManager : ICourseManager
    {
        ICourseDataAccess courseAccess;

        public CourseManager() 
        {
            courseAccess = new CourseDataAccess();
        }

        public void AddCourse(Course course)
        {

            MemoryStorage.Courses.Add(course);
        }

        public void SaveCourse()
        {
            courseAccess.SaveCourses(MemoryStorage.Courses);
        }

        public void GetCourses()
        {
            MemoryStorage.Courses = courseAccess.GetCourses();
        }

        public IEnumerable<Course> GetCoursesByName(string name)
        {
            return MemoryStorage.Courses.Where(course => course.Name.Equals(name));
        }

    }
}
