namespace GRUPOMT.Service
{
    public class Database
    {
        public static string CadenaToyo { get; private set; }
        public static string CadenaSakura { get; private set; }

        public static string ApiToken { get; private set; }
        public static string BlobConnectionString { get; private set; }

        public static void Initialize(IConfiguration configuration)
        {
            // Asignamos cada cadena de conexión según el nombre definido en appsettings.json
            CadenaToyo = configuration.GetConnectionString("ConexionToyo");
            CadenaSakura = configuration.GetConnectionString("ConexionSakura");

            BlobConnectionString = configuration.GetConnectionString("BlobConnectionString");
            ApiToken = configuration["ConfiguracionApi:ApiToken"];
        }
    }
}
