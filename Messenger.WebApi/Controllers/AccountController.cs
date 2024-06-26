﻿using MessengerX.Application.Services.AccountService;
using MessengerX.Application.Services.AccountService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MessengerX.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet("image"), Authorize]
    public async Task<IActionResult> Image()
    {
        AccountServiceImageResponse response = await _accountService.GetImageAsync();

        return Ok(response);
    }

    [HttpPost("upload-image"), Authorize]
    public async Task<IActionResult> UploadImage(IFormFile file)
    {
        AccountServiceUploadImageResponse response = await _accountService.UploadImageAsync(
            new AccountServiceUploadImageRequest() { File = file }
        );

        return Ok(response);
    }
}
