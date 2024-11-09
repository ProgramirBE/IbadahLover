﻿using AutoMapper;
using DhikrCount.Application.DTOs.DhikrType;
using DhikrCount.Application.Features.DhikrTypes.Requests.Queries;
using DhikrCount.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DhikrCount.Application.Features.DhikrTypes.Handlers.Queries
{
    // Backend Handler of Request to get Details of Dhikr Type
    public class GetDhikrTypeDetailsRequestHandler : IRequestHandler<GetDhikrTypeDetailsRequest, DhikrTypeDto>
    {
        private readonly IDhikrTypeRepository _dhikrTypeRepository;
        private readonly IMapper _mapper;

        public GetDhikrTypeDetailsRequestHandler(IDhikrTypeRepository dhikrTypeRepository, IMapper mapper)
        {
            _dhikrTypeRepository = dhikrTypeRepository;
            _mapper = mapper;
        }
        public async Task<DhikrTypeDto> Handle(GetDhikrTypeDetailsRequest request, CancellationToken cancellationToken)
        {
            var dhikrType = await _dhikrTypeRepository.GetById(request.Id);
            return _mapper.Map<DhikrTypeDto>(dhikrType);
        }
    }
}