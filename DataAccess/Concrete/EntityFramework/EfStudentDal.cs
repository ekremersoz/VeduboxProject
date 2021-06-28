using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Utilities.Results;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, VeduboxProjectContext>, IStudentDal
    {
        public List<StudentCourseDetail> StudentCourseDetail()
        {
            using (VeduboxProjectContext context = new VeduboxProjectContext())
            {
                var result = from student in context.Students
                             join course in context.Courses on student.CourseId equals course.CourseId
                             join teacher in context.Teachers on course.TeacherId equals teacher.TeacherId
                             select new StudentCourseDetail { StudentName = student.StudentName, StudentEmail = student.Email, CourseName = course.CourseName, CourseStartDate = course.StartDate, CourseFinishDate = course.FinishDate, TeacherName = teacher.TeacherName };
                return result.ToList();
            }
        }
    }
}
