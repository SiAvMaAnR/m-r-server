﻿using MessengerX.Domain.Entities.Accounts;
using MessengerX.Domain.Entities.Admins;
using MessengerX.Domain.Entities.Channels;
using MessengerX.Domain.Entities.Messages;
using MessengerX.Domain.Entities.RefreshTokens;
using MessengerX.Domain.Entities.Users;

namespace MessengerX.Domain.Common;

public partial interface IUnitOfWork
{
    IAccountRepository Account { get; }
    IUserRepository User { get; }
    IAdminRepository Admin { get; }
    IRefreshTokenRepository RefreshToken { get; }
    IChannelRepository Channel { get; }
    IMessageRepository Message { get; }
}
