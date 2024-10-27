using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRSandMediatr.Application.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommandValidator : AbstractValidator<CreateBlogCommand>
    {
        public CreateBlogCommandValidator()
        {
            RuleFor(v => v.Name)
              .NotEmpty().WithMessage("Name is required.")
              .MaximumLength(200).WithMessage("Name must not exceed 200 characters.")
              .MinimumLength(4).WithMessage("Name must not less than 4 characters.");

            RuleFor(v => v.Description)
               .NotEmpty().WithMessage("Description is required.");

            RuleFor(v => v.Author)
               .NotEmpty().WithMessage("Author is required.")
               .MaximumLength(20).WithMessage("Name must not exceed 20 characters.");
        }
    }
}
