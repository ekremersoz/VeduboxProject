using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
        [SecuredOperation("admin,teacher")]
        [ValidationAspect(typeof(CourseDetailValidator))]
        public IResult AddCourseDetail(CourseDetail courseDetail)
        {
            _courseDetailDal.Add(courseDetail);
            return new SuccessResult(Messages.AddedCourseDetail);

        }

        [SecuredOperation("admin,teacher,student")]
        public IDataResult<List<CourseDetail>> GetAllCourseDetail()
        {
            return new SuccessDataResult<List<CourseDetail>>(_courseDetailDal.GetAll() , Messages.ListedCourseDetail);
        }

        [SecuredOperation("admin,teacher,student")]
        public IDataResult<CourseDetail> GetCoruseDetailByCourseId(int courseId)
        {
            return new SuccessDataResult<CourseDetail>(_courseDetailDal.Get(c=>c.CourseId == courseId));
        }
        [ValidationAspect(typeof(CourseDetailValidator))]
        [SecuredOperation("admin,teacher")]
        public IResult UpdateCourseDetail(CourseDetail courseDetail)
        {
            _courseDetailDal.Update(courseDetail);
            return new SuccessResult(Messages.UpdatedCourseDetail);
        }
    }
}
