using System.Net.Http.Headers;
using System.Text.Json;
using WinForms_GerenciadorHospital.Models.Response;
using WinForms_GerenciadorHospital.Utils;

namespace WinForms_GerenciadorHospital.ViewModels;

public class ResponseGetConsultas
{
    private readonly HttpClient _httpClient;
    public ResponseGetConsultas(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async void GetConsultas(Label label1, string token)
    {
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        string url = $"{ApiAddress.BaseAddress}{ApiAddress.GetConsultas}";
        HttpResponseMessage response = await _httpClient.GetAsync(url);

        response.EnsureSuccessStatusCode();
        string resposta = await response.Content.ReadAsStringAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var listaDeConsultas = JsonSerializer.Deserialize<List<ReponseGetConsultasModel>>(resposta, options);

        foreach (var item in listaDeConsultas)
        {
            label1.Text += $"Id: {item.Id}\n";
            label1.Text += $"Data da consulta: {item.DataConsulta}\n";
            label1.Text += $"Data do retorno: {item.DataRetorno}\n";
            label1.Text += $"Status: {item.EstadoConsulta}\n";
            label1.Text += $"Valor: {item.Valor}\n";
            label1.Text += $"Nome do Paciente: {item.Paciente.Nome}\n";
            label1.Text += $"Nome do Médico: {item.Medico.Nome}\n";
            label1.Text += "\n";
        }
    }
    
}
