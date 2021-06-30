using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseDetailValidator : AbstractValidator<CourseDetail>
    {
        public CourseDetailValidator()
        {
            RuleFor(cd => cd.CourseHeader).NotEmpty();
            RuleFor(cd => cd.CourseCurriculum).NotEmpty();
            RuleFor(cd => cd.CourseDescription).NotEmpty();
        }
    }
}
