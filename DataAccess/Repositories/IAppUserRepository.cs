﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public interface IAppUserRepository : IGenericRepository<AppUser>
    {
        IEnumerable<AppUser> ValidateAppUser(string username, string password);
    }
}
