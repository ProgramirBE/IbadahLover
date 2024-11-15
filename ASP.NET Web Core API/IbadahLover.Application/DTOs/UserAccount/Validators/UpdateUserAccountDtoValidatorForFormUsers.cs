﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbadahLover.Application.DTOs.UserAccount.Validators
{
    public class UpdateUserAccountDtoValidatorForFormUsers : AbstractValidator<UpdateUserAccountDto>
    {
        public UpdateUserAccountDtoValidatorForFormUsers()
        {
            RuleFor(p => p.FullName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(25).WithMessage("{PropertyName} must not exceed 25 characters.");

            RuleFor(p => p.PasswordHash)
                .NotNull().WithMessage("{PropertyName} must be provided.");
        }
    }
}
