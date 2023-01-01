namespace Behlog.Extra.Commands;

public class MarkContactMessageAsSeenCommand : IBehlogCommand
{
    public MarkContactMessageAsSeenCommand(Guid contactMessageId)
    {
        contactMessageId.ThrowIfGuidIsEmpty(
            new BehlogInvalidEntityIdException(nameof(ContactMessage)));

        Id = contactMessageId;
    }
    
    public Guid Id { get; }
}