using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess.Entities;
using DataAccess.Infrastructure;
using System.Data;

namespace DataAccess.Repositories
{
    public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
    {
        IConnectionFactory _connectionFactory;
        SqlManager QueryManager = SqlManager.Create(AppDomain.CurrentDomain.BaseDirectory + @"\XML\MasterTables.xml");
        public AppUserRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public IEnumerable<AppUser> ValidateAppUser(string username, string password)
        {
            string Query = "";
            Query = QueryManager.GetQuery("Validate_AppUser");
            Query = string.Format(Query, username, password);
            var list = SqlMapper.Query<AppUser>(_connectionFactory.GetConnection, Query, commandType: CommandType.Text);
            return list;

        }
    }
}
