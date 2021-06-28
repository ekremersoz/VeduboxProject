using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICourseDetailService
    {
        IDataResult<List<CourseDetail>> GetAllCourseDetail();
        IDataResult<CourseDetail> GetCoruseDetailByCourseId(int courseId);
        IResult AddCourseDetail(CourseDetail courseDetail);
        IResult UpdateCourseDetail(CourseDetail courseDetail);
    }
}
