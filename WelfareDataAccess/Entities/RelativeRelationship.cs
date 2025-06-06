﻿namespace S3.MoL.WelfareManagement.Domain.Entities;
public class RelativeRelationship
{
    public int RelativeRelationshipId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public ICollection<SocialWelfareRequest> SocialWelfareRequests { get; set; } = new List<SocialWelfareRequest>();
}

