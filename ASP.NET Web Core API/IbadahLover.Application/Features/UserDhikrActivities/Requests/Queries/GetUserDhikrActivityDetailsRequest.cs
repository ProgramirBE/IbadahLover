﻿using IbadahLover.Application.DTOs.UserDhikrActivity;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbadahLover.Application.Features.UserDhikrActivities.Requests.Queries
{
    // Application User Request to get Details of User Activity
    public class GetUserDhikrActivityDetailsRequest : IRequest<UserDhikrActivityDto>
    {
        public int Id { get; }
        public int UserAccountId { get; set; }

        public int DhikrTypeId { get; set; }
        [DataType(DataType.Date)]
        public DateTime PerformedOn { get; set; }
        public DateTime LastPerformedAt { get; set; }
        public int TotalPerformed { get; set; }
    }
}
