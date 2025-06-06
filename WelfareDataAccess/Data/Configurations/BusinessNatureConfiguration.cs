﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;



#nullable disable

namespace S3.MoL.WelfareManagement.Domain.Data.Configurations;

public partial class BusinessNatureConfiguration : IEntityTypeConfiguration<BusinessNature>
{
    public void Configure(EntityTypeBuilder<BusinessNature> entity)
    {
        entity.ToTable("BusinessNature", tb => tb.HasComment("Table storing business natures"));

        entity.Property(e => e.BusinessNatureId)
            .ValueGeneratedNever()
            .HasComment("Unique identifier for the business nature")
            .HasColumnName("BusinessNatureID");
        entity.Property(e => e.Code)
            .HasMaxLength(30)
            .HasComment("Code representing the business nature");
        entity.Property(e => e.IsActive)
            .HasDefaultValue(true)
            .HasComment("Indicates if the business nature is active");
        entity.Property(e => e.IsDeleted).HasComment("Indicates if the business nature is deleted");
        entity.Property(e => e.Text)
            .HasMaxLength(250)
            .HasComment("English text description of the business nature");
        entity.Property(e => e.Text2)
            .HasMaxLength(250)
            .HasComment("Arabic text description of the business nature");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<BusinessNature> entity);
}
