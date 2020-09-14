using FluentValidation;

namespace Bookmark.Application.Features.CardFeature.Commands.DeleteCard
{
    public class DeleteCardCommandValidator : AbstractValidator<DeleteCardCommand>
    {
        public DeleteCardCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty();
        }
    }
}
