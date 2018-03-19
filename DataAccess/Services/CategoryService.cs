using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.UnitOfWork;

namespace DataAccess.Services
{
    public class CategoryService : ICategoryService
    {
        IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
       

        public IEnumerable<Category> GetAll()
        {
            return _unitOfWork.CategoryRepository.GetAll();
        }
    }
}
