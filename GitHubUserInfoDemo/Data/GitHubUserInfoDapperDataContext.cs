using Microsoft.Data.SqlClient;
using System.Data;

namespace GitHubUserInfoDemo.Data
{
    public class GitHubUserInfoDapperDataContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionStgring;

        public GitHubUserInfoDapperDataContext(IConfiguration configuration)
        {            
            _configuration = configuration;
            _connectionStgring = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionStgring);
    }
}
