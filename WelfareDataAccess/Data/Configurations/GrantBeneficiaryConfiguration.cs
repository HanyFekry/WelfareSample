using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace S3.MoL.WelfareManagement.Infrastructure.Services.Persistence.Configurations
{
    public class GrantBeneficiaryConfiguration : IEntityTypeConfiguration<GrantBeneficiary>
    {
        public void Configure(EntityTypeBuilder<GrantBeneficiary> entity)
        {
            entity.HasKey(x => x.GrantBeneficiaryId);
            entity.Property(x => x.GrantBeneficiaryId).ValueGeneratedOnAdd().HasColumnName("GrantBeneficiaryID");
            entity.Property(x => x.Name).IsRequired().HasMaxLength(200);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NationalId)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NationalID");
            entity.Property(x => x.Address).IsRequired(false).HasMaxLength(400);
            entity.Property(x => x.IBan).IsRequired().HasMaxLength(50);
            entity.Property(x => x.BankName).IsRequired(false).HasMaxLength(200);
            entity.Property(x => x.BranchName).IsRequired(false).HasMaxLength(200);
        }
    }
}
