using FluentValidation;

namespace Bookmark.Application.Features.GroupFeature.Commands.CreateGroup
{
    public class CreateGroupCommandValidator : AbstractValidator<CreateGroupCommand>
    {
        public CreateGroupCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Url).NotEmpty();
        }
    }
}
