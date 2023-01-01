namespace Behlog.Extra;

/// <summary>
/// Status indicator for the <see cref="ContactMessage"/>
/// </summary>
public enum ContactMessageStatus
{
    /// <summary>
    /// Mark As spam
    /// </summary>
    Spam = -2,
    
    /// <summary>
    /// Mark as Deleted 
    /// </summary>
    Deleted = -1,
    
    /// <summary>
    /// The Default status for Newly created Contact Messages
    /// </summary>
    New = 0,
    
    /// <summary>
    /// When a user opens and sees the Contact Message
    /// </summary>
    Seen = 1,
    
    /// <summary>
    /// When the Contact Message Assigned to a User in order to follow-up the message.
    /// </summary>
    Assigned = 2,
    
    /// <summary>
    /// When the message is being followed-up.
    /// </summary>
    InProgress = 3,
    
    /// <summary>
    /// When a reply message sent for this Contact Message.
    /// </summary>
    Replied = 4,
    
    /// <summary>
    /// When we done with the Contact Message.
    /// </summary>
    Done = 10
}