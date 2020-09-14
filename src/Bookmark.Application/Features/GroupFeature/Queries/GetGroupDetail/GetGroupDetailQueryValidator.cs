using FluentValidation;

namespace Bookmark.Application.Features.GroupFeature.Queries.GetGroupDetail
{
    public class GetGroupDetailQueryValidator : AbstractValidator<GetGroupDetailQuery>
    {
        public GetGroupDetailQueryValidator()
        {
            //RuleFor(v => v.Id).NotEmpty().Length(5);
        }
    }
}
