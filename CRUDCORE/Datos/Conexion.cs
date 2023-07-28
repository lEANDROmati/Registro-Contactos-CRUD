namespace CRUDCORE.Dato
{
    public class Conexion
    {
        private string cadenaSQL = string.Empty;

        public Conexion()
        {

            //obtener la cadena de conexion de appsetttings.json

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            cadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;

        }
        public string getCadenaSQL()
        {
            return cadenaSQL;
        }
    }
}
