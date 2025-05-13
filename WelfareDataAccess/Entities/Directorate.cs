using System;
using System.Collections.Generic;

namespace WelfareDataAccess.Entities;
/// <summary>
/// Table storing directorates
/// </summary>
public class Directorate
{
    /// <summary>
    /// Unique identifier for the directorate
    /// </summary>
    public int DirectorateId { get; set; }

    /// <summary>
    /// Code representing the directorate
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the directorate
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Arabic text description of the directorate
    /// </summary>
    public string? Text2 { get; set; }

    /// <summary>
    /// Indicates if the directorate is deleted
    /// </summary>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// Indicates if the directorate is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Foreign key to the Governorate table
    /// </summary>
    public int GovernorateId { get; set; }

    public ICollection<Labor> Labors { get; set; } = new List<Labor>();

    public ICollection<Request> Requests { get; set; } = new List<Request>();
}

