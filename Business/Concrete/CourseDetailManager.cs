using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CourseDetailManager : ICourseDetailService
    {
        ICourseDetailDal _courseDetailDal;
        public CourseDetailManager(ICourseDetailDal courseDetailDal)
        {
            _courseDetailDal = courseDetailDal;
        }
        public IResult AddCourseDetail(CourseDetail courseDetail)
        {
            _courseDetailDal.Add(courseDetail);
            return new SuccessResult(Messages.AddedCourseDetail);

        }

        public IDataResult<List<CourseDetail>> GetAllCourseDetail()
        {
            return new SuccessDataResult<List<CourseDetail>>(_courseDetailDal.GetAll() , Messages.ListedCourseDetail);
        }

        public IDataResult<CourseDetail> GetCoruseDetailByCourseId(int courseId)
        {
            return new SuccessDataResult<CourseDetail>(_courseDetailDal.Get(c=>c.CourseId == courseId));
        }

        public IResult UpdateCourseDetail(CourseDetail courseDetail)
        {
            _courseDetailDal.Update(courseDetail);
            return new SuccessResult(Messages.UpdatedCourseDetail);
        }
    }
}
