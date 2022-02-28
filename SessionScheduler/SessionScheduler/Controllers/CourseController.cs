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
    public class CourseController : ControllerBase
    {
        private readonly CourseDAO courseDAO;
        public CourseController(CourseDAO courseDAO)
        {
            this.courseDAO = courseDAO;
        }
        [HttpPost]
        [Route("Save")]
        public IActionResult Save(Course data)
        {
            return Ok(courseDAO.SaveCourse(data));
        }
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            return Ok(courseDAO.GetAllCourse());
        }
        [HttpGet]
        [Route("Get/{name}")]
        public IActionResult GetByName(string name)
        {
            return Ok(courseDAO.GetCourseByName(name));
        }
    }
}
