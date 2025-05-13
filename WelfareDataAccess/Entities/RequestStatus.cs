using System;
using System.Collections.Generic;

namespace WelfareDataAccess.Entities;
public class RequestStatus
{
    /// <summary>
    /// Unique identifier for each request status record
    /// </summary>
    public int RequestStatusId { get; set; }

    /// <summary>
    /// Code representing the request status
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the request status
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Arabic text description of the request status
    /// </summary>
    public string? Text2 { get; set; }

    public ICollection<Request> Requests { get; set; } = new List<Request>();
}

