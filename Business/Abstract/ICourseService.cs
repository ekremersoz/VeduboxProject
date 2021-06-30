using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAllCourse();
        IDataResult<List<Course>> GetAllByCourseName(string courseName);
        IDataResult<Course> GetCourseByCourseId(int courseId);
        IDataResult<List<Course>> GetAllCourseByLessThanFee(int fee);
        IDataResult<List<Course>> GetAllCourseByTeacherId(int teacherId);
        IDataResult<List<Course>> GetAllCourseBetweenStartandFinishDate(DateTime startDate, DateTime finishDate);
        IResult AddCourse(Course course);
        IResult UpdateCourse(Course course);
        IResult DeleteCourse(Course course);

    }
}
