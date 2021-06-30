using Business.Abstract;
using Business.BusinessAspects.Autofac;
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

namespace Business.Concrete
{
    
    public class TeacherManager : ITeacherService
    {
        ITeacherDal _teacherDal;
        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }
        [SecuredOperation("admin")]
        [ValidationAspect(typeof(TeacherValidator))]
        [CacheRemoveAspect("ITeacherService.GetAllTeachers")]
        public IResult AddTeacher(Teacher teacher)
        {
            _teacherDal.Add(teacher);
            return new SuccessResult(Messages.AddedTeacher);
        }

        [SecuredOperation("admin")]
        public IResult DeleteTeacher(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
            return new SuccessResult(Messages.DeletedTeacher);
        }

        [CacheAspect]
        [SecuredOperation("admin,teacher,student")]
        public IDataResult<List<Teacher>> GetAllTeachers()
        {
            return new SuccessDataResult<List<Teacher>>(_teacherDal.GetAll());
        }
        [SecuredOperation("admin,teacher,student")]
        public IDataResult<List<Teacher>> GetTeacherByName(string teacherName)
        {
            return new SuccessDataResult<List<Teacher>>(_teacherDal.GetAll(t=>t.TeacherName.Contains(teacherName)));
        }

        [ValidationAspect(typeof(TeacherValidator))]
        [SecuredOperation("admin")]
        [CacheRemoveAspect("ITeacherService.GetAllTeachers")]
        public IResult UpdateTeacher(Teacher teacher)
        {
            _teacherDal.Update(teacher);
            return new SuccessResult(Messages.UpdatedTeacher);
        }
    }
}
