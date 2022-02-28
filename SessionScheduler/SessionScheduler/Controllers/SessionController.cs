using Microsoft.AspNetCore.Mvc;
using SessionScheduler.DAO;
using SessionScheduler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly SessionDAO sessionDAO;
        public SessionController(SessionDAO sessionDAO)
        {
            this.sessionDAO = sessionDAO;
        }
        [HttpPost]
        [Route("Save")]
        public IActionResult Save(Session data)
        {
            return Ok(sessionDAO.SaveSession(data));
        }
        [HttpPost]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(sessionDAO.DeleteSession(id));
        }
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            return Ok(sessionDAO.GetAllSession());
        }
        [HttpGet]
        [Route("GetByCourseId/{id}")]
        public IActionResult ByCourseId(int id)
        {
            return Ok(sessionDAO.GetSessionByCourseId(id));
        }
    }
}
