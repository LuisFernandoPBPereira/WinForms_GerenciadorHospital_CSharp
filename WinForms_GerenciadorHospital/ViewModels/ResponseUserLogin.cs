using System.Text.Json;
using System.Text;
using WinForms_GerenciadorHospital.Models;
using WinForms_GerenciadorHospital.Utils;
using System.Net.Http.Headers;
using WinForms_GerenciadorHospital.Views;
using WinForms_GerenciadorHospital.Models.Response;

namespace WinForms_GerenciadorHospital.ViewModels;

public class ResponseUserLogin
{
    private readonly HttpClient _httpClient;
    public ResponseUserLogin(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async void Login(TextBox Txt_User, TextBox Txt_Senha)
    {
        LoginModel loginModel = new LoginModel(Txt_User.Text, Txt_Senha.Text);
        
        string json = JsonSerializer.Serialize(loginModel);

        StringContent conteudo = new StringContent(json, Encoding.UTF8, "application/json");

        string url = $"{ApiAddress.BaseAddress}{ApiAddress.UserLoginRoute}";
        HttpResponseMessage response = await _httpClient.PostAsync(url, conteudo);

        response.EnsureSuccessStatusCode();
        string resposta = await response.Content.ReadAsStringAsync();

        var token = JsonSerializer.Deserialize<ResponseTokenJWTModel>(resposta);

        Frm_TesteGet frm_TesteGet = new Frm_TesteGet(token.Value, _httpClient);
        frm_TesteGet.Show();
    }
}
