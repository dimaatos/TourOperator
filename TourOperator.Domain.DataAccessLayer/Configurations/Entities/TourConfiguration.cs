﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourOperator.Domain.Data.DomainModel;

namespace TourOperator.Domain.DataAccessLayer.Configurations.Entities
{
    public class TourConfiguration : EntityTypeConfiguration<Tour>
    {
        public TourConfiguration()
        {
            Property(t => t.Price).IsRequired();
            Property(t => t.StartedOn).HasColumnType("datetime2").IsOptional();
            Property(t => t.EndedOn).HasColumnType("datetime2").IsOptional();
            Property(t => t.TimestampBytes).IsConcurrencyToken(true);
        }
    }
}