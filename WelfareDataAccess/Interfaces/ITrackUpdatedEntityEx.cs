namespace WelfareDataAccess.Interfaces
{
    public interface ITrackUpdatedEntityEx
    {
        string? UpdatedUserId { get; set; }
        DateTime? UpdatedDate { get; set; }
        string? UpdatedUserName { get; set; }
    }
}
