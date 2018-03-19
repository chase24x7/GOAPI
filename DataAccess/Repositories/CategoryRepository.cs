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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        IConnectionFactory _connectionFactory;
        SqlManager QueryManager = SqlManager.Create(AppDomain.CurrentDomain.BaseDirectory + @"\XML\MasterTables.xml");
        public CategoryRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

       new public IEnumerable<Category> GetAll()
        {
            string Query = "";
            Query = QueryManager.GetQuery("Get_Categories");
            var list = SqlMapper.Query<Category>(_connectionFactory.GetConnection, Query, commandType: CommandType.Text);
            return list;
           
        }

        
    }
}
