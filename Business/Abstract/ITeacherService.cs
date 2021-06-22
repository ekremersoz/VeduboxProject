using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        IDataResult<List<Teacher>> GetAllTeachers();
        IDataResult<List<Teacher>> GetTeacherByName(string teacherName);
        IResult AddTeacher(Teacher teacher);
        IResult UpdateTeacher(Teacher teacher);
        IResult DeleteTeacher(Teacher teacher);

    }
}
