using WelfareDataAccess.Interfaces;

namespace WelfareDataAccess.Entities;
public class Request : ITrackCreatedEntityEx, ITrackUpdatedEntityEx
{
    /// <summary>
    /// Unique identifier for each request
    /// </summary>
    public long RequestId { get; set; }

    public string RequestNo { get; set; } = null!;

    public int LaborId { get; set; }

    /// <summary>
    /// Identifier for the directorate associated with the request
    /// </summary>
    public int DirectorateId { get; set; }

    /// <summary>
    /// Identifier for the type of request
    /// </summary>
    public int WelfareTypeId { get; set; }

    /// <summary>
    /// Identifier for the current status of a current workflow
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    /// Date and time when the request was created
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// User ID of the user who created the request record
    /// </summary>
    public string CreatedByUserId { get; set; } = null!;

    /// <summary>
    /// User name of the user who created the request record
    /// </summary>
    public string CreatedByUserName { get; set; } = null!;

    /// <summary>
    /// User ID of the user who last updated the request record
    /// </summary>
    public string? UpdatedUserId { get; set; }

    /// <summary>
    /// Date and time when the request record was last updated
    /// </summary>
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    /// User name of the user who last updated the request record
    /// </summary>
    public string? UpdatedUserName { get; set; }

    /// <summary>
    /// Timestamp for version control of the request record
    /// </summary>
    public byte[] Version { get; set; } = null!;

    public decimal DueAmount { get; set; }

    public string? LaborMobileNo { get; set; }

    public string? Notes { get; set; }

    //public DisabilityWelfareRequest? DisabilityRequest { get; set; }

    public Directorate Directorate { get; set; } = null!;

    public RequestStatus Status { get; set; } = null!;

    public WelfareType WelfareType { get; set; } = null!;

    //public MedicalWelfareRequest? MedicalWelfareRequest { get; set; }

    public ICollection<RequestAttachment> RequestAttachments { get; set; } = new List<RequestAttachment>();

    //public SocialWelfareRequest? SocialWelfareRequest { get; set; }
}

