﻿using IbadahLover.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbadahLover.Domain
{
    //Database Table UserDhikrCount
    public class UserDhikrCount : BaseDomainEntity
    {
        public int UserAccountId { get; set; }
        public int DhikrTypeId { get; set; }
        public int TotalPerformed { get; set; }
    }
}