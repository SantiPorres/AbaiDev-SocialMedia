using FluentValidation;
using SocialMedia.Core.DTOs;
using System;

namespace SocialMedia.Infrastructure.Validators
{
    public class PostValidator : AbstractValidator<PostDto>
    {
        public PostValidator()
        {
            RuleFor(post => post.Description)
                .NotNull()
                .WithMessage("La descripcion no pueder ser nula");

            RuleFor(post => post.Description)
                //.MaximumLength(1000);
                .Length(1, 1000)
                .WithMessage("La longitud de la descripcion debe estar entre 1 y 1000 caracteres");

            RuleFor(post => post.Date)
                .NotNull()
                .LessThan(DateTime.Now);
        }
    }
}
