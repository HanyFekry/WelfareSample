using System;
using System.Collections.Generic;

namespace WelfareDataAccess.Entities;
public class MedicalServiceProvider
{
    public int MedicalServiceProviderId { get; set; }

    public string Code { get; set; } = null!;

    public string Text { get; set; } = null!;

    public string? Text2 { get; set; }

    public string? Iban { get; set; }

    public ICollection<MedicalWelfareRequest> MedicalWelfareRequests { get; set; } = new List<MedicalWelfareRequest>();
}

