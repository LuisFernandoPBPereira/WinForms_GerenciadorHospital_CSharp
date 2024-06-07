using WinForms_GerenciadorHospital.ViewModels;

namespace WinForms_GerenciadorHospital.Views;

public partial class Frm_TesteGet : Form
{
    private readonly string _tokenJWT;
    private readonly HttpClient _httpClient;
    public Frm_TesteGet(string tokenJWT, HttpClient httpClient)
    {
        InitializeComponent();
        _tokenJWT = tokenJWT;
        _httpClient = httpClient;
    }


    private void Btn_GetConsultas_Click(object sender, EventArgs e)
    {
        ResponseGetConsultas getConsultas = new ResponseGetConsultas(_httpClient);
        getConsultas.GetConsultas(label1, _tokenJWT);
    }
}
