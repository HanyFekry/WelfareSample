using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace S3.MoL.WelfareManagement.Infrastructure.Services.Persistence.Configurations;

public partial class WelfareRequestStatusConfiguration : IEntityTypeConfiguration<WelfareRequestStatus>
{
    public void Configure(EntityTypeBuilder<WelfareRequestStatus> entity)
    {
        entity.ToTable("WelfareRequestStatus");

        entity.HasKey(e => e.WelfareRequestStatusId);
        entity.Property(e => e.WelfareRequestStatusId)
            .ValueGeneratedNever()
            .HasComment("Unique identifier for each Welfare request status record")
            .HasColumnName("RequestStatusID");
        entity.Property(e => e.Code)
            .HasMaxLength(30)
            .HasComment("Code representing the Welfare request status");
        entity.Property(e => e.Text)
            .HasMaxLength(50)
            .HasComment("English text description of the Welfare request status");
        entity.Property(e => e.Text2)
            .HasMaxLength(50)
            .HasComment("Arabic text description of the Welfare request status");

        OnConfigurePartial(entity);
    }

    partial void OnConfigurePartial(EntityTypeBuilder<WelfareRequestStatus> entity);
}
