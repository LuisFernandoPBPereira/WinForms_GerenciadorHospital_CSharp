using System.Text.Json.Serialization;

namespace WinForms_GerenciadorHospital.Models.Response;

public class ResponseTokenJWTModel
{
    [JsonPropertyName("value")]
    public string Value { get; set; } = string.Empty;
}
