using System;
using System.Collections.Generic;

namespace WelfareDataAccess.Entities;
public class MaritalStatus
{
    /// <summary>
    /// Unique identifier for each marital status record
    /// </summary>
    public int MaritalStatusId { get; set; }

    /// <summary>
    /// Code representing the marital status
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the marital status
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Arabic text description of the marital status
    /// </summary>
    public string? Text2 { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public ICollection<Labor> Labors { get; set; } = new List<Labor>();
}

