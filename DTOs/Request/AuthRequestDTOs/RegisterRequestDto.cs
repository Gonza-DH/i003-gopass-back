﻿namespace template_csharp_dotnet.DTOs.Request.AuthRequestDTOs
{
    public class RegisterRequestDto
    {
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
