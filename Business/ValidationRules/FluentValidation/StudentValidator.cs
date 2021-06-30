using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.StudentName).NotEmpty();
            RuleFor(s => s.Email).NotEmpty();
            RuleFor(s => s.CourseId).NotEmpty();
        }
    }
}
