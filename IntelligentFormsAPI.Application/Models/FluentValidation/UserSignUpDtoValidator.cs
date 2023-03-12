using FluentValidation;
using IntelligentFormsAPI.Application.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IntelligentFormsAPI.Application.Models.FluentValidation
{
    public class UserSignUpValidator : AbstractValidator<UserSignUpDto>
    {
        public UserSignUpValidator()
        {
            RuleFor(x => x.Name)
              .NotEmpty()
              .WithMessage("Name is required")
              .MinimumLength(3)
              .WithMessage("Name must be at least 3 characters long")
              .MaximumLength(50)
              .WithMessage("Name must be less than 50 characters");

            RuleFor(x => x.EmailAddress)
              .NotEmpty()
              .WithMessage("Email address is required")
              .EmailAddress()
              .WithMessage("Email address is not valid");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required")
                .MinimumLength(8)
                .WithMessage("Password must be at least 8 characters long")
                .MaximumLength(50)
                .WithMessage("Password must be less than 50 characters");
        }
    }
}
