using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Aspects.Autofac.TransactionScopeAspect;
using Core.Aspects.Autofac.Performance;
using Entities.Dtos;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }


        [ValidationAspect(typeof(StudentValidator))]
        [CacheRemoveAspect("IStudentService.GetAllStudent")]
        public IResult AddStudent(Student student)
        {

            _studentDal.Add(student);
            return new SuccessResult(Messages.AddedStudent);
        }

        [TransactionScopeAspect()]
        public IResult AddTransactionalTest(Student student)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteStudent(Student student)
        {
            _studentDal.Delete(student);
            return new SuccessResult(Messages.DeletedStudent);
        }

        [CacheAspect]
        public IDataResult<List<Student>> GetAllStudent()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(),Messages.ListedStudent);
        }

        public IDataResult<List<Student>> GetStudentsByName(string studentName)
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(s=>s.StudentName.Contains(studentName)));
        }

        public IDataResult<List<StudentCourseDetail>> GetAllStudentCourseDetail()
        {
            return new SuccessDataResult<List<StudentCourseDetail>>(_studentDal.StudentCourseDetail(), Messages.StudentCourseDetailListed);
        }

        [ValidationAspect(typeof(StudentValidator))]
        public IResult UpdateStudent(Student student)
        {
            _studentDal.Update(student);
            return new SuccessResult(Messages.UpdatedStudent);
        }
    }
}
