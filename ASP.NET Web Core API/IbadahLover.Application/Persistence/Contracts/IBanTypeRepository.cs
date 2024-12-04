﻿using IbadahLover.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbadahLover.Application.Persistence.Contracts
{
    public interface IBanTypeRepository : IGenericRepository<BanType>
    {
        Task<BanType> GetBanTypeWithDetails(int id);
        Task<List<BanType>> GetBanTypesWithDetails();
    }
}
