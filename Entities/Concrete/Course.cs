using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Course : IEntity
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public string CourseName { get; set; }
        public int Fee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }

    }
}
