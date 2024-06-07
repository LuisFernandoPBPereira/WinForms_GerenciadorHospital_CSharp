using WinForms_GerenciadorHospital.Enums;

namespace WinForms_GerenciadorHospital.Models.Response
{
    public class ReponseGetConsultasModel
    {
        public int Id { get; set; }
        public DateTime DataConsulta { get; set; }
        public DateTime? DataRetorno { get; set; }
        public decimal? Valor { get; set; }
        public StatusConsulta? EstadoConsulta { get; set; }
        public List<string>? Laudos { get; set; }
        public string? Exame { get; set; }
        public PacienteModel? Paciente { get; set; }
        public MedicoModel? Medico { get; set; }
    }
}
