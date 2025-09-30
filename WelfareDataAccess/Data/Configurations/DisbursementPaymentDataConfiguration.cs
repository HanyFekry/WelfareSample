using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace S3.MoL.WelfareManagement.Infrastructure.Services.Persistence.Configurations
{
    public class DisbursementPaymentDataConfiguration : IEntityTypeConfiguration<DisbursementPaymentData>
    {
        public void Configure(EntityTypeBuilder<DisbursementPaymentData> entity)
        {
            entity.ToTable("DisbursementPaymentData");
            entity.HasKey(x => x.DisbursementPaymentDataId);
            //entity.Property(e => e.DisbursementRequestId).ValueGeneratedOnAdd();
            entity.Property(e => e.WelfareRequestStatusId).HasConversion<int>();
            entity.Property(e => e.WelfareTypeId).HasConversion<int>();
            entity.Property(e => e.BeneficiaryNationalId).HasMaxLength(14).IsRequired();

        }

    }
}
