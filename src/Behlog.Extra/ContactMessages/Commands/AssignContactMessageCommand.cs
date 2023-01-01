namespace Behlog.Extra.Commands;

public class AssignContactMessageCommand : IBehlogCommand<CommandResult>
{
    public AssignContactMessageCommand(Guid contactMessageId, string? assignToUserId)
    {
        contactMessageId.ThrowIfGuidIsEmpty(
            new BehlogInvalidEntityIdException(nameof(ContactMessage)));

        Id = contactMessageId;
        AssignToUserId = assignToUserId;
    }
    
    public Guid Id { get; }
    
    public string? AssignToUserId { get; }
}