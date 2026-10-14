using Application.Mappers;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Application.Chats.Commands.Create;

public class CreateChatHandler : IRequestHandler<CreateChatCommand, Result<ChatDto>>
{
    private readonly IChatCommandRepository _commandRepository;
    private readonly IChatQueryRepository _queryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateChatHandler(
        IChatCommandRepository commandRepository,
        IChatQueryRepository queryRepository,
        IUnitOfWork unitOfWork)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<ChatDto>> Handle(
        CreateChatCommand request,
        CancellationToken cancellationToken = default)
    {
        var existingChat = await _queryRepository.GetByTaskIdAsync(request.ProjectTaskId, cancellationToken);

        if (existingChat is not null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ChatAlreadyExists,
                ErrorType.Conflict);
        }

        var result = Chat.Create(request.ProjectTaskId);

        if (!result.IsSuccess)
        {
            return Result<ChatDto>.Failure(
                result.Message,
                ErrorType.Validation);
        }

        await _commandRepository.AddAsync(result.Value!, cancellationToken);

        await _unitOfWork.SaveChangesAsync();

        var dto = ChatMapper.ToDto(result.Value!, new Dictionary<Guid, string>());

        return Result<ChatDto>.Success(dto);
    }
}
