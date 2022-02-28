using EmpAuth.Model;
using SessionScheduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionScheduler.DAO
{
    public interface CourseDAO
    {
        public Response SaveCourse(Course obj);
        public Response GetCourseByName(string name);
        public Response GetAllCourse();

    }
}
