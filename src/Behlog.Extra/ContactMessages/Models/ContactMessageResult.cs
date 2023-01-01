namespace Behlog.Extra.Models;

public class ContactMessageResult
{
    public string AuthorName { get; set; }
    public string? Subject { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public Guid WebsiteId { get; set; }
    public string Message { get; set; }
    public DateTime? SeenDate { get; set; }
    public DateTime? LastStatusChanged { get; set; }
    public ContactMessageStatus Status { get; set; }
    public string? ReplyMessage { get; set; }
    public DateTime? ReplyDate { get; set; }
    public string? ReplyByUserId { get; set; }
    public string? UserNotes { get; set; }
    public string? AssignedToUserId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string? CreatedByUserId { get; set; }
    public string? LastUpdatedByUserId { get; set; }
    public string? CreatedByIp { get; set; }
    public string? LastUpdatedByIp { get; set; }
    
    public string? AssignedToUserDisplayName { get; set; }
    public string? CreatedByUserDisplayName { get; set; }
    public string? LastUpdatedByUserDisplayName { get; set; }
}
