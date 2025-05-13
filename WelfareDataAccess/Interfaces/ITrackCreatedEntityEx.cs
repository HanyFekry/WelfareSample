namespace WelfareDataAccess.Interfaces
{
    public interface ITrackCreatedEntityEx
    {
        DateTime CreatedDate { get; set; }
        string CreatedByUserId { get; set; }
        string CreatedByUserName { get; set; }
    }
}
