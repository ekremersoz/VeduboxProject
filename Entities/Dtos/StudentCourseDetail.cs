using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class StudentCourseDetail : IDto
    {
        public string StudentEmail { get; set; }
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseFinishDate { get; set; }
        public string TeacherName { get; set; }
    }
}
