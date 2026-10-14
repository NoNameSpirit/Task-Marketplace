using Domain.Interfaces;
using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos.Responses;

namespace Application.Chats.Commands.Delete;

public class DeleteChatHandler : IRequestHandler<DeleteChatCommand, Result>
{
    private readonly IChatCommandRepository _commandRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteChatHandler(
        IChatCommandRepository commandRepository,
        IUnitOfWork unitOfWork)
    {
        _commandRepository = commandRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(
        DeleteChatCommand request,
        CancellationToken cancellationToken = default)
    {
        await _commandRepository.DeleteAsync(request.ChatId, cancellationToken);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }
}