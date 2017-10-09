using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Practise.Domain;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Serialization_Practise.DataAccess
{
    class CourseDataAccess : ICourseDataAccess
    {
        public void SaveCourses(List<Course> courses)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Course>));

            using (FileStream fs = new FileStream("D://Courses.json",FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, courses);
            }
        }

        public List<Course> GetCourses()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Course>));

            using (FileStream fs = new FileStream("D://Courses.json", FileMode.OpenOrCreate))
            {
                return (List<Course>)jsonFormatter.ReadObject(fs);
            }
        }
    }
}
