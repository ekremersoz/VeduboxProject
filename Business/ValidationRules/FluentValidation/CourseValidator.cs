using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c => c.CourseName).NotEmpty();
            RuleFor(c => c.Fee).NotEmpty();
            RuleFor(c => c.Fee).GreaterThan(0);
            RuleFor(c => c.StartDate).NotEmpty();
            RuleFor(c => c.StartDate).GreaterThan(DateTime.Now);
            RuleFor(c => c.FinishDate).GreaterThan(c=>c.StartDate);
        }
    }
}
