
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WelfareDataAccess.Entities;
namespace WelfareDataAccess.Data;
public partial class WelfareManagementDbContext : DbContext
{
    public WelfareManagementDbContext(DbContextOptions<WelfareManagementDbContext> options)
        : base(options)
    {
    }

    public DbSet<AttachmentType> AttachmentTypes { get; set; }

    public DbSet<Beneficiary> Beneficiaries { get; set; }

    public DbSet<BeneficiaryType> BeneficiaryTypes { get; set; }

    public DbSet<BusinessNature> BusinessNatures { get; set; }

    public DbSet<Directorate> Directorates { get; set; }

    public DbSet<DisabilityWelfareRequest> DisabilityRequests { get; set; }

    public DbSet<Gender> Genders { get; set; }

    public DbSet<Labor> Labors { get; set; }

    public DbSet<MaritalStatus> MaritalStatuses { get; set; }

    public DbSet<MedicalServiceProvider> MedicalServiceProviders { get; set; }

    public DbSet<MedicalWelfareRequest> MedicalWelfareRequests { get; set; }

    public DbSet<NotificationReceiverType> NotificationReceiverTypes { get; set; }

    public DbSet<Occupation> Occupations { get; set; }

    public DbSet<Party> Parties { get; set; }

    public DbSet<PartyType> PartyTypes { get; set; }

    public DbSet<RelativeRelationType> RelativeRelationTypes { get; set; }

    public DbSet<RelativeRelationship> RelativeRelationships { get; set; }

    public DbSet<Request> Requests { get; set; }

    public DbSet<RequestAttachment> RequestAttachments { get; set; }

    public DbSet<RequestStatus> RequestStatuses { get; set; }

    public DbSet<RequestType> RequestTypes { get; set; }

    public DbSet<RequesterRelevance> RequesterRelevances { get; set; }

    public DbSet<SocialWelfareRequest> SocialWelfareRequests { get; set; }

    public DbSet<WelfareCategory> WelfareCategories { get; set; }

    public DbSet<WelfareType> WelfareTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
