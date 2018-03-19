using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.UnitOfWork;


namespace DataAccess.Services
{
    public class AppUserService : IAppUserService
    {

        IUnitOfWork _unitOfWork;
        public AppUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IEnumerable<AppUser> ValidateAppUser(string username, string password)
        {
            return _unitOfWork.AppUserRepository.ValidateAppUser(username, password);
        }
    }
}
