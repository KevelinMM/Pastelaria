using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Globalization;
namespace Pastelaria_do_Zé

{
    internal static class Program
    {
        /// <summary>
        ///  Configuracoes
        /// </summary>
        [STAThread]
        static void Main()
        {
            // No .NET 2.1 ou posterior os provedores não são mais registrados automaticamente no DbProviderFactories
            // Após instalar os pacotes via NuGet, realizar o registro manualmente no DbProviderFactories
           
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao"):"" ;

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(auxIdiomaRegiao!);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());

            ValidaConexaoDB();
            //ajusta o texto dos campos conforme a cultura carregada em Program.cs

        }
        public static void ValidaConexaoDB()
        {
            DbProviderFactory factory;
            try
            {
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["BD"].ProviderName);
                using var conexao = factory.CreateConnection();
                conexao!.ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
                using var comando = factory.CreateCommand();
                comando!.Connection = conexao;
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new Configuracoes().ShowDialog();
                ValidaConexaoDB();
            }
        }
    }
}

