using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Services
{
    
    public interface ICategoryService
    {     
        IEnumerable<Category> GetAll();
    }

}
