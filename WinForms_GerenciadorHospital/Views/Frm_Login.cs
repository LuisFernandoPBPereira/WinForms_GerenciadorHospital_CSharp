using System.Text;
using System.Text.Json;
using WinForms_GerenciadorHospital.Models;
using WinForms_GerenciadorHospital.ViewModels;
using WinForms_GerenciadorHospital.Views;

namespace WinForms_GerenciadorHospital;

public partial class Frm_Login : Form
{
    private readonly HttpClient _httpClient;
    public Frm_Login(HttpClient httpClient)
    {
        InitializeComponent();
        _httpClient = httpClient;
    }

    private void Btn_Logar_Click(object sender, EventArgs e)
    {
        ResponseUserLogin responseUserLogin = new ResponseUserLogin(_httpClient);
        responseUserLogin.Login(Txt_User, Txt_Senha);
        
        
    }
}
