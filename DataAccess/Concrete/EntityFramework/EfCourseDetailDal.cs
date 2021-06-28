using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCourseDetailDal : EfEntityRepositoryBase<CourseDetail , VeduboxProjectContext> , ICourseDetailDal
    {
    }
}
