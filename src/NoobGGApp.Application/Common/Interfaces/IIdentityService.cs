﻿using NoobGGApp.Application.Features.Auth.Commands.Register;

namespace NoobGGApp.Application.Common.Interfaces;

public interface IIdentityService
{
    Task<string> RegisterAsync(AuthRegisterCommand command, CancellationToken cancellationToken);
}
public interface IMessageQueueService
{
    Task SendUserRegisteredMessageAsync(UserRegisteredMessage message, CancellationToken cancellationToken = default);
}