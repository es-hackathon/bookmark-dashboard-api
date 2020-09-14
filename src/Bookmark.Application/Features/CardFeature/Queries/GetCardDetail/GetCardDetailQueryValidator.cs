using FluentValidation;

namespace Bookmark.Application.Features.CardFeature.Queries.GetCardDetail
{
    public class GetCardDetailQueryValidator : AbstractValidator<GetCardDetailQuery>
    {
        public GetCardDetailQueryValidator()
        {
            //RuleFor(v => v.Id).NotEmpty().Length(5);
        }
    }
}
