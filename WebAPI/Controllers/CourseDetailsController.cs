using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseDetailsController : ControllerBase
    {
        ICourseDetailService _courseDetailService;
        public CourseDetailsController(ICourseDetailService courseDetailService)
        {
            _courseDetailService = courseDetailService;
        }


        [HttpGet("GetAllCourseDetail")]
        public IActionResult GetAllCourseDetail()
        {
            var result = _courseDetailService.GetAllCourseDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetCoruseDetailByCourseId")]
        public IActionResult GetCoruseDetailByCourseId(int courseId)
        {
            var result = _courseDetailService.GetCoruseDetailByCourseId(courseId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("AddCourseDetail")]
        public IActionResult AddCourseDetail(CourseDetail courseDetail)
        {
            var result = _courseDetailService.AddCourseDetail(courseDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpPost("UpdateCourseDetail")]
        public IActionResult UpdateCourseDetail(CourseDetail courseDetail)
        {
            var result = _courseDetailService.UpdateCourseDetail(courseDetail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
