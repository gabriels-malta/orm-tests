using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DapperSample.Persistence
{
    public class RepositoryUtils
    {
        private readonly IConfiguration _configuration;

        public RepositoryUtils(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SqlConnection GetConnection() => new SqlConnection(_configuration.GetConnectionString("Default"));
    }
}
