namespace Behlog.Extra;


public class ContactMessage : AggregateRoot<Guid>, IHasMetadata
{

    private ContactMessage()
    {
    }

    #region props

    public string AuthorName { get; protected set; }
    public string? Subject { get; protected set; }
    public string? PhoneNumber { get; protected set; }
    public string? Email { get; protected set; }
    public Guid WebsiteId { get; protected set; }
    public string Message { get; protected set; }
    public DateTime? SeenDate { get; protected set; }
    public DateTime? LastStatusChanged { get; protected set; }
    public ContactMessageStatus Status { get; protected set; }
    public string? ReplyMessage { get; protected set; }
    public DateTime? ReplyDate { get; protected set; }
    public string? ReplyByUserId { get; protected set; }

    public string? UserNotes { get; protected set; }
    public string? AssignedToUserId { get; protected set; }
    
    public DateTime CreatedDate { get; }
    public DateTime? LastUpdated { get; }
    public string? CreatedByUserId { get; }
    public string? LastUpdatedByUserId { get; }
    public string? CreatedByIp { get; }
    public string? LastUpdatedByIp { get; }

    #endregion
    
    
}