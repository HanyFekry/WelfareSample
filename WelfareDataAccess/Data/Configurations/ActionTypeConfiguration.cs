﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;


#nullable disable

namespace S3.MoL.WelfareManagement.Domain.Data.Configurations
{
    public partial class ActionTypeConfiguration : IEntityTypeConfiguration<ActionType>
    {
        public void Configure(EntityTypeBuilder<ActionType> entity)
        {
            entity.HasKey(e => e.ActionTypeId).HasName("PK_AcctionType");

            entity.ToTable("ActionType");

            entity.Property(e => e.ActionTypeId).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Text).HasMaxLength(50);
            entity.Property(e => e.Text2).HasMaxLength(50);

            entity.HasMany(x => x.BatchRequestSteps).WithMany(x => x.ActionTypes);
            entity.HasMany(x => x.WelfareRequestSteps).WithMany(x => x.ActionTypes);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ActionType> entity);
    }
}
