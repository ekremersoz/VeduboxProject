using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<List<Student>> GetAllStudent();
        IDataResult<List<Student>> GetStudentsByName(string studentName);
        IResult AddStudent(Student student);
        IResult UpdateStudent(Student student);
        IResult DeleteStudent(Student student);
        IResult AddTransactionalTest(Student student);

    }
}
