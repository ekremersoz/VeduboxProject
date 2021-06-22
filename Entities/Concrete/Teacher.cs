using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Teacher : IEntity
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string Education { get; set; }
    }
}
