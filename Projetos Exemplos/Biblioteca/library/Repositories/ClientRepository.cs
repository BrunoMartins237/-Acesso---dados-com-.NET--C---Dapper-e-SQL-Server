using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using library.Models;
using Microsoft.Data.SqlClient;

namespace library.Repositories
{
    public class ClientRepository
    {
        private SqlConnection _connection = new SqlConnection();
        public IEnumerable<Client> Get(string connectionString)
            => _connection.GetAll<Client>();
    }
}