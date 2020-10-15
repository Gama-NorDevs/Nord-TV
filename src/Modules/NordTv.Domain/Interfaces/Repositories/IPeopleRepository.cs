﻿using NordTv.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordTv.Domain.Interfaces.Repositories
{
    public interface IPeopleRepository
    {
        Task<User> Insert (User people);
        Task<User> GetById (int id);
        Task<List<User>> Get ();
    }
}
