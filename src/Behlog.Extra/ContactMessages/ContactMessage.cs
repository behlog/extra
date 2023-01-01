namespace Behlog.Extra;


public class ContactMessage : AggregateRoot<Guid>, IHasMetadata
{
    
    private ContactMessage() { }
    
    #region props

    public string AuthorName { get; protected set; }
    public string? Subject { get; protected set; }
    public string? PhoneNumber { get; protected set; }
    public string? Email { get; protected set; }
    public string? Website { get; protected set; }
    public string Message { get; protected set; }
    
    public DateTime CreatedDate { get; }
    public DateTime? LastUpdated { get; }
    public string? CreatedByUserId { get; }
    public string? LastUpdatedByUserId { get; }
    public string? CreatedByIp { get; }
    public string? LastUpdatedByIp { get; }

    #endregion
    
    
}