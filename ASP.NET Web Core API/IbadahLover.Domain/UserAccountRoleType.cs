﻿using IbadahLover.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbadahLover.Domain
{
    public class UserAccountRoleType : BaseDomainEntity
    {
        [ForeignKey("UserAccount")]
        public int UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; } // Navigation property
        [ForeignKey("RoleType")]
        public int RoleTypeId { get; set; }
        public RoleType RoleType { get; set; } // Navigation property
    }
}
