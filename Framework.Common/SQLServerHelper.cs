using System.Data.Common;

namespace Framework.Common
{
    public class SQLServerHelper
    {
        public static readonly string? DbConnectionString = null;

        static SQLServerHelper()
        {
            DbConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultDatabaseConnection"].ConnectionString;
        }
    }
}
