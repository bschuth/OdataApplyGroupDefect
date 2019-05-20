using System.Data.Linq;
using System.Data.SqlClient;

namespace ODataTables2.Common
{
    public static class DataContextFactory
    {
        public static DataContext GetContext()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = ".",
                InitialCatalog = "OData2", IntegratedSecurity = true
            };
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            DataContext dbContext = new DataContext(connection);
            return dbContext;
        }
    }
}
