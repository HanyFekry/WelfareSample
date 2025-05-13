using System;
using System.Collections.Generic;

namespace WelfareDataAccess.Entities;
/// <summary>
/// Table storing gender information
/// </summary>
public class Gender
{
    /// <summary>
    /// Unique identifier for the gender
    /// </summary>
    public int GenderId { get; set; }

    /// <summary>
    /// Code representing the gender
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// English text description of the gender
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// Arabic text description of the gender
    /// </summary>
    public string? Text2 { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public ICollection<Labor> Labors { get; set; } = new List<Labor>();
}

