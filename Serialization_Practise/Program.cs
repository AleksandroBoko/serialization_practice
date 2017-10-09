using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization_Practise.BusinessLogic;
using Serialization_Practise.Storage;

namespace Serialization_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            InitStoreManager();
            StartProgramm();

            Console.ReadKey();
        }

        static void StartProgramm()
        {
            CourseManager cm = new CourseManager();
            cm.GetCourses();


            //var elements = from e in MemoryStorage.Courses.ToList()
            //               where e.Name.Equals("JS")
            //               orderby e.Level
            //               select e;

            //elements.ToList().ForEach(course => Console.WriteLine($"{course.Id} {course.Name} {course.Level}"));

            (from e in MemoryStorage.Courses.ToList()
             where e.Name.Equals("DotNet") && e.Level%2 == 0
             orderby e.Level
             select e).ToList().ForEach(course => Console.WriteLine($"{course.Id} {course.Name} {course.Level}"));

            //MemoryStorage.Courses.ToList().ForEach(course => Console.WriteLine($"{course.Id} {course.Name} {course.Level}"));
        }

        static void InitStoreManager()
        {
            MemoryStorage.Courses = new List<Domain.Course>();
            MemoryStorage.Pupils = new List<Domain.Pupil>();
        }

        static void AddCourses()
        {
            CourseManager cm = new CourseManager();

            cm.AddCourse(new Domain.Course { Id = Guid.NewGuid(), Name = "DotNet", Level = 1 });
            cm.AddCourse(new Domain.Course { Id = Guid.NewGuid(), Name = "DotNet", Level = 2 });
            cm.AddCourse(new Domain.Course { Id = Guid.NewGuid(), Name = "DotNet", Level = 3 });
            cm.AddCourse(new Domain.Course { Id = Guid.NewGuid(), Name = "DotNet", Level = 4 });
            cm.AddCourse(new Domain.Course { Id = Guid.NewGuid(), Name = "JS", Level = 1 });
            cm.AddCourse(new Domain.Course { Id = Guid.NewGuid(), Name = "JS", Level = 2 });
            cm.AddCourse(new Domain.Course { Id = Guid.NewGuid(), Name = "PHP", Level = 1 });
            cm.AddCourse(new Domain.Course { Id = Guid.NewGuid(), Name = "PHP", Level = 2 });

            cm.SaveCourse();
            //cm.GetCoursesByName("DotNet").ToList().ForEach(course => Console.WriteLine(course));
        }

        static void AddPupils()
        {
            PupilManager pm = new PupilManager();

            pm.AddPupil(new Domain.Pupil() { Id = Guid.NewGuid(), Name = "Igor", Age = 18 });
            pm.AddPupil(new Domain.Pupil() { Id = Guid.NewGuid(), Name = "Egor", Age = 21 });
            pm.AddPupil(new Domain.Pupil() { Id = Guid.NewGuid(), Name = "Masha", Age = 19 });
            pm.AddPupil(new Domain.Pupil() { Id = Guid.NewGuid(), Name = "Lena", Age = 20 });
            pm.AddPupil(new Domain.Pupil() { Id = Guid.NewGuid(), Name = "Timur", Age = 25 });
            pm.AddPupil(new Domain.Pupil() { Id = Guid.NewGuid(), Name = "Ivan", Age = 30 });

            pm.SavePupil();
            pm.GetPupils();
            MemoryStorage.Pupils.Where(pupil => pupil.Age > 20).ToList().ForEach(pupil => Console.WriteLine($"{pupil.Id} {pupil.Name} {pupil.Age}"));
        }

    }
}
