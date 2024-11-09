﻿using DhikrCount.Application.DTOs.DhikrType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DhikrCount.Application.Features.DhikrTypes.Requests.Queries
{
    public class GetDhikrTypeListRequest : IRequest<List<DhikrTypeListDto>>
    {
    }
}