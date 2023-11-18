﻿using MessengerX.Application.Services.AccountService.Models;
using MessengerX.Application.Services.Common;

namespace MessengerX.Application.Services.AccountService;

public interface IAccountService : IBaseService
{
    Task<AccountServiceLoginResponse> LoginAsync(AccountServiceLoginRequest request);
    Task<AccountServiceResetTokenResponse> ResetTokenAsync(AccountServiceResetTokenRequest request);
    Task<AccountServiceResetPasswordResponse> ResetPasswordAsync(
        AccountServiceResetPasswordRequest request
    );
}
