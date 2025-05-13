using System;
using System.Collections.Generic;

namespace WelfareDataAccess.Entities;
public class BeneficiaryType
{
    public int BeneficiaryTypeId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public ICollection<MedicalWelfareRequest> MedicalWelfareRequests { get; set; } = new List<MedicalWelfareRequest>();
}

