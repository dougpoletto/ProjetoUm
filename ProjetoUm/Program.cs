using ProjetoUm.Telas;

namespace ProjetoUm
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal());
        }
    }
}