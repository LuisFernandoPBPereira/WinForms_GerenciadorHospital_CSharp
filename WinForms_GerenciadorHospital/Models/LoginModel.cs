using System.Text.Json.Serialization;

namespace WinForms_GerenciadorHospital.Models;

public class LoginModel
{
    public LoginModel(string userName, string senha)
    {
        UserName = userName;
        Senha = senha;
    }

    [JsonPropertyName("userName")]
    public string UserName { get; set; } = string.Empty;
    [JsonPropertyName("senha")]
    public string Senha { get; set; } = string.Empty;
}
