
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace WelfareDataAccess.Data;
public partial class WelfareManagementDbContext : DbContext
{
    public WelfareManagementDbContext(DbContextOptions<WelfareManagementDbContext> options)
        : base(options)
    {
    }

    public DbSet<ActionType> ActionTypes { get; set; }

    public DbSet<AttachmentType> AttachmentTypes { get; set; }

    public DbSet<BatchRequest> BatchRequests { get; set; }

    public DbSet<BatchRequestAction> BatchRequestActions { get; set; }

    public DbSet<BatchRequestAttachment> BatchRequestAttachments { get; set; }

    public DbSet<BatchRequestStep> BatchRequestSteps { get; set; }

    public DbSet<Beneficiary> Beneficiaries { get; set; }

    public DbSet<BusinessNature> BusinessNatures { get; set; }

    public DbSet<Directorate> Directorates { get; set; }

    public DbSet<DisabilityWelfareRequest> DisabilityWelfareRequests { get; set; }

    public DbSet<Gender> Genders { get; set; }

    public DbSet<Labor> Labors { get; set; }

    public DbSet<MaritalStatus> MaritalStatuses { get; set; }

    public DbSet<Memorandum> Memorandums { get; set; }

    public DbSet<MemorandumAttachment> MemorandumAttachments { get; set; }

    public DbSet<NotificationReceiverType> NotificationReceiverTypes { get; set; }

    public DbSet<Occupation> Occupations { get; set; }

    public DbSet<Party> Parties { get; set; }

    public DbSet<PartyType> PartyTypes { get; set; }

    public DbSet<RelativeRelationType> RelativeRelationTypes { get; set; }

    public DbSet<RelativeRelationship> RelativeRelationships { get; set; }

    public DbSet<RequestStatus> RequestStatuses { get; set; }

    public DbSet<RequestType> RequestTypes { get; set; }

    public DbSet<RequesterRelevance> RequesterRelevances { get; set; }

    public DbSet<SocialWelfareRequest> SocialWelfareRequests { get; set; }

    public DbSet<WelfareCategory> WelfareCategories { get; set; }

    public DbSet<WelfareRequest> WelfareRequests { get; set; }

    public DbSet<WelfareRequestAction> WelfareRequestActions { get; set; }

    public DbSet<WelfareRequestAttachment> WelfareRequestAttachments { get; set; }

    public DbSet<WelfareRequestStep> WelfareRequestSteps { get; set; }

    public DbSet<WelfareType> WelfareTypes { get; set; }

    public DbSet<WorkflowReason> WorkflowReasons { get; set; }

    public DbSet<WelfareRequestStatus> WelfareRequestStatuses { get; set; }

    public DbSet<StepConfiguration> StepConfigurations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }

}
