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
    public class TeachersController : ControllerBase
    {
        ITeacherService _teacherService;
        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("GetAllTeachers")]
        public IActionResult GetAllTeachers()
        {
            var result = _teacherService.GetAllTeachers();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("GetTeacherByName")]
        public IActionResult GetTeacherByName(string teacherName)
        {
            var result = _teacherService.GetTeacherByName(teacherName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpPost("AddTeacher")]
        public IActionResult AddTeacher(Teacher teacher)
        {
            var result = _teacherService.AddTeacher(teacher);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpPost("UpdateTeacher")]
        public IActionResult UpdateTeacher(Teacher teacher)
        {
            var result = _teacherService.UpdateTeacher(teacher);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpPost("DeleteTeacher")]
        public IActionResult DeleteTeacher(Teacher teacher)
        {
            var result = _teacherService.DeleteTeacher(teacher);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
