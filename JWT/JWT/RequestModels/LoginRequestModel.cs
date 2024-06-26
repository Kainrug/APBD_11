using System.ComponentModel.DataAnnotations;

namespace JWT.RequestModels;

public class LoginRequestModel
{
    [Required] public string UserName { get; set; }

    [Required] public string Password { get; set; }
}