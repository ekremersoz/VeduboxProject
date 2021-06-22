using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }



        [HttpGet("GetAllCourse")]
        public IActionResult GetAllCourse()
        {
            Thread.Sleep(1000);
            var result = _courseService.GetAllCourse();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("GetAllByCourseName")]
        public IActionResult GetAllByCourseName(string courseName)
        {
            var result = _courseService.GetAllByCourseName(courseName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("GetAllCourseByLessThanFee")]
        public IActionResult GetAllCourseByLessThanFee(int fee)
        {
            var result = _courseService.GetAllCourseByLessThanFee(fee);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("GetAllCourseByTeacherId")]
        public IActionResult GetAllCourseByTeacherId(int teacherId)
        {
            var result = _courseService.GetAllCourseByTeacherId(teacherId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpGet("GetAllCourseBetweenStartandFinishDate")]
        public IActionResult GetAllCourseBetweenStartandFinishDate(DateTime startDate, DateTime finishDate)
        {
            var result = _courseService.GetAllCourseBetweenStartandFinishDate(startDate,finishDate);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpPost("AddCourse")]
        public IActionResult AddCourse(Course course)
        {
            var result = _courseService.AddCourse(course);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpPost("UpdateCourse")]
        public IActionResult UpdateCourse(Course course)
        {
            var result = _courseService.UpdateCourse(course);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }





        [HttpPost("DeleteCourse")]
        public IActionResult DeleteCourse(Course course)
        {
            var result = _courseService.DeleteCourse(course);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
