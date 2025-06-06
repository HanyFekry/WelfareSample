﻿namespace S3.MoL.WelfareManagement.Domain.Entities;
public class Party
{
    public long PartyId { get; set; }

    public int PartyTypeId { get; set; }

    public string Name { get; set; } = null!;

    public PartyType PartyType { get; set; } = null!;

    public ICollection<Labor> Labors { get; set; } = new List<Labor>();
}

