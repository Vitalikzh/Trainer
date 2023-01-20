﻿using FluentValidation;
using Trainer.Models;

namespace Trainer.Util
{
    public class ExaminationValidator : AbstractValidator<ExaminationViewModel>
    {
        public ExaminationValidator()
        {
            RuleFor(x => x.Date).NotEmpty().GreaterThanOrEqualTo(System.DateTime.UtcNow);
            RuleFor(x => x.PatientId).NotNull();
            RuleFor(x => x.TypePhysicalActive).NotNull();
            RuleFor(peopleDTO => peopleDTO.Indicators).ExclusiveBetween(0, 31);
        }
    }
}
