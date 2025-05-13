using System;
using System.Collections.Generic;

namespace WelfareDataAccess.Entities;
/// <summary>
/// Labor or Medical provider or Other
/// </summary>
public class RequesterRelevance
{
    public int RequesterRelevantId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public ICollection<SocialWelfareRequest> SocialWelfareRequests { get; set; } = new List<SocialWelfareRequest>();
}

