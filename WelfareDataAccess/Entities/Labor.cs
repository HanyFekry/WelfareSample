using System;
using System.Collections.Generic;

namespace WelfareDataAccess.Entities;
public class Labor
{
    public long LaborId { get; set; }

    public string NationalId { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public DateOnly? BirthDate { get; set; }

    public int? GenderId { get; set; }

    public int? MaritalStatusId { get; set; }

    public int OccupationId { get; set; }

    public string MobileNo { get; set; } = null!;

    public int? LastDirectorateId { get; set; }

    public int? LastBusinessNatureId { get; set; }

    public long? LastExecutionPartyId { get; set; }

    public string? RegistrationNo { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public string? InsuranceNo { get; set; }

    public int? InsuranceSectorId { get; set; }

    public int? InsurancePeriod { get; set; }

    public DateOnly? DeathDate { get; set; }

    /// <summary>
    /// the worker&apos;s status must be Beneficiary or  Not Beneficiary, default is Beneficiary(1)
    /// </summary>
    public bool IsBeneficiary { get; set; }

    public string? Notes { get; set; }

    public Gender? Gender { get; set; }

    public BusinessNature? LastBusinessNature { get; set; }

    public Directorate? LastDirectorate { get; set; }

    public Party? LastExecutionParty { get; set; }

    public MaritalStatus? MaritalStatus { get; set; }

    public Occupation Occupation { get; set; } = null!;
}

