﻿using IbadahLover.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbadahLover.Application.DTOs.ProfilePictureType
{
    public class ProfilePictureTypeDto : BaseDto
    {
        public byte[] Base64Code { get; set; }
    }
}