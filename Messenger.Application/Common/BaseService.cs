﻿using MessengerX.Domain.Interfaces.UnitOfWork;
using MessengerX.Infrastructure.AppSettings;
using MessengerX.Infrastructure.UserIdentity;
using Microsoft.AspNetCore.Http;

namespace MessengerX.Application.Services.Common;

public interface IBaseService { }

public abstract class BaseService(
    IUnitOfWork unitOfWork,
    IHttpContextAccessor context,
    IAppSettings appSettings
) : IBaseService
{
    protected readonly IUnitOfWork _unitOfWork = unitOfWork;
    protected readonly IAppSettings _appSettings = appSettings;
    protected readonly UserIdentity _userIdentity = new(context.HttpContext?.User);
}
