public class FriendRequest
{
    public Guid Id { get; set; }
    public Guid FromUserId { get; set; }
    public Guid ToUserId { get; set; }
    public FriendRequestStatus Status { get; set; }
    public DateTime Timestamp { get; set; }

    // Navigation properties
    public User FromUser { get; set; }
    public User ToUser { get; set; }
}