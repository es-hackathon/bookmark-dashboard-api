using Bookmark.Application.Common.Exceptions;
using Bookmark.Application.Common.Interface;
using Bookmark.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Bookmark.Application.Features.CardFeature.Commands.DeleteCard
{
    public class DeleteCardCommandHandler : IRequestHandler<DeleteCardCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCardCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<Unit> Handle(DeleteCardCommand request, CancellationToken cancellationToken)
        {
            DeleteCardCommandValidator validator = new DeleteCardCommandValidator();

            var results = validator.Validate(request);

            if (!results.IsValid)
            {
                throw new ValidationException(results.ToString("~"));
            }

            var entity = await _context.Cards
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Cards), request.Id);
            }

            _context.Cards.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }


    }
}
