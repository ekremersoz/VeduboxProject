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
    public class StudentsController : ControllerBase
    {
        IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }



        [HttpGet("GetAllStudent")]
        public IActionResult GetAllStudent()
        {
            var result = _studentService.GetAllStudent();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetStudentsByName")]
        public IActionResult GetAllSGetStudentsByNametudent(string studentName)
        {
            var result = _studentService.GetStudentsByName(studentName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("GetAllStudentCourseDetail")]
        public IActionResult GetAllStudentCourseDetail()
        {
            var result = _studentService.GetAllStudentCourseDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("AddStudent")]
        public IActionResult AddStudent(Student student)
        {
            var result = _studentService.AddStudent(student);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpPost("UpdateStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            var result = _studentService.UpdateStudent(student);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpPost("DeleteStudent")]
        public IActionResult DeleteStudent(Student student)
        {
            var result = _studentService.DeleteStudent(student);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



    }
}
