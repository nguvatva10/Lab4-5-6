using Lab4_5_6s7.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Lab4_5_6s7.Controllers.Api
{
    public class CoursesController :ApiController
    {
        private ApplicationDbContext _dbContext { get; set; }

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            string userId = User.Identity.GetUserId();
            var course = _dbContext.Courses.Single(c => c.Id == id && c.LecturerId == userId);

            if (course.IsCanceled)
             return NotFound();
            course.IsCanceled = true;
            _dbContext.SaveChanges();

            return Ok();

        }
    }
}