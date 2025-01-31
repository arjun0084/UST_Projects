﻿using microservices.Srevices.AuthAPI.Models.Dto;

namespace microservices.Srevices.AuthAPI.Service.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDto registrationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);

        Task<bool> AssignRole(string email, string rolename);
    }
}
