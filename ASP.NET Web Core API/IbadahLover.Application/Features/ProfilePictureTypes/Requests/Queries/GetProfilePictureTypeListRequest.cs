﻿using IbadahLover.Application.DTOs.ProfilePictureType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbadahLover.Application.Features.ProfilePictureTypes.Requests.Queries
{
    public class GetProfilePictureTypeListRequest : IRequest<List<ProfilePictureTypeListDto>>
    {
        public byte[] Base64Code { get; set; }
    }
}