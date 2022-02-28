using EmpAuth.Model;
using SessionScheduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionScheduler.DAO
{
    public interface SessionDAO
    {
        public Response SaveSession(Session obj);
        public Response GetSessionByCourseId(int id);
        public Response GetAllSession();
        public Response DeleteSession(int id);

    }
}
