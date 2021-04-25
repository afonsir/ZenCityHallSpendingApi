using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ZenCityHallSpendingApi.Dtos;
using ZenCityHallSpendingApi.Services;

namespace ZenCityHallSpendingApi.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AuthenticationController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        [Route("sign_up")]
        [AllowAnonymous]
        public IActionResult Post(UserCreateDto userCreateDto)
        {
            if (userCreateDto.Password != userCreateDto.PasswordConfirmation)
            {
                return BadRequest(new { message = "As senhas não coincidem." });
            }

            return Ok(_accountService.Register(userCreateDto));
        }

        [HttpPost]
        [Route("sign_in")]
        [AllowAnonymous]
        public IActionResult Authenticate(UserAuthenticateDto userAuthenticateDto)
        {
            var user = _accountService.Authenticate(userAuthenticateDto);

            if (user == null) return NotFound(new { message = "Usuário ou senha inválidos" });

            return Ok(new { token = TokenService.GenerateToken(user) });
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);
    }
}
