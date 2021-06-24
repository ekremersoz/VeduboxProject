using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        IStudentService _studentService;
        public CourseManager(ICourseDal courseDal , IStudentService studentService)
        {
            _courseDal = courseDal;
            _studentService = studentService;

        }

        [ValidationAspect(typeof(CourseValidator))]
        public IResult AddCourse(Course course)
        {
            var result = BusinessRules.Run(CheckStudetnCountForCourseAdd());
            if (result == null)
            {
                _courseDal.Add(course);
                return new SuccessResult(Messages.AddedCourse);
            }
            return result;

        }

        public IResult DeleteCourse(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.DeletedCourse);
        }

        public IDataResult<List<Course>> GetAllByCourseName(string courseName)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.CourseName.Contains(courseName)));
        }

        public IDataResult<List<Course>> GetAllCourse()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(),Messages.ListedCourses);
        }

        public IDataResult<List<Course>> GetAllCourseBetweenStartandFinishDate(DateTime startDate, DateTime finishDate)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c=>c.StartDate >= startDate && c.FinishDate <= finishDate));
        }

        public IDataResult<List<Course>> GetAllCourseByLessThanFee(int fee)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c=>c.Fee <= fee));
        }

        public IDataResult<List<Course>> GetAllCourseByTeacherId(int teacherId)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c=>c.TeacherId == teacherId));
        }

        [ValidationAspect(typeof(CourseValidator))]
        public IResult UpdateCourse(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.UpdatedCourse);
        }

        private IResult CheckStudetnCountForCourseAdd()
        {
            var result = _studentService.GetAllStudent();
            if (result.Data.Count < 20)
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.StudentCountLessThan);
        }
    }
}
