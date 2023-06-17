using Microsoft.AspNetCore.Mvc;
using TravelAgents.Contracts.Authentication;
using TravelAgents.Models;
using TravelAgents.Services.Authentication;
using TravelAgents.Services.Users;

namespace TravelAgents.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{//dependency injections
    private readonly IAuthenticationService _authenticationService;
    private readonly IUserService _userService;
    public AuthenticationController(IAuthenticationService authenticationService, IUserService userService)
    {
        _authenticationService = authenticationService;
        _userService = userService;
    }
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {//request to authresult using authService
        var authResult = _authenticationService.Register(
            request.Username,
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password,
            request.DateOfBirth);
        //authresult obj to Api User Model

        //authresult obj to authresponse

        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.Username,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email);
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {//request to authresult using authservice
        var authResult = _authenticationService.Login(
            request.Username,
            request.Password);
        //authresult to authresponse
        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.Username,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email);
        return Ok(response);
    }
}