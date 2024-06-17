using System.ComponentModel.DataAnnotations;

namespace JWT.RequestModels;

public class RequestTokenModel
{
    [Required] public string RefreshToken { get; set; }
}