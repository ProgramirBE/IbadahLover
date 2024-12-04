﻿using IbadahLover.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbadahLover.Application.Persistence.Contracts
{
    public interface IRoleTypeRepository : IGenericRepository<RoleType>
    {
        Task<RoleType> GetRoleTypeWithDetails(int id);
        Task<List<RoleType>> GetRoleTypesWithDetails();
    }
}
