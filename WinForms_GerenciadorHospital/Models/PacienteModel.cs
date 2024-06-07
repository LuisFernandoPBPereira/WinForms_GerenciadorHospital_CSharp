namespace WinForms_GerenciadorHospital.Models;

public class PacienteModel
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public DateTime DataNasc { get; set; }
    public bool TemConvenio { get; set; }
}
