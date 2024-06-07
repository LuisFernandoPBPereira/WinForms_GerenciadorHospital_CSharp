namespace WinForms_GerenciadorHospital;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        HttpClient client = new HttpClient();

        ApplicationConfiguration.Initialize();
        Application.Run(new Frm_Login(client));
    }
}