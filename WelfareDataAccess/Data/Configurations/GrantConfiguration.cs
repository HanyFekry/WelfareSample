using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace S3.MoL.WelfareManagement.Infrastructure.Services.Persistence.Configurations
{
    public class GrantConfiguration : IEntityTypeConfiguration<Grant>
    {
        public void Configure(EntityTypeBuilder<Grant> entity)
        {
            entity.HasKey(x => x.GrantId);
            entity.Property(x => x.GrantId).ValueGeneratedOnAdd().HasColumnName("GrantID");
            entity.Property(x => x.GrantCategoryId).HasConversion<int>();
            entity.Property(x => x.Description)
                .HasMaxLength(100)
                .HasComment("Description of the grant");
            entity.Property(x => x.GrantNo)
                .HasMaxLength(20)
                .HasComment("auto generated grant no of the grant");
            entity.Property(e => e.DueAmount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.CreatedByUserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("User ID of the user who created the request record");
            entity.Property(e => e.CreatedByUserName)
                .HasMaxLength(200)
                .HasComment("User name of the user who created the request record");
            entity.Property(e => e.CreatedDate).HasComment("Date and time when the request was created");
            entity.Property(e => e.UpdatedUserName)
                .HasMaxLength(200)
                .HasComment("User name of the user who last updated the request record");
            entity.Property(e => e.UpdatedDate).HasComment("Date and time when the request record was last updated");
            entity.Property(e => e.UpdatedUserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("User ID of the user who last updated the request record");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasComment("Timestamp for version control of the request record");
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(200)
                .HasComment("Path to the beneficiaries attachment file related to the exceptional grant");
            //entity.Property(e => e.DisbursementFilePath)
            //    .HasMaxLength(200)
            //    .HasComment("Path to the Disbursement attachment file related to the grant");
            entity.Property(e => e.TransferNotes)
                .HasMaxLength(200);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasComment("Timestamp for version control of the request record");

            entity.HasOne(x => x.GrantType).WithMany(x => x.Grants).HasForeignKey(x => x.GrantTypeId).IsRequired(false);
            entity.Property(x => x.LastGrantStepId).HasConversion<int>();
            entity.Property(x => x.IsRegistered).HasDefaultValueSql("1").HasComment("Indicates whether the grant includes registered labors or unregistered beneficiaries");
            entity.HasMany(e => e.GrantActions).WithOne(e => e.Grant).HasForeignKey(e => e.GrantId).IsRequired(false);
            entity.HasMany(e => e.Labors).WithMany(e => e.Grants);
            entity.HasMany(e => e.GrantBeneficiaries).WithMany(e => e.Grants);
            entity.OwnsMany<StepConfiguration>(
                e => e.StepConfigurations,
                b =>
                {
                    b.ToTable("GrantsStepConfiguration");
                    b.Property(e => e.Role).HasMaxLength(100)
                        .HasComment("Role responsible for this step");

                    b.Property(e => e.ActionTypeID)
                        .IsRequired()
                        .HasComment("Action type for this step");
                }
            );
        }
    }
}
