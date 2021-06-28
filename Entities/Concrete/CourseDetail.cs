using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class CourseDetail : IEntity
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseHeader { get; set; }
        public string CourseCurriculum { get; set; }
        public string CourseDescription { get; set; }
    }
}
