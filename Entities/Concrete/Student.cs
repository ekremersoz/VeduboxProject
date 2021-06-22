using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Student : IEntity
    {
        public int StudentId { get; set; }
        public string Email { get; set; }
        public string StudentName { get; set; }


    }
}
