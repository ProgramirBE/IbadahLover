﻿using IbadahLover.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbadahLover.Application.DTOs.PermissionType
{
    public class PermissionTypeListDto : BaseDto
    {
        public string FullName { get; set; }
        public string Details { get; set; }
    }
}
