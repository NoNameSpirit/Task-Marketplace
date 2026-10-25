using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Task_Marketplace.Application.Handlers.Auth.Commands.Register;

public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, Result<AuthDto>>
{
    private readonly IUserCommandRepository _commandRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IUserQueryRepository _queryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RegisterUserHandler(
        IUserCommandRepository commandRepository,
        IJwtTokenGenerator jwtTokenGenerator,
        IPasswordHasher passwordHasher,
        IUserQueryRepository queryRepository,
        IUnitOfWork unitOfWork)
    {
        _commandRepository = commandRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
        _passwordHasher = passwordHasher;
        _queryRepository = queryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<AuthDto>> Handle(
        RegisterUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var existing = await _queryRepository.GetByNameAsync(request.Name, cancellationToken);

        if (existing is not null)
        {
            return Result<AuthDto>.Failure(
                ErrorMessages.UserAlreadyExists,
                ErrorType.Conflict);
        }

        var hashResult = _passwordHasher.Hash(request.Password);

        if (!hashResult.IsSuccess)
        {
            return Result<AuthDto>.Failure(
                hashResult.Message,
                ErrorType.Validation);
        }

        var userResult = User.Create(
            request.Name,
            hashResult.Value!,
            request.Role);

        if (!userResult.IsSuccess)
        {
            return Result<AuthDto>.Failure(
                userResult.Message,
                ErrorType.Validation);
        }

        await _commandRepository.AddAsync(userResult.Value!, cancellationToken);

        var authDto = _jwtTokenGenerator.GenerateToken(userResult.Value!);

        return Result<AuthDto>.Success(authDto);
    }
}
