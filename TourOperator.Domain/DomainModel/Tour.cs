﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TourOperator.Domain.DomainModel
{
    public class Tour
    {
        public int Id { get; set; }
        
        [Required]
        public decimal Price { get; set; }                
        public uint Nights { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? EndedOn { get; set; }

        [Timestamp]
        public byte[] TimestampBytes { get; set; }
    }
}
