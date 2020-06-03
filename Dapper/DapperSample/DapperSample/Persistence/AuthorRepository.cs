using Dapper;
using DapperSample.Models;
using DapperSample.Persistence.Queries;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DapperSample.Persistence
{
    public class AuthorRepository
    {
        private readonly RepositoryUtils _repositoryUtils;

        public AuthorRepository(RepositoryUtils repositoryUtils)
        {
            _repositoryUtils = repositoryUtils;
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            using (SqlConnection connection = _repositoryUtils.GetConnection())
            {
                connection.Open();
                return await connection.QueryAsync<Author>(AuthorQueries.SELECT);
            }
        }
    }
}
