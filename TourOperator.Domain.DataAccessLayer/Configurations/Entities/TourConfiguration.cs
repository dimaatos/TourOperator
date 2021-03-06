﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourOperator.Domain.Data.DomainModel;
using TourOperator.Domain.Data.Entities;

namespace TourOperator.Domain.DataAccessLayer.Configurations.Entities
{
    public class TourConfiguration : EntityTypeConfiguration<Tour>
    {
        public TourConfiguration()
        {
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Nights).IsRequired();
            Property(t => t.TimestampBytes).IsConcurrencyToken(true);
        }
    }
}
